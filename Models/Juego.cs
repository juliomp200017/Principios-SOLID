namespace Solid.Models
{
    public interface Juego
    {   
        string Name { get; set; }
        public string Id { get; set; }

        public decimal Price { get; set; }

        public decimal Invoice { get; set; }

        public decimal getprice();
    }
    public interface Juegodatos
    {

        public decimal getInvoice();
        public string getId();
        public string getName();

    }
    public class Adventure : Juego,Juegodatos
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Invoice { get; set; }

        public decimal Price { get ; set; }

        public string getId()
        {
            return this.Id;
        }

        public decimal getInvoice()
        {
            return this.Invoice;
        }

        public string getName()
        {
            return this.Name;
        }

        public decimal getprice()
        {
            return Price * Invoice;
        }
    }

    public class Accion : Juego
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Invoice { get; set; }
        public decimal Price { get; set; }

        public decimal getprice()
        {
            return Price * Invoice;
        }
    }

}
