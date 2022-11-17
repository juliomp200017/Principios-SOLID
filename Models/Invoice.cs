namespace Solid.Models
{
    public class Invoice
    {
        public decimal Gettotal(IEnumerable<Juego> juego)
        {

            decimal total = 0;
            foreach(var Juego in juego)
            {
                total += Juego.getprice();
            }
            return total;
        }
    }
}
