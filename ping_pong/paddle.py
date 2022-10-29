from turtle import Turtle,Screen

class Paddle(Turtle):

    def __init__(self):
        super().__init__()

    def create_bars(self,position):
        self.penup()
        self.color("white")
        self.shape("square")
        self.shapesize(stretch_len=1, stretch_wid=6)
        self.goto(position)

    def down(self):
        y_cor=self.ycor()-30
        self.goto(self.xcor(),y_cor)

    def up(self):
        y_cor = self.ycor() + 30
        self.goto(self.xcor(), y_cor)


