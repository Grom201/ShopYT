namespace ShopYT.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesk { get; set; }
        public string longDesk { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool availebale { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
