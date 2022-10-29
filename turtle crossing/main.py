import time
from turtle import Screen,Turtle
from player import Player
from car_manager import CarManager
from scoreboard import Scoreboard

screen = Screen()
screen.setup(width=600, height=600)
screen.tracer(0)
player=Player()
game_is_on = True
screen.listen()
car_manager = CarManager()
scoreboard=Scoreboard()
while game_is_on:
    car_manager.create_car()
    time.sleep(0.1)
    car_manager.move_all()
    for _ in car_manager.all_cars:
        if _.distance(player)<20:
            scoreboard.gameover()
            game_is_on=False
    screen.onkey(key="Up",fun=player.move_up)
    screen.onkey(key="Down",fun=player.move_down)

    if player.ycor()>=280:
        player.startOver()
        car_manager.increase_speed()
        scoreboard.level_inc()
    screen.update()
screen.exitonclick()
