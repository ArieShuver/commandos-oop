using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.models;

namespace Commandos
{
    public class m16 : Weapon, interfceWeapon 
    {
        public int Balls;
        public m16(string name, string maker) :base(name,maker)
        {

        }
       
        public void NumBalls(int num)
        {
            Balls = num;
        }
        public void Shot()
        {
            Balls--;
        }
        public void PrintShoot()
        {
            Console.WriteLine("BOOOM...");
        }
    }
}
