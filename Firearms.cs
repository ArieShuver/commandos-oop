using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class Firearm : interfceWeapon
    {

        int Balls;
        public void NumBalls(int num)
        {
            Balls = num;    
        }
        public void Shot()
        {
            Balls--;
        }






    }
}
