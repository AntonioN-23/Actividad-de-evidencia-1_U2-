namespace Abstract_Factory
{
    public class GuiaPDF : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guía PDF");
        }
    }

    public class ExamenOnline : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en línea");
        }
    }
}