namespace FoodLog.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
         
        public string Food { get; set; }
        
        public virtual List <AfterFeeling> AfterFeeling { get; set; }
        public string? Body { get; set; }
    }
}
