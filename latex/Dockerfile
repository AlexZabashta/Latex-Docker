FROM raabf/latex-versions:texlive2018
RUN echo 'deb http://deb.debian.org/debian/ buster  contrib non-free' >> /etc/apt/sources.list
RUN echo ttf-mscorefonts-installer msttcorefonts/accepted-mscorefonts-eula select true | debconf-set-selections 
RUN apt-get update -q && DEBIAN_FRONTEND=noninteractive apt-get install -qy fonts-liberation ttf-mscorefonts-installer openssh-server
RUN fc-cache -f -v

RUN mkdir /var/run/sshd


RUN sed -i "/PermitRootLogin/s/#Permit/Permit/" /etc/ssh/sshd_config
RUN sed -i "/PermitRootLogin/s/prohibit-password/yes/" /etc/ssh/sshd_config
RUN sed -i "s/UsePAM yes/#UsePAM yes/g" /etc/ssh/sshd_config

RUN echo 'root:password' | chpasswd

#RUN sed -i 's/PermitRootLogin prohibit-password/PermitRootLogin yes/' /etc/ssh/sshd_config
#RUN sed 's@session\s*required\s*pam_loginuid.so@session optional pam_loginuid.so@g' -i /etc/pam.d/sshd
#ENV NOTVISIBLE "in users profile"
#RUN echo "export VISIBLE=now" >> /etc/profile


#RUN sed 's/PermitRootLogin without-password/PermitRootLogin yes/' -i /etc/ssh/sshd_config

#RUN sed 's/#PermitRootLogin yes/PermitRootLogin yes/' -i /etc/ssh/sshd_config

#RUN ssh-keygen -t rsa -f /etc/ssh/ssh_host_rsa_key -N ''

EXPOSE 22

CMD ["/usr/sbin/sshd", "-D"]
