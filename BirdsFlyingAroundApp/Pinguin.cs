using BirdsFlyingAroundApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal class Pinguin : Bird, ISwim
    {
        public override string Draw()
        {
            return $"Draw override of virtual {this.GetType().Name}";
        }

        public string Swim()
        {
            return $"{this.GetType().Name} is swimming";
        }
    }
}
