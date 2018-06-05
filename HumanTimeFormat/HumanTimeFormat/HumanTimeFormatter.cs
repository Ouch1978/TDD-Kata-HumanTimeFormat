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
            if( value > 0 )
            {
                return ( value > 1 ) ? $", {value} {unit}s" : $", {value} {unit}";
            }

            return string.Empty;
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
