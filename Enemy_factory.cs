using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Commandos.models
{
    static class Enemy_factory
    {
    static List<Enemies> Listenemies = new List<Enemies>();

      
        static public void Factory(string name)
        {
            Listenemies.Add(new Enemies(name));
        }
       
        
    
    }
}