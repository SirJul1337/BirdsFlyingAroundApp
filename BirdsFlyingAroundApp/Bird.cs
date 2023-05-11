namespace BirdsFlyingAroundApp;

public abstract class Bird
{

    public virtual string Draw()
    {
        return $"{this.GetType().Name} drawing";
    }
    public virtual string SetLocation(double longitude, double latitude)
    {
        return $"Location on {this.GetType().Name} |Logitude: {longitude}|Latitude: {latitude}";
    }
}
