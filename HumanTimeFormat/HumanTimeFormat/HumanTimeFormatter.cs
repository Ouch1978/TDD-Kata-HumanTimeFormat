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

            time += ParseTime( seconds / 31556926 , "year" );

            timeSpan = TimeSpan.FromSeconds( seconds % 31556926 );

            time += ParseTime( timeSpan.Days % 365 , "day" );

            time += ParseTime( timeSpan.Hours , "hour" );

            time += ParseTime( timeSpan.Minutes , "minute" );

            time += ParseTime( timeSpan.Seconds , "second" );

            return ReplaceComma( time );
        }


        private string ParseTime( int value , string unit )
        {
            string output = string.Empty;

            if( value > 0 )
            {
                output += $", {value} {unit}";

                output += ( value > 1 ) ? "s" : string.Empty;
            }

            return output;
        }

        private string ReplaceComma( string time )
        {
            if( time.StartsWith( "," ) == true )
            {
                time = time.Substring( 2 );
            }

            if( time.Count( s => s == ',' ) >= 1 )
            {
                time = time.Remove( time.LastIndexOf( ',' ) , 1 ).Insert( time.LastIndexOf( ',' ) , " and" );
            }

            return time;
        }
    }
}
