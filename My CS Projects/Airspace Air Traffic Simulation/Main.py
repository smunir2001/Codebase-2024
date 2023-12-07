# Sami Munir
# December 7th, 2023
# My CS Projects
# Airspace Air Traffic Simulation

print('\nAirspace Air Traffic Simulation')
print('-------------------------------')

import pygame
import random
import math

# Variable to control maximum # of aircrafts generated in the airspace.
MAX_AIRCRAFTS = 5

# Initialize Pygame
pygame.init()

# Screen dimensions
SCREEN_WIDTH = 1200
SCREEN_HEIGHT = 800

# Create the screen
screen = pygame.display.set_mode((SCREEN_WIDTH, SCREEN_HEIGHT))
pygame.display.set_caption('Airspace Air Traffic Simulation')