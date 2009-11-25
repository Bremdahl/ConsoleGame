using System;
using System.Text;

namespace ConsoleGame
{
    public class GameInfo
    {
        public GameInfo(int areaHeight, int areaWidth, int startX, int startY)
        {
            Area = new Area(areaHeight, areaWidth);
            StartPosition = new Point(startX, startY);

            Start();
        }

        public Area Area { get; private set; }
        public Point StartPosition { get; private set; }
        public Point ActivePosition { get; private set; }
        public bool Play { get; private set; }

        public void Start()
        {
            Play = true;
            ActivePosition = StartPosition.Copy();
            RenderMap();
        }
        public void End() { Play = false; }
        public void Restart() { Start(); }


        public void Move(ConsoleKeyInfo keyInfo)
        {
            ActivePosition = MoveByKey(keyInfo);
            RenderMap();
        }

        private Point MoveByKey(ConsoleKeyInfo keyInfo)
        {
            var point = ActivePosition.Copy();
            switch (keyInfo.Key) //Göra om till classer med property Move? (interface)
            {
                case ConsoleKey.UpArrow: point.x--;
                    break;
                case ConsoleKey.DownArrow: point.x++;
                    break;
                case ConsoleKey.LeftArrow: point.y--;
                    break;
                case ConsoleKey.RightArrow: point.y++;
                    break;
                case ConsoleKey.Escape: End();
                    break;
                case ConsoleKey.Enter: Restart();
                    return ActivePosition;
                    break;
                default:
                    break;
            }

            return Area.IsInsideArea(point) ? point : ActivePosition;
        }

        public StringBuilder Map { get; private set; }
        private void RenderMap()
        {
            Map = new StringBuilder();
            
            for (int i = 0; i < Area.x; i++)
            {
                for (int j = 0; j < Area.y; j++)
                {
                    Map.Append(ActivePosition == new Point(i, j) ? "#" : ".");
                }

                Map.AppendLine();
            }
        }

    }
}
