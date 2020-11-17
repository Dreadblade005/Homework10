using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    public class MarshmallowAlien : Alien
    {
        private int damage = 1;
        private int number;
        public MarshmallowAlien(int number, int newhealth, string newname) : base(health, name)
        {
            health = newhealth;
            name = newname;
            this.number = number;
        }


        int getDamage()
        {
            return damage;
        }

        int calculateDamage()
        {
            return getDamage() * number;


        }

        public String toString()
        {
            return ("The Alien " + name + " with Health " + health + " caused Damage " + calculateDamage());
        }
    }
}
