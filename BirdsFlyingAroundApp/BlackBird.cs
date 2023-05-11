using BirdsFlyingAroundApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal class BlackBird : Bird, IFly
    {
    
        public string SetAltitude(double altitude)
        {
            return $"Altitude on {this.GetType().Name} set to {altitude}, its now flying";
        }
    }
}
