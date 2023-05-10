using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxTestNetApp.Model.Abstractions.Types
{
    public class RegistrationUser
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Login { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
