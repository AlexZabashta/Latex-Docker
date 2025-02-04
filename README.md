# Описание
Данное приложение позволяет компилировать **LaTex** проекты под *Windows* используя **ssh** подключение к виртуальной или реальной машине с установленным *latex*-ом. В качестве виртуальной машины используется Docker контейнер.

***Внимание!*** Текущая версия приложения написана в синхронном режиме. Это значит, что при запуске некоторых операций будет казаться, что оно зависло. Но это не так, в это время оно ожидает завершение других операций. Не спешите закрывайте его, даже если *Windows* предлагает вам сделать это!!!

# Установка
## 1. LatexSSH
Достаточно скачать файл [LatexSSH.zip](https://github.com/AlexZabashta/Latex-Docker/blob/master/LatexSSH.zip?raw=true) из данного репозитория и распаковать его в любую папку, например *LatexSSH*.

## 2. Docker
Скачиваем [Docker Toolbox](https://github.com/docker/toolbox/releases) (достаточно скачать **.exe** файл). Устанавливаем его и всё, что он предлагает.  
Если у вас уже установлена другая версия *Docker*-а (например *Docker Desktop*), значит вы знаете, что это такое и сможете адаптировать эту инструкцию для него. Ставить *Docker Desktop* не рекомендуется, так как он "сломает" ваш VirtualBox. Также инструкция по работе с ним может отличаться.

## 3. Docker-Machine
Запускаем ярлык **Docker Quickstart Terminal** с рабочего стола. Он создаст и запустит *Docker машину*. Если его нету, запустите **docker-start.cmd** из папки, в которую вы установили **Docker Toolbox** (*C:\Program Files\Docker Toolbox*).

## 4. Docker Image
Запустите **build-docker-image.bat** из папки **LatexSSH**. Дождитесь завершения установки *sshlatex* образа. Это может занять час или больше, так как требуется скачать ~4Gb данных. Всего будет занято ~8Gb на жёстком диске.  
Также образ можно построить нажав на кнопку **Build image** в **LatexSSH.exe**. Но в таком случае, не забывайте про ложное зависание программы!  
Посмотреть собранные образы можно нажав на кнопку **List images** в **LatexSSH.exe**.

# Работа
## 1. Запуск Docker-Machine
Для работы необходимо сперва запустить *Docker машину*. Это можно сделать **одним** из следующих способов:
1. Нажав на кнопку **Start docker-machine** в **LatexSSH.exe**.
2. Запустив ярлык **Docker Quickstart Terminal** с рабочего стола, либо **docker-start.cmd** из папки *Docker Toolbox*.
3. Запустив **start-docker-machine.bat** из папки **LatexSSH**.

Если вы закрыли приложение **LatexSSH.exe** и открыли его опять, запускать *Docker машину* заново не требуется.

## 2. Запуск Docker контейнера
Далее необходимо запустить *Docker контейнер* с *sshlatex* образом. Это можно сделать **одним** из следующих способов:
1. Нажав на кнопку **Run** в **LatexSSH.exe**.
2. Запустив **run-docker-image.bat** из папки **LatexSSH**.

Посмотреть запущенные контейнеры можно нажав на кнопку **List containers** в **LatexSSH.exe**.  
Если вы закрыли приложение **LatexSSH.exe** и открыли его опять, запускать *Docker контейнер* заново не требуется.

## 3. Установка IP-адреса ssh сервера контейнера
Нажмите на кнопку **Auto detect IP** для получения IP-адреса ssh сервера, либо укажите его вручную.

## 4. Путь к LaTex проекту
Используйте текстовое поле **Target file full path**, чтобы указать путь к главному файлу вашего проекта, при этом папка, в которой он лежит, будет считаться корневой папкой вашего проекта.

## 4. Путь для результатов компиляции
Используйте текстовое поле **Result directory**, чтобы указать путь к папке, в которой будут созданы результаты компиляции: **.pdf** файл и лог компиляции.

## 5. Компиляция проекта
Нажмите на кнопку **Compile** для компиляции проекта. Компиляция может занять несколько минут в зависимости от сложности проекта. Не забывайте про ложное зависание!

## 6. Завершение работы
Перед завершением работы **Windows** необходимо остановить *Docker машину*. Это можно сделать **одним** из следующих способов:
1. Нажав на кнопку **Stop docker-machine** в **LatexSSH.exe**.
2. Запустив **stop-docker-machine.bat** из папки **LatexSSH**.


# Ссылки
Репозиторий Docker Toolbox:
* https://github.com/docker/toolbox

Docker Desktop:
* https://www.docker.com/products/docker-desktop

Используемый Dockerfile основан на:
* https://hub.docker.com/r/raabf/latex-versions
* https://github.com/raabf/dockertex

Поддержка шрифтов взята из:
* https://github.com/AndreyAkinshin/Russian-Phd-LaTeX-Dissertation-Template/
* http://dissovet.itmo.ru/index.php?main=112

C# библиотека для SSH подключений:
* https://github.com/sshnet/SSH.NET
