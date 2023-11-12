# Sami Munir
# smunir2001@gmail.com
# Rutgers University
# Flight Data Visualization

print('Flight Data Visualization')
print('-------------------------')

import requests
import matplotlib.pyplot as plt

def fetch_live_flight_data(API_KEY):
    base_URL = 'http://api.aviationstack.com/v1/flights'
    try:
        response = requests.get(f'{base_URL}?access_key={API_KEY}')
        response.raise_for_status()
        data = response.json()
        return data['data']
    except requests.exceptions.RequestException as e:
        print(f'Error fethcing data: {e}')
        return None

def create_airline_bar_chart(data):
    if not data:
        return
    airlines = {}