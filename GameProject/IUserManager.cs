using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserManager
    {
        void Register(User user);
        void Update(User user);
        void Delete(User user);
    }
}
