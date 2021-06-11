using System;

namespace HelpLone
{
    public class Barbarian: ICharacter, ICleave, IBash, ISlash
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
    }
}