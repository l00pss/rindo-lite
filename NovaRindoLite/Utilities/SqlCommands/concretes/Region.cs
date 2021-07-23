using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaRindoLite.Utilities.SqlCommands.concretes
{
    class Region:abstracts.ARegion
    {
        const string Regions = "Select * From TBL_REGIONS";
        public static string REGIONS { get { return Regions; } }
    }
}
