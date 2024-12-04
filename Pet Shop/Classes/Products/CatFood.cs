using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Pet_Shop.Classes.Products
{
    [JsonConverter(typeof(BooleanConverter))]
    public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }
}
