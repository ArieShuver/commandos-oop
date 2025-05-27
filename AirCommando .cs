namespace Commandos.models
{
    public class AirCommando :Solider
    {   
        
        public AirCommando(string name, string codeName ):base(name,codeName) 
        {
            
        }

        private string Falling = null;
        public void Parachuting()
        {
            Console.WriteLine("a solider is parachuting");
            Falling = "fell";
        }

    }
}
