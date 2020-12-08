using SQLite;

namespace People.Models
{
    [Table("people")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string TShirt_Size { get; set; }
        public string DateOfOrder { get; set; }
        public string TShirt_Color { get; set; }
        public string ShippingAddress { get; set; }
    }
}
