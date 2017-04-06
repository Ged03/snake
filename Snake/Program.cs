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

            //Отрисовка рамки
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine RightLine = new VerticalLine(78, 0, 24, '+');
            UpLine.DrawLine();
            DownLine.DrawLine();
            LeftLine.DrawLine();
            RightLine.DrawLine();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 25, '♥');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
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
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                //Задержка
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
