using System;

namespace ConsoleGame
{
    namespace ConsoleGame
    {
        class Program
        {
            static void Main(string[] args)
            {
                var GameInfo = new GameInfo(5, 25, 0, 0);
                Console.Write(GameInfo.Map);
                while (GameInfo.Play)
                {
                    GameInfo.Move(Console.ReadKey());
                    
                    Console.Clear();
                    Console.Write(GameInfo.Map);
                }
            }
        }
    }
}
