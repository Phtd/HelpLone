using System;

namespace HelpLone
{                                                        // Witch class, has made a contract with the required interfaces to use its abilities/skills
    public class Witch: ICharacter, IShieldSkills, ITeleport
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


        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }

        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
    }
}