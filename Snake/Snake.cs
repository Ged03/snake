using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
            //throw new NotImplementedException();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
            }
        }
        internal bool Eat (Point food)
        {
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i=0;i<pList.Count-2;i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        /*
        public bool intersection (Point cross)
        {
            bool rez;
            foreach(Point sp in pList)
            {
                if(sp.IsHit(cross))
                {
                    rez = true;
                }
                return rez;
            }
        }
        */
    }
}
