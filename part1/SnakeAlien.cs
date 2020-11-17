using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    public class SnakeAlien : Alien
    {
        private int damage = 10;
        private int number;
        public SnakeAlien(int number, int newhealth, string newname) : base(health, name)
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