using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public interface IDeveloper :IComparable<IDeveloper>
    {
       string Tool { get; set; }
        string Create();
        string Destroy();

    }
}
