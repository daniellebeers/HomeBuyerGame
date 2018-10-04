using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuyer
{
    class Agent
    {
        public string Name { get; set; }
        public int Credibility { get; set; }
        public bool IsCredible { get; set; }
        public int TourPower { get; internal set; }
        public int PassDamage { get; internal set; }
    }
}
