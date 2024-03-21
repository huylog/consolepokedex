using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__Pokémon
{
    internal class PokeResponse
    {
        //class that matches API response data
        public int id { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        

        //Method to easily display the needed data.
        public void Display()
        {
            Console.WriteLine($"{name}\nId: {id}\nHow Fat: {weight}");
        }
    }
}
