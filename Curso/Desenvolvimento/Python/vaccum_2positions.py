import time
import random as rnd
from colorama import Fore

# global variables
dirty = 'D'
clean = ' '
width = 0
height = 0

def create_world(w=2,h=1,alpha=0.5):
    return [[clean if rnd.random() > alpha else dirty for _ in range(w)] for _ in range(h)]

# the fuckin' world
world = create_world(alpha=1)

# agent representation
vaccum_location = {'x': 0, 'y': 0}
vaccum = {'action': 'NoOp'}

# agent actions
def goSuck():
    world[vaccum_location['y']][vaccum_location['x']] = clean

def goRight():
    x = len(world[0])
    vaccum_location['x'] = vaccum_location['x'] + 1 if vaccum_location['x'] < x - 1 else vaccum_location['x']

def goLeft():
    vaccum_location['x'] = vaccum_location['x'] - 1 if vaccum_location['x'] > 0 else vaccum_location['x']

def NoOp():
    pass

vaccum_actions = {'Suck': goSuck, 'Right': goRight, 'Left': goLeft, 'NoOp': NoOp}

def agent_function(perception):
    if perception['status'] == dirty:
        return 'Suck'
    elif perception['location']['x'] == 0:
        return 'Right'
    return 'Left'

def percept():
    return {'location': vaccum_location, 
    'status': world[vaccum_location['y']][vaccum_location['x']]}

def act(action):
    vaccum['action'] = action
    vaccum_actions[action]()

def show_word():
    print(Fore.WHITE + "\nThat's the world ....")
    for r,row in enumerate(world):
        for c,col in enumerate(row):
            if vaccum_location['x'] == c and vaccum_location['y'] == r:
                print(Fore.BLUE + '[' + col + ']' + vaccum['action'],end=' ')
            else:
                print(Fore.WHITE + '[' + col + ']\t',end='')
        print('\n')

def evolves_environment():
    while True:
        show_word()
        perception = percept()
        action = agent_function(perception)
        act(action)
        time.sleep(2)

evolves_environment()