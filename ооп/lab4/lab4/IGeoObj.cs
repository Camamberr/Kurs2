using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public interface IGeoObj
    {
        double square { get; set; }
        double altitude {  get;  set; }
        int UNESCOcount { get; set; }

    }
}
