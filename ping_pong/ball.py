from turtle import Turtle

class Ball(Turtle):
    def __init__(self):
        super().__init__()
        self.xmove = 10
        self.ymove = 10
        self.penup()
        self.shape("circle")
        self.color("white")


    def move(self):
        new_x=self.xcor()+self.xmove
        new_y = self.ycor() + self.ymove
        self.goto(new_x,new_y)

    def bounce(self):
        self.ymove *= -1

    def bounce_pad(self):
        self.xmove *= -1
    def refresh(self):
        self.goto(0,0)
        self.xmove *=-1
        self.ymove *=-1

