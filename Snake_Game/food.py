from turtle import Turtle
from random import Random
class Food(Turtle):

    def __int__(self):
        super().__int__()

    def create_food(self):
        self.shape("turtle")
        self.color("purple")

        self.penup()
        self.shapesize(stretch_len=0.5,stretch_wid=0.5)
        self.refresh()

    def refresh(self):
        random = Random()
        self.goto(random.randint(-290, 290), random.randint(-290, 250))
