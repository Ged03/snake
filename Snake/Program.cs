using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 25, '♥');
            Point food = foodCreator.CreateFood();
            food.Draw();

            int sleeptime = 100;
            while(true)
            {
                if(walls.isHit(snake)||snake.IsHitTail())
                {
                    break;
                }
                //Если нажата клавиша, сменить направление.
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                snake.Move();
                //Если змейка съела еду, создать новую
                if (snake.Eat(food))
                {
                    do
                    { food = foodCreator.CreateFood(); }
                    while (snake.IsHit(food));
                    food.Draw();
                    if(sleeptime>50)
                        sleeptime = sleeptime - 10;
                }
                //Задержка
                System.Threading.Thread.Sleep(sleeptime);
            }

            Console.SetCursorPosition(35, 12);
            Console.Write("Game Over!");
            Console.ReadLine();
        }
    }
}
