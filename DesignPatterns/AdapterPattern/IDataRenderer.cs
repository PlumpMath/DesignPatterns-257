using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    interface IDataRenderer
    {
        string ListPatterns(IEnumerable<Pattern> patterns); 
    }
}
