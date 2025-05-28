using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.models
{
    public class Enemies
    {
        private string Name;
        private int Life;
        private string Status;
        
        public Enemies(string name)
        {
            Name = name;
            Life = 100;
            Status = "live";
        }
        static void Delcaration()
        {
            Console.WriteLine("i am an enemy");
        }
        public void ChangeStatus()
        {
            Status = "ded";
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }

}
