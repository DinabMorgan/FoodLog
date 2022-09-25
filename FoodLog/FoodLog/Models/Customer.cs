namespace FoodLog.Models
{
    public class Customer
    {
        public int Id { get; set; } 
        public string AccountID { get; set; }
        public virtual Account Account { get; set; }
        public virtual List <Entry> Entries { get; set; }
    }
}
