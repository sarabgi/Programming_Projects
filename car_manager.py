from turtle import  Turtle
import random
COLORS = ["red", "orange", "yellow", "green", "blue", "purple"]
STARTING_MOVE_DISTANCE = 4
MOVE_INCREMENT = 5

class CarManager:
    def __init__(self):
        self.all_cars = []
        self.speed=STARTING_MOVE_DISTANCE
    def create_car(self):
        cool=random.randint(1,7)
        if cool==1:
            tim=Turtle()
            tim.penup()
            tim.shape("square")
            tim.shapesize(stretch_wid=1,stretch_len=2)
            tim.color(random.choice(COLORS))
            tim.goto(300,random.randint(-250,250))
            tim.setheading(180)
            self.all_cars.append(tim)

    def move_all(self):
        for _ in self.all_cars:
            _.forward(self.speed)
    def increase_speed(self):
        self.speed+=MOVE_INCREMENT