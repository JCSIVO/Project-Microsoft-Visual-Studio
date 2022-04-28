namespace Actividad8._7
{
    public partial class Persona
    {
        string nombre;
        string apellidos;
        string telefono;
        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.telefono = "";
        }
        public Persona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = "";
        }
        public Persona(string nombre, string apellidos, string telefono)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            } 
            set   
            {
                apellidos = value;
            }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
        public string ToString()
        {
            string cadena = "";
            cadena = apellidos + "," + nombre;
            return cadena;
        }

    }
}