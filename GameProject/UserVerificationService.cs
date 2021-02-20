using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserVerificationService:IUserVerificationService
    {
        public void Verificate(User user)
        {
            if (user.Name == "Amy" && user.Surname == "Smith" && user.IDNumber =="1111111111" && user.YearofBirth==2000)
            {
                Console.WriteLine("Welcome Amy!");
            }
                else
                {
                Console.WriteLine("We can not find you in our users :( Who are you o.O ??");
                }
            if (user.Name == "Jack" && user.Surname == "Wilson" && user.IDNumber == "2222222222" && user.YearofBirth == 1998)
            {
                Console.WriteLine("Welcome Jack!");
            }
                else
                {
                Console.WriteLine("We can not find you in our users :( Who are you o.O ??");
                }
        }
    }
}
