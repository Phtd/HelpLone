﻿using System;

namespace HelpLone
{                                                    // This is the Wizard class, and it has made contract with the interfaces it requires to use its abilities/skills
    public class Wizard: ICharacter, ITeleport, IThrowMagicMissile, IFrostNova
    {
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }


        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }

        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }

        public void ThrowMagicMissile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }
    }
}