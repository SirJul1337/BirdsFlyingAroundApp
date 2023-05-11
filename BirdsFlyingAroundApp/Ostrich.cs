using BirdsFlyingAroundApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal class Ostrich : Bird, IRun
    {
        public string Run()
        {
            return $"{this.GetType().Name} Is running";
        }
    }
}
