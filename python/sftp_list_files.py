import os
import pysftp

SFTP_HOST = "xxx.xx.xx.xx"
SFTP_USER = "xxxxxxx"
SFTP_PWD = "xxxxxxx"

with pysftp.Connection(host=SFTP_HOST, username=SFTP_USER, password=SFTP_PWD) as svc:
    file_list = svc.listdir()
