namespace BestTime.Library
{
    public class ToDoItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Estimate Estimate { get; set; }
        public Priority Priority { get; set; }
        public int Deadline { get; set; }
    }
}
