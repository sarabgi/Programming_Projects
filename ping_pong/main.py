from turtle import Turtle,Screen
from paddle import Paddle
from ball import Ball
from scoreboard import Scoreboard
import time
screen=Screen()
tim=Turtle()
k=.1
is_ = True
scoreboard=Scoreboard()
screen.tracer(0)
screen.setup(900,600)
screen.bgcolor("black")
screen.title("PING PONG")
paddle_r=Paddle()
paddle_l=Paddle()
ball=Ball()
screen.listen()
paddle_r.create_bars((420,0))
paddle_l.create_bars((-420,0))
game_on=True
def resume():
    if ball.xcor() > 460:
        scoreboard.total_l += 1
    if ball.xcor() < -460:
        scoreboard.total_r += 1
    scoreboard.update()
    tim.clear()
    global k
    k = .1
    ball.refresh()


while game_on:
    scoreboard.update()
    time.sleep(k)
    screen.update()
    screen.onkey(fun=paddle_r.up,key="Up")
    screen.onkey(fun=paddle_l.up, key="w")
    screen.onkey(fun=paddle_r.down,key="Down")
    screen.onkey(fun=paddle_l.down, key="s")
    ball.move()
    if ball.ycor()>279 or ball.ycor()<-275:
        ball.bounce()
    if ball.xcor()>390 and ball.distance(paddle_r)<50 or ball.xcor()<-390 and ball.distance(paddle_l)<50:
        ball.bounce_pad()
        k/=1.2
    if ball.xcor()>460 or ball.xcor()<-460:
        tim.color("white")
        tim.hideturtle()
        tim.write("Press Space to Resume",align="center",font=("Algerian",30,"normal"))
        screen.onkey(fun=resume, key="space")

screen.exitonclick()
