FONT = ("Courier", 20, "bold")
from turtle import Turtle

class Scoreboard(Turtle):
    def __init__(self):
        super().__init__()

        self.level=1
        self.color("black")
        self.hideturtle()
        self.penup()
        self.goto(-280,260)
        self.update()
    def update(self):
        self.write(f"LEVEL={self.level}", align="left", font=FONT)
    def level_inc(self):
        self.level+=1
        self.clear()
        self.update()
    def gameover(self):
        self.goto(0,0)
        self.write(f"Game Over", align="center", font=FONT)