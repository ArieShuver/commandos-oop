using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.models;

namespace Commandos
{
    public class WeaponFactory
    {
        static List<Weapon> ArrWeapon = new List<Weapon>();


        static void factory(string name,string maker , int numBalss)
        {
            ArrWeapon.Add(new Weapon(name ,maker,numBalss));
        }
        

    }

}
