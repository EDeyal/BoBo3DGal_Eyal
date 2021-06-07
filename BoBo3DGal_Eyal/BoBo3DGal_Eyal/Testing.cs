using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    class Testing
    {
        static void Main(string[] args)
        {
            GameObject player = new GameObject("player", new Transform(new Vector3(0,0,0)));
            player.GetSetGameObjects.Add(new GameObject("Player hand", new Transform(new Vector3(0,0,0))));
            player.GetSetGameObjects[0].GetSetGameObjects.Add(new GameObject("Player Finger", new Transform(new Vector3(0, 0, 0))));
        }
    }
}
