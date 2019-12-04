using System;

namespace Products.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemImage { get; set; }
        public double Price { get; set; }
        public DateTime Released_Date_Time { get; set; }
        public DateTime Expired_Date_Time { get; set; }
    }
}