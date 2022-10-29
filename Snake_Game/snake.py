from turtle import Turtle
from food import Food

class Snake:

    def __init__(self):
        self.turtle_list = []
        self.x = 0
        self.extend((0, 0))
        self.create_snake()


    def create_snake(self):
        for _ in range(0, 2):
            self.extend(self.turtle_list[-1].position())
    def extend(self,position):
        tim = Turtle()
        tim.penup()
        tim.setpos(position)
        self.x -= 20
        tim.color("white")
        tim.shape("square")
        self.turtle_list.append(tim)
    def increase_size(self):
        self.extend(self.turtle_list[-1].position())
    def move(self):
        for seg_each in range(len(self.turtle_list) - 1, 0, -1):
            self.turtle_list[seg_each].goto(self.turtle_list[seg_each - 1].position())
        self.turtle_list[0].forward(20)
    def reset(self):
        for _ in self.turtle_list:
            _.color("black")
        self.turtle_list.clear()
        self.extend((0, 0))
        self.create_snake()
    def up(self):
        if self.turtle_list[0].heading()!=270:
            self.turtle_list[0].setheading(90)
    def down(self):
        if self.turtle_list[0].heading()!=90:
            self.turtle_list[0].setheading(270)
    def left(self):
        if self.turtle_list[0].heading()!=180:
            self.turtle_list[0].setheading(0)
    def right(self):
        if self.turtle_list[0].heading()!=0:
            self.turtle_list[0].setheading(180)