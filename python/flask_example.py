'''
Install & run ngrok (tunnel to localhost)
Run the code below, field requests
'''

from flask import Flask, request, Response

#Initializing flask instance

app = Flask(__name__)
