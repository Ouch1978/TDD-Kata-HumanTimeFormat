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
            string time = string.Empty;

            if( seconds == 0 )
            {
                return "now";
            }

            TimeSpan timeSpan = TimeSpan.FromSeconds( seconds );

            if(timeSpan.Seconds > 0 )
            {
                time = $"{timeSpan.Seconds} second";

                time += ( timeSpan.Seconds > 1 ) ? "s" : string.Empty;
            }

            return time;
        }
    }
}
