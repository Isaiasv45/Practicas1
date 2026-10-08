using System.Security.Cryptography.X509Certificates;

namespace Practicas1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine(" Cual es tu nombre, saludos gracias por usar Isa calculator");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Hola bienvenido {nombre}");

            bool continuar = true;
            int numero1;
            int numero2;

            while (continuar)
            {
                Console.WriteLine("--Gracias por llegar hasta la calculadora de Isa, bienvenido--");
                Console.WriteLine("Opciones de la calculadora");
                Console.WriteLine(DateTime);

                Console.WriteLine("1.Suma");
                Console.WriteLine("2.Recta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Raiz cuadrada");
                Console.WriteLine("6, Masa Corporal");
                Console.WriteLine("7. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 7)
                {
                    continuar = false;
                    Console.WriteLine("Gracias por utilizar el programa");
                }



                switch (opcion)
                {
                    case 1:
                        sumametodo
                        Console.WriteLine("Que primero numero usaras");
                        double numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Que segundo numero usaras");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        break;

                    case 2:
                        restatodo;
                        Console.WriteLine("Que primero numero usaras");
                        double numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Que segundo numero usaras");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"El resultado seria {restatodo}");
                        break;
                    case 3:
                        multiplicatodo
                             Console.WriteLine("Que primero numero usaras");
                        double numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Que segundo numero usaras");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"El resultado seria {multiplicatodo}");
                        break;
                    case 4:
                        dividetodo
                        Console.WriteLine("Que primero numero usaras");
                        double numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Que segundo numero usaras");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"El resultado seria {dividetodo}");
                        break;




                }





            }
        public static double sumametodo(double numero1, double numero2)

        {
            return numero1 + numero2;
        }

    }   public static double restatodo(double numero1, double numero2)
            { 
            return numero1 - numero2; 
            }

        public static double multiplicatodo(double numero1, double numero2)
            { 
            return numero1 * numero2; 
            }
        public static double dividetodo(double numero1, double numero2)
            { 
            return numero1 / numero2;
            {
                if (numero1 < 0)
                    Console.WriteLine("El numero no se puede dividir por 0");
            }       return 0;
            }
}

