import requests
from bs4 import BeautifulSoup
import sys
from random_user_agent import *


def get_page_soup(url):
    url = url
    headers = {
                'accept': 'text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8',
                'accept-encoding': 'gzip, deflate, br',
                'accept-language': 'en-US,en;q=0.9',
                'cache-control': 'max-age=0',
                'locale': 'en_US',
                'upgrade-insecure-requests': '1',
                'user-agent': get_user_agent()
              }

    page = requests.get(url,headers=headers)
    soup = BeautifulSoup(page.text)

    return soup
