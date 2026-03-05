namespace Abstract_Factory
{
    public class GuiaImpresa : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guía impresa");
        }
    }

    public class ExamenEnPapel : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en papel");
        }
    }
}