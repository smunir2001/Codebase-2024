# Sami Munir
# November 7th, 2023
# smunir2001@gmail.com
# Rutgers University
# AI Airspace

import pygame
import random
import math

# Initialize pygame
pygame.init()

# Screen dimensions
screen_width = 800
screen_height = 600

# Create the screen
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.display.set_caption('AI Airspace Simulation')

# Aircraft class
class Aircraft:
    def __init__(self, flight_number, flight_plan):
        self.x = flight_plan[0][0] # Initial x position from the first waypoint
        self.y = flight_plan[0][1] # Initial y position from the first waypoint
        # self.x = random.randint(0, screen_width)
        # self.y = random.randint(0, screen_height)
        # self.speed = random.uniform(1, 3)
        self.speed = random.uniform(0.01, 0.02)
        # self.direction = random.uniform(0, 2 * math.pi)
        self.flight_number = flight_number
        self.flight_plan = flight_plan # List of waypoints
    
    # def move(self):
    #     self.x += self.speed * 2 * math.cos(self.direction)
    #     self.y += self.speed * 2 * math.sin(self.direction)

    def move(self):
        if not self.flight_plan:
            return # No more waypoints in the flight plan
        # Calculate direction to the next waypoint
        target_x, target_y = self.flight_plan[0]
        angle_to_target = math.atan2(target_y - self.y, target_x - self.x)
        # Update the aircraft's position
        self.x += self.speed * 2 * math.cos(angle_to_target)
        self.y += self.speed * 2 * math.sin(angle_to_target)
        # Check if the aircraft has reached the current waypoint
        dist_to_target = math.sqrt((target_x - self.x) ** 2 + (target_y - self.y) ** 2)
        if dist_to_target < 5: # You can adjust the threshold
            # Remove the current waypoint from the flight plan
            self.flight_plan.pop(0)

# List to hold active aircrafts
active_aircrafts = []

# Internal data structure for flight numbers
flight_numbers = ['AA522', 'BA189', 'UA555', 'DL328', 'LH654', 'AA157', 'SW351']

# Create a list of waypoints
waypoints = [(100, 100), (200, 300), (500, 400), (700, 200)]

# Calculate the distance between two aircrafts
def distance(aircraft1, aircraft2):
    return math.sqrt((aircraft1.x - aircraft2.x) ** 2 + (aircraft1.y - aircraft2.y) ** 2)

# Main game loop
running = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
    # Generate new aircraft if needed
    if len(active_aircrafts) < 7:
        flight_plan = random.sample(waypoints, len(waypoints)) # Randomly shuffle the waypoints as a flight plan
        new_aircraft = Aircraft(random.choice(flight_numbers), flight_plan)
        active_aircrafts.append(new_aircraft)
    for aircraft in active_aircrafts:
        aircraft.move()
        # Check for collisions with other aircrafts
        for other_aircraft in active_aircrafts:
            if aircraft != other_aircraft:
                dist = distance(aircraft, other_aircraft)
                min_safe_distance = 40 # Adjust as needed
                if dist < min_safe_distance:
                    # Handle collision avoidance by changing direction
                    # For simplicity, we will give the aircraft a new random direction
                    aircraft.direction = random.uniform(0, 2 * math.pi)
                    other_aircraft.direction = random.uniform(0, 2 * math.pi)
        if aircraft.x < 0 or aircraft.x > screen_width or aircraft.y < 0 or aircraft.y > screen_height:
            active_aircrafts.remove(aircraft)
    # Draw aircraft and flight numbers
    screen.fill((0, 0, 0)) # Clear the screen
    for aircraft in active_aircrafts:
        pygame.draw.circle(screen, (0, 0, 255), (int(aircraft.x), int(aircraft.y)), 5) # Draw aircraft
        font = pygame.font.Font(None, 36)
        text = font.render(aircraft.flight_number, True, (255, 255, 255))
        screen.blit(text, (aircraft.x, aircraft.y - 20)) # Draw flight number above the aircraft
    pygame.display.update()

# Quit pygame
pygame.quit()