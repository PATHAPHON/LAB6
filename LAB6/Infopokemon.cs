using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    //internal class Pikachu entead Pokemon 4.7.8
    internal class Pikachu : Pokemon // 4.8
    {
        public Pikachu()
        {
            name = "pikachu";
            id = 001; level = 99;
            Type1 = pokemonType1.Electric;
        }
       

    }
    internal class Greninja : Pokemon
    {
        public Greninja()
        {
            name = "Greninja";
            id = 658; level = 34;
            Type1 = pokemonType1.Water;
            Type2 = pokemonType2.Dark;

        }
    }
    
    internal class Lugia : Pokemon
    {
        public Lugia()
        {
            name = "Lugia";
            id = 294; level= 55;
            Type1 = pokemonType1.Psychic;
            Type2 = pokemonType2.Flying;
        }
    }

    internal class Zoroark : Pokemon
    {
        public Zoroark()
        {
            name = "Zoroark";
            id = 571; level = 21;
            Type1 = pokemonType1.Dark;
        }
    }

    internal class Cinderace : Pokemon
    {
        public Cinderace()
        {
            name = "Cinderace";
            id = 815; level = 65; 
            Type1 = pokemonType1.Fire;
        }

    }
    internal class Eternatus : Pokemon
    {
        public Eternatus()
        {
            name = "Eternatus";
            id = 890; level = 80;
            Type1 = pokemonType1.Fairy;
            Type2 = pokemonType2.Dragon;
        }
    }

}
