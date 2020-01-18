using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace face
{
    public static class Helpers
    {
        public static Regex MAIL_REGEX = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
        public static Regex MOBILE_PHONE_REGEX = new Regex(@"^\((5[0-9][0-9])\) ([0-9]{3})-([0-9]{4})$");

        
    }
}
