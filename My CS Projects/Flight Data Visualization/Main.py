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
    for flight in data:
        airline = flight['airline']['name']
        airlines[airline] = airlines.get(airline, 0) + 1
    sorted_airlines = sorted(airlines.items(), key=lambda x: x[1], reverse=True)
    names, counts = zip(*sorted_airlines)
    print('\ncounts -->\n', counts)
    plt.figure(figsize=(10, 6))
    plt.bar(names, counts)
    plt.xlabel('Airlines')
    plt.ylabel('Number of Flights')
    plt.title('Number of Flights by Airline')
    plt.xticks(rotation=45, ha='right', rotation_mode='anchor')
    plt.subplots_adjust(bottom=0.4)
    plt.tight_layout()
    plt.show()

if __name__ == '__main__':
    API_KEY = 'a008b8e7d69952bfbc6cd33ff6ffc2c8'
    flight_data = fetch_live_flight_data(API_KEY)
    print('\n*** Verified ***')
    if flight_data:
        create_airline_bar_chart(flight_data)