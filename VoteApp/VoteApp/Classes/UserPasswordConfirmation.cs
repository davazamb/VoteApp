using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteApp.Classes
{
    public class UserPasswordConfirmation : User
    {
        public string password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}
