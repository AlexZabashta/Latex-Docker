using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Sftp;

using System.Diagnostics;
using System.Threading.Tasks;

namespace LatexSSH
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Transfer(SftpClient sftp, DirectoryInfo from, string to)
        {
            AddLine("Creating directory " + to);
            sftp.CreateDirectory(to);
            foreach (DirectoryInfo directory in from.GetDirectories())
            {
                Transfer(sftp, directory, to + directory.Name + "/");
            }

            foreach (FileInfo file in from.GetFiles())
            {
                string path = to + file.Name;
                AddLine("Transfer " + path);
                using (Stream input = file.OpenRead())
                {
                    sftp.UploadFile(input, path);
                }
            }
        }


        private void Exec(SshClient ssh, string command, String logFile)
        {
            if (logFile == null)
            {
                StreamWriter writer = null;
                ExecAndLog(ssh, command, writer);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(logFile))
                {
                    ExecAndLog(ssh, command, writer);
                }
            }
        }

        private void ExecAndLog(SshClient ssh, string command, StreamWriter writer)
        {
            var cmd = ssh.CreateCommand(command);
            //AddLine("Execute: " + command + " " + cmd.Execute());
            AddLine("Execute: " + command);
            cmd.Execute();

            using (StreamReader reader = new StreamReader(cmd.ExtendedOutputStream, Encoding.UTF8, true, 1024))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    AddLine(line);
                    if (writer != null)
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            AddLine("exit status = " + cmd.ExitStatus);
        }




        private void Compile_Click(object sender, EventArgs e)
        {
            try
            {



                mainTextBox.Text = "";

                string targetFilePath = projectDirTextBox.Text;

                int sep = targetFilePath.LastIndexOf('\\');
                if (sep < 0)
                {
                    throw new Exception("Can't find \\ separator in target file path.");
                }

                string localFolder = targetFilePath.Substring(0, sep + 1);
                string mainFile = targetFilePath.Substring(sep + 1);

                if (mainFile.ToLower().EndsWith(".tex") == false)
                {
                    throw new Exception("Target file must be .tex file");
                }

                mainFile = mainFile.Substring(0, mainFile.Length - 4);


                AddLine("Start compilation");
                AddLine("Main file = " + mainFile);
                AddLine("Target directory = " + localFolder);


                DateTime dateTime = DateTime.Now;
                string time = dateTime.ToString("yyyy_MM_dd_HH_mm_ss_") + dateTime.Millisecond.ToString("D3");
                string sftpFolder = workDirTextBox.Text + "/" + time + "/";

                string host = ipTextBox.Text;
                int port = Int32.Parse(portTextBox.Text);
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                string res = resDirTextBox.Text;

                string remRes = sftpFolder + mainFile + ".pdf";
                string locRes = res + "\\" + time + ".pdf";

                using (SftpClient sftp = new SftpClient(host, port, username, password))
                {
                    AddLine("Connecting to sftp://" + username + "@" + host + ":" + port);
                    sftp.Connect();


                    using (SshClient ssh = new SshClient(host, port, username, password))
                    {
                        AddLine("Connecting to ssh://" + username + "@" + host + ":" + port);
                        ssh.Connect();

                        AddLine("Transfering files:");
                        Transfer(sftp, new DirectoryInfo(localFolder), sftpFolder);

                        Exec(ssh, "cd \"" + sftpFolder + "\" && " + compileCmdTextBox.Text + " " + mainFile, res + "\\log" + time + ".txt");



                        if (sftp.Exists(remRes))
                        {
                            using (Stream stream = File.OpenWrite(locRes))
                            {
                                sftp.DownloadFile(remRes, stream);
                            }
                        }

                        if (remWorkDirChBox.Checked)
                        {
                            Exec(ssh, "rm -rf \"" + sftpFolder + "\"", null);
                        }
                        ssh.Disconnect();
                    }
                    sftp.Disconnect();
                }

                if (autoOpenChBox.Checked && File.Exists(locRes))
                {
                    Process.Start("explorer.exe", "\"" + locRes + "\"");
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        int dw = 40;
        int dh = 80;
        int dl = 100;

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void AddLine(string line)
        {
            mainTextBox.AppendText(line + Environment.NewLine);
        }
        private void GetIP_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process cmd = new Process())
                {

                    RunDockerMachine(cmd, "env");

                    string line;
                    while ((line = cmd.StandardOutput.ReadLine()) != null)
                    {
                        AddLine(line);
                        if (line.Contains("SET DOCKER_HOST"))
                        {
                            string[] values = line.Split(':');
                            ipTextBox.Text = values[1].Substring(2);
                        }
                    }

                    while ((line = cmd.StandardError.ReadLine()) != null)
                    {
                        AddLine(line);
                    }

                    cmd.WaitForExit();
                    AddLine("");

                    int exitCode = cmd.ExitCode;
                    if (exitCode == 0)
                    {
                        AddLine("Success!");
                    }
                    else
                    {
                        AddLine("Fail. Exit code = " + exitCode);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dw = Math.Max(30, Width - mainTextBox.Width);
            dh = Math.Max(30, Height - mainTextBox.Height);
            dl = Math.Max(100, Width - compileCmdTextBox.Width);

            projectDirTextBox.Text = Directory.GetCurrentDirectory() + "\\latex\\" + "main.tex";
            resDirTextBox.Text = Directory.GetCurrentDirectory();

        }


        private void RunDockerMachine(Process cmd, string args)
        {
            Run(cmd, dockerMachineCmdTextBox.Text, args);
        }

        private void Run(Process cmd, string name, string args)
        {
            mainTextBox.Text = "";
            cmd.StartInfo.FileName = name;
            cmd.StartInfo.Arguments = args;

            AddLine("Execution " + cmd.StartInfo.FileName + " " + cmd.StartInfo.Arguments);
            AddLine("");

            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
        }

        private void RunDocker(Process cmd, string args)
        {
            Run(cmd, dockerCmdTextBox.Text, args);
        }

        private void runDocker(string args)
        {
            try
            {
                using (Process cmd = new Process())
                {
                    RunDocker(cmd, args);
                    PrintOutErrStreams(cmd);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }


        private void printStream(StreamReader stream)
        {
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                AddLine(line);
            }
        }

        private void PrintOutErrStreams(Process cmd, bool printOut = true)
        {
            if (printOut)
            {
                printStream(cmd.StandardOutput);
            }

            printStream(cmd.StandardError);

            cmd.WaitForExit();
            AddLine("");

            int exitCode = cmd.ExitCode;
            if (exitCode == 0)
            {
                AddLine("Success!");
            }
            else
            {
                AddLine("Fail. Exit code = " + exitCode);
            }
        }

        private void StartDmButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process cmd = new Process())
                {

                    RunDockerMachine(cmd, "start");
                    PrintOutErrStreams(cmd);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void StopDmButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process cmd = new Process())
                {

                    RunDockerMachine(cmd, "stop");
                    PrintOutErrStreams(cmd);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void ListImagesbutton_Click(object sender, EventArgs e)
        {
            runDocker("image ls");
        }

        private void ListContbutton_Click(object sender, EventArgs e)
        {
            runDocker("ps -a");
        }

        private void BuildImgButton_Click(object sender, EventArgs e)
        {
            runDocker("build -t " + imageName.Text + " " + dockerFileTextBox.Text);
        }

        private void RunDockerImgButton_Click(object sender, EventArgs e)
        {
            runDocker("run -d -p " + portTextBox.Text + ":22 --name " + containerNameTextBox.Text + " --mount type=tmpfs,destination=" + workDirTextBox.Text + " " + imageName.Text);
        }

        private void StopContainerButton_Click(object sender, EventArgs e)
        {
            runDocker("stop " + containerNameTextBox.Text);
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            runDocker("image rm " + imageName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runDocker("rm " + containerNameTextBox.Text);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            mainTextBox.Width = Width - dw;
            mainTextBox.Height = Height - dh;
            compileCmdTextBox.Width = Width - dl;
        }
    }
}

