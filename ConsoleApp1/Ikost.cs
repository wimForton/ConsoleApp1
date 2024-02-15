using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Ikost
    {
        public bool Menselijk { get; }
        public decimal BerekenKostprijs();
    }
}
