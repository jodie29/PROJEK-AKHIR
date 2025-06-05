using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_AKHIR
{
    namespace PROJEK_AKHIR
    {
        public static class UserSession
        {
            public static string IdAdminLogin { get; set; }
            public static bool IsLoggedIn => !string.IsNullOrEmpty(IdAdminLogin);
        }
    }

}

