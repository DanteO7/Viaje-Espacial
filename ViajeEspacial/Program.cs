namespace ViajeEspacial
{
    public class Program
    {
        static void Main()
        {
            GestionMisiones.CargarDatos(GestionMisiones.ArchivoMisiones);
            Menu.MostrarMenu();
        }
    }
}
