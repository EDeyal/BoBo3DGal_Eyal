using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool gameOn = true;
            while(gameOn)
            {
                gameOn = game.Run();
            }
            Console.ReadLine();
        }
    }
}
