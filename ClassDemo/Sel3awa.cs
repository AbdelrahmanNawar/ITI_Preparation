using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public sealed class Sel3awa : Animal
    {
        public Sel3awa(int id, string name, int killCount) : base (id, name)
        {
            KillCount = killCount;
        }

        public int KillCount { get; set; }

        public override string ConvertObjectToString()
        {
            return "This is sel3awa";
        }
    }
}
