using ExamenU3_AGGP.Clases;

namespace ExamenU3_AGGP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaEnlazada listaEnlazada = new ListaEnlazada();
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"Ingresa el nombre de la persona {i + 1}");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Ahora ingresa su edad de la persona {i + 1}");
                int edad = Convert.ToInt32(Console.ReadLine());
                Persona persona = new Persona();
                persona.Nombre = nombre;
                persona.Edad = edad;

                listaEnlazada.InsertarAlFinal(persona);
                i++;

            }
            listaEnlazada.ImprimirPersonas();


            Console.WriteLine("Ingresa el nombre de una persona que desees buscar en la lista");
            string name = Console.ReadLine();
         
      
            Persona personaxd = new Persona();
            personaxd.Nombre = name;
            listaEnlazada.BuscarPersona(personaxd);

        }
    }
}