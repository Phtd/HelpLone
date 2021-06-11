using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{                                             // Character interface. Contains the standard methods all characters need 
    public interface ICharacter
    {
        void Heal();
        void Die();
        void Fight();

    }
}
