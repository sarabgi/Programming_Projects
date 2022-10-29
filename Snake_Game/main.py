from turtle import Turtle,Screen
from snake import Snake
from food import Food
from scoreboard import Scoreboard
import time

screen=Screen()
food=Food()
screen.setup(600,600)
screen.title("My Snake Game")
screen.bgcolor("black")
snake=Snake()

screen.tracer(0)
screen.listen()

screen.onkey(snake.up,key="Up")
screen.onkey(snake.down,key="Down")
screen.onkey(snake.right,key="Left")
screen.onkey(snake.left,key="Right")
game_on=True
food.create_food()
scoreboard=Scoreboard()
while game_on:
    screen.update()
    time.sleep(.2)
    snake.move()
    if snake.turtle_list[0].distance(food)<15:
        food.refresh()
        snake.increase_size()
        scoreboard.increase_score()
    if snake.turtle_list[0].xcor()>290 or snake.turtle_list[0].xcor()<-290 or snake.turtle_list[0].ycor()>290 or snake.turtle_list[0].ycor()<-290:
        game_on=False
        scoreboard.restart()
        scoreboard.game_over()

    for tail in snake.turtle_list[1:]:
        if snake.turtle_list[0].distance(tail) < 10 :
            game_on=False
            scoreboard.restart()
            scoreboard.game_over()
screen.exitonclick()
