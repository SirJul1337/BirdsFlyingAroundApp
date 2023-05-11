using BirdsFlyingAroundApp.Interface;

namespace BirdsFlyingAroundApp;

internal class CanaryBird : Bird, IFly
{
    public CanaryBird()
    {
        
    }
    public override string Draw()
    {
        return $"Draw override of virtual {this.GetType().Name}";
    }
    public string SetAltitude(double altitude)
    {
        return $"Altitude on {this.GetType().Name} set to {altitude}, its now flying";
    }
}
