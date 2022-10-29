from turtle import Turtle

class Scoreboard(Turtle):
    def __init__(self):
        super().__init__()
        with open("data.txt") as file:
            self.highest_score=int(file.read())
        self.total=0
        self.color("white")
        self.penup()
        self.goto(0,260)
        self.hideturtle()
        self.update_score()
    def update_score(self):
        self.clear()
        self.write(f"SCORE = {self.total}  HIGH SCORE = {self.highest_score}", align="center", font=("Courier", 14, "normal"))
    def game_over(self):
        self.goto(0,0)
        self.color("yellow")
        self.write("Game Over",align='center',font=("Courier", 14, "normal"))
    def increase_score(self):
        self.total+=1
        self.update_score()

    def restart(self):
        if self.total>self.highest_score:
            self.highest_score=self.total
            with open("data.txt",mode="w") as file:
                file.write(f"{self.total}")
        self.total=0
        self.update_score()
