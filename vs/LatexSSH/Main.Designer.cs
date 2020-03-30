namespace LatexSSH
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.compile = new System.Windows.Forms.Button();
            this.getIP = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.poretLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.buildImgButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.dockerCmdLabel = new System.Windows.Forms.Label();
            this.dockerCmdTextBox = new System.Windows.Forms.TextBox();
            this.dockerMachineCmdLabel = new System.Windows.Forms.Label();
            this.dockerMachineCmdTextBox = new System.Windows.Forms.TextBox();
            this.StartDmButton = new System.Windows.Forms.Button();
            this.stopDmButton = new System.Windows.Forms.Button();
            this.listImagesbutton = new System.Windows.Forms.Button();
            this.listContbutton = new System.Windows.Forms.Button();
            this.DockerFileLabel = new System.Windows.Forms.Label();
            this.dockerFileTextBox = new System.Windows.Forms.TextBox();
            this.imageNameLabel = new System.Windows.Forms.Label();
            this.imageName = new System.Windows.Forms.TextBox();
            this.runDockerImgButton = new System.Windows.Forms.Button();
            this.containerNameLabel = new System.Windows.Forms.Label();
            this.containerNameTextBox = new System.Windows.Forms.TextBox();
            this.stopContainerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.removeImageButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.workDirTextBox = new System.Windows.Forms.TextBox();
            this.workDirLabel = new System.Windows.Forms.Label();
            this.projectDirLabel = new System.Windows.Forms.Label();
            this.projectDirTextBox = new System.Windows.Forms.TextBox();
            this.autoOpenChBox = new System.Windows.Forms.CheckBox();
            this.compileCmdTextBox = new System.Windows.Forms.TextBox();
            this.compileCmdLabel = new System.Windows.Forms.Label();
            this.remWorkDirChBox = new System.Windows.Forms.CheckBox();
            this.resDirLabel = new System.Windows.Forms.Label();
            this.resDirTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // compile
            // 
            this.compile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compile.Location = new System.Drawing.Point(499, 610);
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(133, 59);
            this.compile.TabIndex = 0;
            this.compile.Text = "Compile";
            this.compile.UseVisualStyleBackColor = true;
            this.compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // getIP
            // 
            this.getIP.Location = new System.Drawing.Point(331, 180);
            this.getIP.Name = "getIP";
            this.getIP.Size = new System.Drawing.Size(146, 23);
            this.getIP.TabIndex = 1;
            this.getIP.Text = "Auto detect IP";
            this.getIP.UseVisualStyleBackColor = true;
            this.getIP.Click += new System.EventHandler(this.GetIP_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(155, 182);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(158, 20);
            this.ipTextBox.TabIndex = 2;
            this.ipTextBox.Text = "127.0.0.1";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(530, 182);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(48, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "2222";
            // 
            // poretLabel
            // 
            this.poretLabel.AutoSize = true;
            this.poretLabel.Location = new System.Drawing.Point(496, 185);
            this.poretLabel.Name = "poretLabel";
            this.poretLabel.Size = new System.Drawing.Size(28, 13);
            this.poretLabel.TabIndex = 4;
            this.poretLabel.Text = "port:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(129, 185);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(20, 13);
            this.ipLabel.TabIndex = 5;
            this.ipLabel.Text = "IP:";
            // 
            // buildImgButton
            // 
            this.buildImgButton.Location = new System.Drawing.Point(331, 105);
            this.buildImgButton.Name = "buildImgButton";
            this.buildImgButton.Size = new System.Drawing.Size(146, 23);
            this.buildImgButton.TabIndex = 6;
            this.buildImgButton.Text = "Build  image";
            this.buildImgButton.UseVisualStyleBackColor = true;
            this.buildImgButton.Click += new System.EventHandler(this.BuildImgButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.Color.White;
            this.mainTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextBox.Location = new System.Drawing.Point(15, 355);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(616, 241);
            this.mainTextBox.TabIndex = 7;
            // 
            // dockerCmdLabel
            // 
            this.dockerCmdLabel.AutoSize = true;
            this.dockerCmdLabel.Location = new System.Drawing.Point(55, 42);
            this.dockerCmdLabel.Name = "dockerCmdLabel";
            this.dockerCmdLabel.Size = new System.Drawing.Size(94, 13);
            this.dockerCmdLabel.TabIndex = 8;
            this.dockerCmdLabel.Text = "Docker command:";
            // 
            // dockerCmdTextBox
            // 
            this.dockerCmdTextBox.Location = new System.Drawing.Point(155, 38);
            this.dockerCmdTextBox.Name = "dockerCmdTextBox";
            this.dockerCmdTextBox.Size = new System.Drawing.Size(158, 20);
            this.dockerCmdTextBox.TabIndex = 9;
            this.dockerCmdTextBox.Text = "docker";
            // 
            // dockerMachineCmdLabel
            // 
            this.dockerMachineCmdLabel.AutoSize = true;
            this.dockerMachineCmdLabel.Location = new System.Drawing.Point(12, 9);
            this.dockerMachineCmdLabel.Name = "dockerMachineCmdLabel";
            this.dockerMachineCmdLabel.Size = new System.Drawing.Size(137, 13);
            this.dockerMachineCmdLabel.TabIndex = 10;
            this.dockerMachineCmdLabel.Text = "Docker-machine command:";
            // 
            // dockerMachineCmdTextBox
            // 
            this.dockerMachineCmdTextBox.Location = new System.Drawing.Point(155, 6);
            this.dockerMachineCmdTextBox.Name = "dockerMachineCmdTextBox";
            this.dockerMachineCmdTextBox.Size = new System.Drawing.Size(158, 20);
            this.dockerMachineCmdTextBox.TabIndex = 11;
            this.dockerMachineCmdTextBox.Text = "docker-machine";
            // 
            // StartDmButton
            // 
            this.StartDmButton.Location = new System.Drawing.Point(331, 6);
            this.StartDmButton.Name = "StartDmButton";
            this.StartDmButton.Size = new System.Drawing.Size(146, 23);
            this.StartDmButton.TabIndex = 12;
            this.StartDmButton.Text = "Start docker-machine";
            this.StartDmButton.UseVisualStyleBackColor = true;
            this.StartDmButton.Click += new System.EventHandler(this.StartDmButton_Click);
            // 
            // stopDmButton
            // 
            this.stopDmButton.Location = new System.Drawing.Point(485, 6);
            this.stopDmButton.Name = "stopDmButton";
            this.stopDmButton.Size = new System.Drawing.Size(146, 23);
            this.stopDmButton.TabIndex = 13;
            this.stopDmButton.Text = "Stop docker-machine";
            this.stopDmButton.UseVisualStyleBackColor = true;
            this.stopDmButton.Click += new System.EventHandler(this.StopDmButton_Click);
            // 
            // listImagesbutton
            // 
            this.listImagesbutton.Location = new System.Drawing.Point(331, 37);
            this.listImagesbutton.Name = "listImagesbutton";
            this.listImagesbutton.Size = new System.Drawing.Size(146, 23);
            this.listImagesbutton.TabIndex = 14;
            this.listImagesbutton.Text = "List images";
            this.listImagesbutton.UseVisualStyleBackColor = true;
            this.listImagesbutton.Click += new System.EventHandler(this.ListImagesbutton_Click);
            // 
            // listContbutton
            // 
            this.listContbutton.Location = new System.Drawing.Point(485, 37);
            this.listContbutton.Name = "listContbutton";
            this.listContbutton.Size = new System.Drawing.Size(146, 23);
            this.listContbutton.TabIndex = 15;
            this.listContbutton.Text = "List containers";
            this.listContbutton.UseVisualStyleBackColor = true;
            this.listContbutton.Click += new System.EventHandler(this.ListContbutton_Click);
            // 
            // DockerFileLabel
            // 
            this.DockerFileLabel.AutoSize = true;
            this.DockerFileLabel.Location = new System.Drawing.Point(48, 71);
            this.DockerFileLabel.Name = "DockerFileLabel";
            this.DockerFileLabel.Size = new System.Drawing.Size(101, 13);
            this.DockerFileLabel.TabIndex = 16;
            this.DockerFileLabel.Text = "Dockerfile directory:";
            // 
            // dockerFileTextBox
            // 
            this.dockerFileTextBox.Location = new System.Drawing.Point(155, 68);
            this.dockerFileTextBox.Name = "dockerFileTextBox";
            this.dockerFileTextBox.Size = new System.Drawing.Size(158, 20);
            this.dockerFileTextBox.TabIndex = 18;
            this.dockerFileTextBox.Text = "sshlatex";
            // 
            // imageNameLabel
            // 
            this.imageNameLabel.AutoSize = true;
            this.imageNameLabel.Location = new System.Drawing.Point(81, 110);
            this.imageNameLabel.Name = "imageNameLabel";
            this.imageNameLabel.Size = new System.Drawing.Size(68, 13);
            this.imageNameLabel.TabIndex = 19;
            this.imageNameLabel.Text = "Image name:";
            // 
            // imageName
            // 
            this.imageName.Location = new System.Drawing.Point(155, 107);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(158, 20);
            this.imageName.TabIndex = 20;
            this.imageName.Text = "sshlatex";
            // 
            // runDockerImgButton
            // 
            this.runDockerImgButton.Location = new System.Drawing.Point(331, 135);
            this.runDockerImgButton.Name = "runDockerImgButton";
            this.runDockerImgButton.Size = new System.Drawing.Size(95, 23);
            this.runDockerImgButton.TabIndex = 21;
            this.runDockerImgButton.Text = "Run";
            this.runDockerImgButton.UseVisualStyleBackColor = true;
            this.runDockerImgButton.Click += new System.EventHandler(this.RunDockerImgButton_Click);
            // 
            // containerNameLabel
            // 
            this.containerNameLabel.AutoSize = true;
            this.containerNameLabel.Location = new System.Drawing.Point(65, 140);
            this.containerNameLabel.Name = "containerNameLabel";
            this.containerNameLabel.Size = new System.Drawing.Size(84, 13);
            this.containerNameLabel.TabIndex = 22;
            this.containerNameLabel.Text = "Container name:";
            // 
            // containerNameTextBox
            // 
            this.containerNameTextBox.Location = new System.Drawing.Point(155, 137);
            this.containerNameTextBox.Name = "containerNameTextBox";
            this.containerNameTextBox.Size = new System.Drawing.Size(158, 20);
            this.containerNameTextBox.TabIndex = 23;
            this.containerNameTextBox.Text = "sshlatex";
            // 
            // stopContainerButton
            // 
            this.stopContainerButton.Location = new System.Drawing.Point(435, 135);
            this.stopContainerButton.Name = "stopContainerButton";
            this.stopContainerButton.Size = new System.Drawing.Size(95, 23);
            this.stopContainerButton.TabIndex = 24;
            this.stopContainerButton.Text = "Stop";
            this.stopContainerButton.UseVisualStyleBackColor = true;
            this.stopContainerButton.Click += new System.EventHandler(this.StopContainerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeImageButton
            // 
            this.removeImageButton.Location = new System.Drawing.Point(485, 105);
            this.removeImageButton.Name = "removeImageButton";
            this.removeImageButton.Size = new System.Drawing.Size(146, 23);
            this.removeImageButton.TabIndex = 26;
            this.removeImageButton.Text = "Remove image";
            this.removeImageButton.UseVisualStyleBackColor = true;
            this.removeImageButton.Click += new System.EventHandler(this.RemoveImageButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(93, 215);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(56, 13);
            this.usernameLabel.TabIndex = 27;
            this.usernameLabel.Text = "username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(155, 212);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(158, 20);
            this.usernameTextBox.TabIndex = 28;
            this.usernameTextBox.Text = "root";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(359, 215);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(55, 13);
            this.passwordLabel.TabIndex = 29;
            this.passwordLabel.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(420, 212);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(158, 20);
            this.passwordTextBox.TabIndex = 30;
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // workDirTextBox
            // 
            this.workDirTextBox.Location = new System.Drawing.Point(155, 242);
            this.workDirTextBox.Name = "workDirTextBox";
            this.workDirTextBox.Size = new System.Drawing.Size(476, 20);
            this.workDirTextBox.TabIndex = 31;
            this.workDirTextBox.Text = "/tmp/latex";
            // 
            // workDirLabel
            // 
            this.workDirLabel.AutoSize = true;
            this.workDirLabel.Location = new System.Drawing.Point(56, 245);
            this.workDirLabel.Name = "workDirLabel";
            this.workDirLabel.Size = new System.Drawing.Size(93, 13);
            this.workDirLabel.TabIndex = 32;
            this.workDirLabel.Text = "Working directory:";
            // 
            // projectDirLabel
            // 
            this.projectDirLabel.AutoSize = true;
            this.projectDirLabel.Location = new System.Drawing.Point(52, 287);
            this.projectDirLabel.Name = "projectDirLabel";
            this.projectDirLabel.Size = new System.Drawing.Size(97, 13);
            this.projectDirLabel.TabIndex = 33;
            this.projectDirLabel.Text = "Target file full path:";
            // 
            // projectDirTextBox
            // 
            this.projectDirTextBox.Location = new System.Drawing.Point(155, 284);
            this.projectDirTextBox.Name = "projectDirTextBox";
            this.projectDirTextBox.Size = new System.Drawing.Size(476, 20);
            this.projectDirTextBox.TabIndex = 34;
            // 
            // autoOpenChBox
            // 
            this.autoOpenChBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autoOpenChBox.AutoSize = true;
            this.autoOpenChBox.Checked = true;
            this.autoOpenChBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoOpenChBox.Location = new System.Drawing.Point(390, 645);
            this.autoOpenChBox.Name = "autoOpenChBox";
            this.autoOpenChBox.Size = new System.Drawing.Size(100, 17);
            this.autoOpenChBox.TabIndex = 35;
            this.autoOpenChBox.Text = "Automatic open";
            this.autoOpenChBox.UseVisualStyleBackColor = true;
            // 
            // compileCmdTextBox
            // 
            this.compileCmdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.compileCmdTextBox.Location = new System.Drawing.Point(155, 610);
            this.compileCmdTextBox.Name = "compileCmdTextBox";
            this.compileCmdTextBox.Size = new System.Drawing.Size(338, 20);
            this.compileCmdTextBox.TabIndex = 36;
            this.compileCmdTextBox.Text = "latexmk -pdf -pdflatex=\"xelatex --shell-escape --interaction=nonstopmode --syncte" +
    "x=1 %O %S\"";
            // 
            // compileCmdLabel
            // 
            this.compileCmdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.compileCmdLabel.AutoSize = true;
            this.compileCmdLabel.Location = new System.Drawing.Point(70, 613);
            this.compileCmdLabel.Name = "compileCmdLabel";
            this.compileCmdLabel.Size = new System.Drawing.Size(79, 13);
            this.compileCmdLabel.TabIndex = 37;
            this.compileCmdLabel.Text = "Latex commnd:";
            // 
            // remWorkDirChBox
            // 
            this.remWorkDirChBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remWorkDirChBox.AutoSize = true;
            this.remWorkDirChBox.Checked = true;
            this.remWorkDirChBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.remWorkDirChBox.Location = new System.Drawing.Point(249, 645);
            this.remWorkDirChBox.Name = "remWorkDirChBox";
            this.remWorkDirChBox.Size = new System.Drawing.Size(135, 17);
            this.remWorkDirChBox.TabIndex = 38;
            this.remWorkDirChBox.Text = "Delete remote directory";
            this.remWorkDirChBox.UseVisualStyleBackColor = true;
            // 
            // resDirLabel
            // 
            this.resDirLabel.AutoSize = true;
            this.resDirLabel.Location = new System.Drawing.Point(66, 317);
            this.resDirLabel.Name = "resDirLabel";
            this.resDirLabel.Size = new System.Drawing.Size(83, 13);
            this.resDirLabel.TabIndex = 39;
            this.resDirLabel.Text = "Result directory:";
            // 
            // resDirTextBox
            // 
            this.resDirTextBox.Location = new System.Drawing.Point(155, 314);
            this.resDirTextBox.Name = "resDirTextBox";
            this.resDirTextBox.Size = new System.Drawing.Size(476, 20);
            this.resDirTextBox.TabIndex = 40;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 681);
            this.Controls.Add(this.resDirTextBox);
            this.Controls.Add(this.resDirLabel);
            this.Controls.Add(this.remWorkDirChBox);
            this.Controls.Add(this.compileCmdLabel);
            this.Controls.Add(this.compileCmdTextBox);
            this.Controls.Add(this.autoOpenChBox);
            this.Controls.Add(this.projectDirTextBox);
            this.Controls.Add(this.projectDirLabel);
            this.Controls.Add(this.workDirLabel);
            this.Controls.Add(this.workDirTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.removeImageButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopContainerButton);
            this.Controls.Add(this.containerNameTextBox);
            this.Controls.Add(this.containerNameLabel);
            this.Controls.Add(this.runDockerImgButton);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.imageNameLabel);
            this.Controls.Add(this.dockerFileTextBox);
            this.Controls.Add(this.DockerFileLabel);
            this.Controls.Add(this.listContbutton);
            this.Controls.Add(this.listImagesbutton);
            this.Controls.Add(this.stopDmButton);
            this.Controls.Add(this.StartDmButton);
            this.Controls.Add(this.dockerMachineCmdTextBox);
            this.Controls.Add(this.dockerMachineCmdLabel);
            this.Controls.Add(this.dockerCmdTextBox);
            this.Controls.Add(this.dockerCmdLabel);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.buildImgButton);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.poretLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.getIP);
            this.Controls.Add(this.compile);
            this.MinimumSize = new System.Drawing.Size(660, 720);
            this.Name = "MainForm";
            this.Text = "LatexSSH";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.Button getIP;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label poretLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button buildImgButton;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Label dockerCmdLabel;
        private System.Windows.Forms.TextBox dockerCmdTextBox;
        private System.Windows.Forms.Label dockerMachineCmdLabel;
        private System.Windows.Forms.TextBox dockerMachineCmdTextBox;
        private System.Windows.Forms.Button StartDmButton;
        private System.Windows.Forms.Button stopDmButton;
        private System.Windows.Forms.Button listImagesbutton;
        private System.Windows.Forms.Button listContbutton;
        private System.Windows.Forms.Label DockerFileLabel;
        private System.Windows.Forms.TextBox dockerFileTextBox;
        private System.Windows.Forms.Label imageNameLabel;
        private System.Windows.Forms.TextBox imageName;
        private System.Windows.Forms.Button runDockerImgButton;
        private System.Windows.Forms.Label containerNameLabel;
        private System.Windows.Forms.TextBox containerNameTextBox;
        private System.Windows.Forms.Button stopContainerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removeImageButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox workDirTextBox;
        private System.Windows.Forms.Label workDirLabel;
        private System.Windows.Forms.Label projectDirLabel;
        private System.Windows.Forms.TextBox projectDirTextBox;
        private System.Windows.Forms.CheckBox autoOpenChBox;
        private System.Windows.Forms.TextBox compileCmdTextBox;
        private System.Windows.Forms.Label compileCmdLabel;
        private System.Windows.Forms.CheckBox remWorkDirChBox;
        private System.Windows.Forms.Label resDirLabel;
        private System.Windows.Forms.TextBox resDirTextBox;
    }
}

