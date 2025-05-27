namespace Commandos.models
{
    public class AirCommando :Solider
    {   
        
        public AirCommando(string name, string codeName ):base(name,codeName) 
        {
            
        }

        public override void Attack()
        {
            Console.WriteLine("Airborne soldier attacks");
        }
        private string Falling = null;
        public void Parachuting()
        {
            Console.WriteLine("a solider is parachuting");
            Falling = "fell";
        }

    }
}
