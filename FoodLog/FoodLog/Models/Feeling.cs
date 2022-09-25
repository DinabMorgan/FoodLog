namespace FoodLog.Models
{
    public class Feeling
    {
        public int Id { get; set; }
        public int EntryId { get; set; }
        public virtual Entry Entry { get; set; } 
        public int Rating { get; set; }
        public AfterFeeling AfterFeeling { get; set; }


    }
    public enum AfterFeeling
    {
        Great,
        Okay,
        Sick

    }
}
