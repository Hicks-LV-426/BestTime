namespace BestTime.Library
{
    using System;
    using System.Linq;

    public class Activity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FullName => String.IsNullOrWhiteSpace(Description) ? Name : $"{Name}: {Description}";
        public Activity[] Activities { get; set; }
        public override string ToString()
        {
            if(Activities.Length > 0)
                return $"{FullName}\r\n\t{String.Join("\r\n\t", Activities.Select(a => a.ToString()))}";
            else
                return FullName;
        }
    }
}
