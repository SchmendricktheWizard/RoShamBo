using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Loader
    {
        //main class very important
        static void Main()
        {
            // this creates a new object from the class roshambo from the game file
            RoShamBo roShamBo = new RoShamBo();
          

            //just makes a forever loop so you can play the game until you close it
            while (true)
            {
                roShamBo.Play();
            }



        }
    }
}
