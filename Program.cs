using System.Xml.Linq;
using Commandos.models;


namespace Commandos

{
    public class Program
    {
        static void Main(string[] args)
        {
            Solider[] arr = [
            new Solider("arie","s949496"),
            

            new AirCommando("dan","sd8484"),


            new Marine("moshe", "av555")];

            foreach (Solider s in arr)
            {
                s.Attack();
            }
        }
    }
}
