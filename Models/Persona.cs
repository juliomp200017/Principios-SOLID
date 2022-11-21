namespace Solid.Models
{
    public abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected int edad;
        public abstract string getname();
    }

    public abstract class PersonaConAdministracion : Persona
    {
        protected string Correo;
        public abstract string getcorreo();
    }

    public class cliente : Persona
    {   
        public cliente(int id, string nombre,int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }
        public override string getname()
        {
            return "cliente";

        }
    }

    public class administrador : PersonaConAdministracion
    {
        public administrador(int id, string nombre, int edad,string correo)
        {
            this.Correo = correo;
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }                                                                               
        public override string getname()
        {
            return "administrador";

        }

        public override string getcorreo()
        {
             return this.Correo;
        }
    }
}
