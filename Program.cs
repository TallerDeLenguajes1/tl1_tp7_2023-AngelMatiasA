// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public void UsarCalc()
        {



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Calculadora cal = new Calculadora();
            cal.suma(15);
            Console.WriteLine(cal.Resultado);
            cal.resta(52);
            Console.WriteLine(cal.Resultado);

            int opcion = 0;
            Calculadora calc1;

            double num;
            bool valido = true;
            string entrada;

            calc1 = new Calculadora();
           

                do
                {


                    Console.WriteLine("ingrese la operacion a realizar 1-suma\n 2-resta\n 3-multiplicacion\n 4-division\n \"c\" limpiar o  \"x\" para salir");
                    entrada = Console.ReadLine(); 
                    
                    if (entrada == "x")
                    {
                        valido = false;

                    }
                    else if (entrada == "c")
                    {
                        calc1.Limpiar();

                    }
                    else
                    {
                        int.TryParse(entrada, out opcion);

                        do
                        {
                            Console.WriteLine("ingrese el  numero ");
                            entrada = Console.ReadLine();
                        } while (!double.TryParse(entrada, out num));

                        switch (opcion)
                        {
                            case 1:

                                Console.Write(" El resultado de la suma es ");
                                calc1.suma(num);
                                Console.WriteLine(calc1.Resultado);
                                break;
                            case 2:

                                Console.Write(" El resultado de la suma es ");
                                calc1.resta(num);
                                Console.WriteLine(calc1.Resultado);
                                break;

                            case 3:

                                Console.Write(" El resultado de la multiplicacion es ");
                                calc1.multiplicacion(num);
                                Console.WriteLine(calc1.Resultado);
                                break;

                            case 4:

                                Console.Write(" El resultado de la division es ");
                                calc1.dividir(num);
                                Console.WriteLine(calc1.Resultado);
                                break;
                            default:
                                valido = false;
                                break;
                        }



                        if (!valido)
                        {
                            Console.WriteLine(" la operacion elegida no es correcta");
                            Console.WriteLine("intente nuevamente"); 
                            valido = true;
                        }

                    }

                } while (valido);



          
        }

    }
}
