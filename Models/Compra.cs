namespace Solid.Models
{
    public class Compra
    {
        private ICollection<Mensaje> mensajes;

        public Compra(ICollection<Mensaje> mensaj)
        {
            this.mensajes = mensaj;
        }
        public void Send()
        {
            foreach (var m in mensajes)
            {
                m.SendMessage();
            }
        }
}
    }
