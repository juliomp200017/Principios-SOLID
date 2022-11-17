namespace Solid.Models
{
    public interface Juego
    {
        public string Id { get; set; }

        public decimal Price { get; set; }

        public decimal Invoice { get; set; }

        public decimal getprice();
    }
    public interface Adventure : Juego
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Invoice { get; set; }
        public decimal getprice()
        {
            return Price * Invoice;
        }
    }

}
