namespace Solid.Models
{
    public abstract class Persona
    {
        public abstract string getname();
    }

    public class cliente : Persona
    {
        public override string getname()
        {
            return "cliente";

        }
    }

    public class administrador : Persona
    {
        public override string getname()
        {
            return "administrador";

        }
    }
}
