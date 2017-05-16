namespace BestTime.Library
{
  public class UnitOfMeasure
  {
    public string Name { get; set; }
    public decimal DurationInHours { get; set; }
    public override string ToString()
    {
      return $"{Name} = {DurationInHours} hour(s)";
    }
  }
}
