using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.abstracts
{
    public abstract class AUser
    {
        const string Users = "Select * From TBL_USERS";
        public static string USERS { get { return Users; } }

    }
}
