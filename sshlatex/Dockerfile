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

EXPOSE 22

CMD ["/usr/sbin/sshd", "-D"]
