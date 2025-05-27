using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commandos.models
{
    public class Solider
    {
        private string Name;
        private string CodeName {  get; set; }
        private string[] Tools = new string[5];
        public string Status;

        public Solider(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Tools = ["hammer", "chisel", "rope", "bag", "water bottle"];
            Status = null;


        }
        public void Walk()
        {
            Console.WriteLine("the solider is leaving");
            Status = "walk";
        }
        public void Hide()
        {
            Console.WriteLine("th solider is will hide");
            Status = "hide";
        }
        public virtual void Attack()
        {
            Console.WriteLine(Name +" "+"Commando soldier attacks");
        }
        public void SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                Console.WriteLine(Name);
            }
            else if (commanderRank == "COLONEL")
            {
                Console.WriteLine(CodeName);
            }
            else
            {
                Console.WriteLine("You do not have access");
            }
        }   
    }
}
