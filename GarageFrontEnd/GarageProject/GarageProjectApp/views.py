from urllib import request
from django.shortcuts import render
import requests
# Create your views here.

def index(request):
    api = "https://localhost:44375/api/Garage/"
    response = requests.get(api, verify=False).json()
    return render(request, 'index.html', {'response': response})
