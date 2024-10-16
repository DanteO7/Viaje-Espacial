namespace ViajeEspacial.Modelos
{
    public static class GestionMisiones
    {
        static List<Mision> Misiones = new();
        public readonly static string ArchivoMisiones = "misiones.txt";

        public static void AgregarMision(Mision mision)
        {
            Misiones.add(mision);
            Console.WriteLine($"Mision '{mision.Nombre}' agregada");
        }

        public static void EliminarMision(string nombre)
        {
            var mision = Misiones.Find(m => m.Name == nombre);

            if (mision == null)
            {
                Console.WriteLine($"Mision '{nombre}' no encontrada");
                return;
            }

            Misiones.Remove(mision);
            Console.WriteLine($"Mision '{nombre}' eliminada");
        }

        public static void ModificarMision(string nombre, Mision nuevaMision)
        {
            var mision = Misiones.Find(m => m.Name == nombre);

            if(mision == null)
            {
                Console.WriteLine($"Mision '{nombre}' no encontrada");
                return;
            }

            Misiones.Remove(mision);
            Misiones.Add(nuevaMision);
            Console.WriteLine($"Misión '{nombre}' modificada");
        }

        public static void MostrarMisiones()
        {
            if(Misiones.Count == 0)
            {
                Console.WriteLine("No hay misiones");
                return;
            }

            Console.WriteLine("Lista de misiones:");
            foreach(var mision in Misiones)
            {
                Console.WriteLine(mision);
            }
        }

        public static void GuardarDatos()
        {

        }

        public static void CargarDatos()
        {

        }
    }
}
