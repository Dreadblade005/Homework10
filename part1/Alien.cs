using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    public class Alien
    {

       static public int health;
       static public String name;

        public Alien()
        {
            health = 0;
            name = "alien";
        }

        public Alien(int hp, String alienname)
        {

            health = hp;
            name = alienname;   
        }
        public string getAlienname()
        {
            return name;
        }
        public int getAlienHealth()
        {
            return health;
        }




    }
}