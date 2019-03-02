import time

import matplotlib
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd
import seaborn as sns


from beamngpy import BeamNGpy, Vehicle, Scenario
from beamngpy.sensors import Camera, GForces, Lidar, Electrics, Damage

sns.set()

# Instantiate a BeamNGpy instance the other classes use for reference & communication

# This is the host & port used to communicate over
beamng = BeamNGpy('localhost', 64294)

#loads Custom Map
scenario = Scenario('Mytest', 'demo')

#adding ego Vehicle to the scenario
vehicle = Vehicle('ego_vehicle', model='etk800',licence='RED', color='Green')
electrics = Electrics()
vehicle.attach_sensor('electrics', electrics)
damage1 = Damage()
vehicle.attach_sensor('damage1', damage1)
scenario.add_vehicle(vehicle, pos=(104.647,-1.92827,-3.54338),rot=(0,0,90))

#add vehicle as Obstacle
vehicle1 = Vehicle('test_vehicle', model='etk800',licence='RED', color='Blue')
scenario.add_vehicle(vehicle1,pos=(-9.66595, -90.7465,-3.45737),rot=(0,0,180))
scenario.make(beamng)


bng = beamng.open()
bng.load_scenario(scenario)

#set the ego vehicle to AI mode
vehicle.ai_set_mode('Manual')
vehicle.ai_set_waypoint('DecalRoad5248_4')
vehicle1.control(throttle=0.44)
bng.start_scenario()

# After loading, the simulator waits for further input to actually start



positions = list()
directions = list()
wheel_speeds = list()
speed = list()
brakes = list()
damage1 = list()
vehicle.update_vehicle()
sensors = bng.poll_sensors(vehicle)
print('The vehicle position is:')
print(vehicle.state['pos'])

print('The vehicle direction is:')
print(vehicle.state['dir'])

print('The wheel speed is:')
print(sensors['electrics']['values']['wheelspeed'])

print('The throttle intensity is:')
print(sensors['electrics']['values']['throttle'])

print('The brake intensity is:')
print(sensors['electrics']['values']['brake'])
print('The damage intensity is:')
print(sensors['damage1']['damage'])

#Query the Sensors for every 120 seconds
for _ in range(240):
    time.sleep(0.1)
    vehicle.update_vehicle()  # Synchs the vehicle's "state" variable with the simulator
    sensors = bng.poll_sensors(vehicle)  # Polls the data of all sensors attached to the vehicle
    positions.append(vehicle.state['pos'])
    directions.append(vehicle.state['dir'])
    wheel_speeds.append(sensors['electrics']['values']['wheelspeed'])
   # speed.append(sensors['electrics']['values']['speed'])
    brakes.append(sensors['electrics']['values']['brake'])
    print("pos",vehicle.state['pos'],"n","Damage [",sensors['damage1']['damage'],"]","n","brake",sensors['electrics']['values']['brake'],"n","Wheelspeed",sensors['electrics']['values']['wheelspeed'],"n","Throttle",sensors['electrics']['values']['throttle'])

bng.close()