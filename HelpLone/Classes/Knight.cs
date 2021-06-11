using System;

namespace HelpLone
{                                                     // Knight class, has made contracts with the interfaces it requires to function
    public class Knight: ICharacter, IShieldSkills, ISlash, IBash, ICleave
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

        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }


        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }

        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }

    }
}