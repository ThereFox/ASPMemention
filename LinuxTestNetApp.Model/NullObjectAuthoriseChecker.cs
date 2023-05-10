using LinuxTestNetApp.Model.Abstractions;
using LinuxTestNetApp.Model.Abstractions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxTestNetApp.Model
{
    public class NullObjectAuthoriseChecker : IAuthoriseChecker
    {
        public bool IsAuthorised(AuthorisationUser user)
        {
            if(user == null)
            {
                throw new ArgumentNullException();
            }
            return true;


        }
    }
}
