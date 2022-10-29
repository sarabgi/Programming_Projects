from turtle import Turtle

class Scoreboard(Turtle):
    def __init__(self):
        super().__init__()
        self.total_r=0
        self.total_l=0
        self.penup()
        self.hideturtle()
        self.color("white")
        self.goto(0,250)

    def update(self):
        self.clear()
        self.write(f"{self.total_l}   {self.total_r}", align="center", font=("Courier", 26, "normal"))
