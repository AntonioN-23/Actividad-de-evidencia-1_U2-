namespace Abstract_Factory
{
    public class GuiaHibrida : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guía en modalidad híbrida");
        }
    }

    public class ExamenMixto : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen mixto");
        }
    }
}