using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTimeFormat
{
    public class HumanTimeFormatter
    {
        public HumanTimeFormatter()
        {

        }

        public string Format( int seconds )
        {
            if( seconds == 0 )
            {
                return "now";
            }

            return string.Empty;
        }
    }
}
