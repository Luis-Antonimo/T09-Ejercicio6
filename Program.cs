using System;

namespace T09_Ejercicio6
{
    class Coche
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            coche1.setInfoCoche("Ford", "Mustang", 1000, 300);
            Console.WriteLine(coche1.getInfoCoche());
        }

        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        //Constructor vacío. Lo pongo aunque no hace falta -creo-.
        //El ejercicio hablaba de no necesitar un Main de prueba, no sé
        //si se refiere al Constructor.
        public Coche()
        {
        }

        public void setInfoCoche(string marcaNew, string modeloNew, int cilindradaNew, double potenciaNew)
        {
            marca = marcaNew;
            modelo = modeloNew;
            cilindrada = cilindradaNew;
            potencia = potenciaNew;
        }

        public string getInfoCoche()
        {
            return "\nMarca: " + marca + "\nModelo: " + modelo + "\nCilindrada: " + cilindrada + "\nPotencia: " + potencia;
        }
    }
}