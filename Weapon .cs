using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.models
{
    public class Weapon
    {
        private string NameWeapon { get; set; }
        private string Maker { get; set; }

        private int NumBalls { get; set; }

        public Weapon(string name , string maker ,int numBalss)
        {
            NameWeapon = name;
            Maker = "";
            NumBalls = 0;

        }
        public void Shoot()
        {
            Console.WriteLine("A shot was fired");
            NumBalls -= 1;
        }
    }
}
