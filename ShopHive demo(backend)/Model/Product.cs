namespace ShopHive_demo_backend_.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string? review_rating { get; set; }
        public string price { get; set;}
        public string url { get; set; }
    }
}
