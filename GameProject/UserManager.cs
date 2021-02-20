using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserManager:IUserManager
    {
        public void Register(User user)
        {
            Console.WriteLine("You were registered " +user.Name + " " + " Good Luck & Have Fun!" );
        }
        public void Update(User user)
        {
            Console.WriteLine("Your account has been updated " + user.Name + " Keep playing! " );
        }
        public void Delete(User user)
        {
            Console.WriteLine(user.Name + user.Surname + "Your account has been deleted! We will miss you :(");
        }
    }
}
