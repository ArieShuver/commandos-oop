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
        public void Delcaration()
        {
            Console.WriteLine("i am an enemy");
        }
    }
}
