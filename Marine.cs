using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.models
{
    public class Marine:Solider
    {
        public Marine(string name , string codName) : base(name, codName) 
        {

        }

        
        public void Pit()
        {
            Console.WriteLine("A solider swims");
        }

    
        
    }
}
