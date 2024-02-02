using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    public class Pokemon
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
      
        protected pokemonType1 Type1;  // ประกาดเรียกใช้ enum
        protected pokemonType2 Type2;  // ประกาดเรียกใช้ enum
        protected pokemonAbilities abilities; // ประกาดเรียกใช้ enum

        //status 
        protected int Hp , Att , Def , S_Att , S_Def , Spped;

        // การเรียกใช้ name pokemon ออกไปใน แบบpublic
        public string Outputname() { return name; }

        // เช่นกัน
        public Image Pic() { return pic; }
    }
  
    public enum pokemonType1
    {
        Grass, Poison , Electric, Psychic, Dark , Steel , Ice , Fairy , Dragon , Fighting , Bug , Normal , Fire , Water , Flying ,  Ground , Rock
    }

    public enum pokemonType2
    {
        Grass, Poison, Electric, Psychic, Dark, Steel, Ice, Fairy, Dragon, Fighting, Bug, Normal, Fire, Water, Flying, Ground, Rock
    }

    public enum pokemonAbilities
    {
        Overfrow , ChlorophyII
    }
    
}
