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

            if( timeSpan.Days > 0 )
            {
                time += $", {timeSpan.Days} day";

                time += ( timeSpan.Days > 1 ) ? "s" : string.Empty;
            }

            if( timeSpan.Minutes > 0 )
            {
                time += $", {timeSpan.Minutes} minute";

                time += ( timeSpan.Minutes > 1 ) ? "s" : string.Empty;
            }

            if( timeSpan.Seconds > 0 )
            {
                time += $", {timeSpan.Seconds} second";

                time += ( timeSpan.Seconds > 1 ) ? "s" : string.Empty;
            }

            return ReplaceComma( time );
        }

        private string ReplaceComma( string time )
        {
            if( time.StartsWith( "," ) == true )
            {
                time = time.Substring( 2 );
            }

            if( time.Count( s => s == ',' ) >= 1 )
            {
                time = time.Remove( time.LastIndexOf( ',' ) , 1 ).Insert( time.LastIndexOf( ',' ) , "and" );
            }

            return time;
        }
    }
}
