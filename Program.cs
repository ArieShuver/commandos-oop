using System.Xml.Linq;
using Commandos.models;


namespace Commandos

{
    public class Program
    {
        static void Main(string[] args)
        {
            Solider s1 = new Solider("arie","ss");
            s1.SayName("GENERAL");
        }
    }
}
