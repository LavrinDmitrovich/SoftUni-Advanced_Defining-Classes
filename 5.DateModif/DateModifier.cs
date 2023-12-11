using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int Diff (string stat, string end) 
        

            
        { 
            
            DateTime statD = DateTime.Parse (stat);
            DateTime endD = DateTime.Parse (end);

            var diff = statD - endD;

            return Math.Abs(diff.Days); 
        
        }
    }
}
