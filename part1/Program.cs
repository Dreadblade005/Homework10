using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeAlien alien1 = new SnakeAlien(50, 78, "Snake");
            Console.WriteLine(alien1.toString());
            OgreAlien alien2 = new OgreAlien(22, 99, "Ogre");
            Console.WriteLine(alien2.toString());   
            MarshmallowAlien alien3 = new MarshmallowAlien(44, 100, "Marshmallow Alien");
            Console.WriteLine(alien3.toString());
        }

    }
    }
