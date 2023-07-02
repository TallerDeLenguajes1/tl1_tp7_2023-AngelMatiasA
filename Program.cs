// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using System;
using EspacioEmpresa;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public void UsarCalc()
        {



        }
        /*
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
*/

        
     static void Main(string[] args)
        {

                   Empleado []empleados = new Empleado[3];



        empleados[0] = new Empleado();
        empleados[0].Apellido = "Jonas";
        empleados[0].Nombre1 = "pedro";
        empleados[0].FechaNac = new DateTime(1987, 6, 8);
        empleados[0].EstadoCivil = 'c';
        empleados[0].Genero = 'm';
        empleados[0].FechaIngreso = new DateTime(2010, 9, 4);
        empleados[0].SueldoBasico = 91000;
        empleados[0].Cargo = Cargo.Ingeniero;

        empleados[1] = new Empleado();
        empleados[1].Apellido = "Perez";
        empleados[1].Nombre1 = "Andrea";
        empleados[1].FechaNac = new DateTime(1994, 7, 2);
        empleados[1].EstadoCivil = 'c';
        empleados[1].Genero = 'f';
        empleados[1].FechaIngreso = new DateTime(2016, 9, 4);
        empleados[1].SueldoBasico = 81000;
        empleados[1].Cargo = Cargo.Especialista;
    
        empleados[2] = new Empleado();
        empleados[2].Apellido = "Lucero";
        empleados[2].Nombre1 = "Sofia Gerundia";
        empleados[2].FechaNac = new DateTime(1983, 7, 1);
        empleados[2].EstadoCivil = 's';
        empleados[2].Genero = 'f';
        empleados[2].FechaIngreso = new DateTime(2002,7 , 3);
        empleados[2].SueldoBasico = 91000;
        empleados[2].Cargo = Cargo.Ingeniero;

        double montoTotal = 0; 
       
        

        foreach (var empleado in empleados)
        {
            int edad = empleado.antiguedad(empleado.FechaNac);
            int antiguedad = empleado.aniosParaJub(edad, empleado.Genero);
           montoTotal +=  empleado.calcularSalario(antiguedad, empleado.Cargo, empleado.EstadoCivil, empleado.SueldoBasico);
   
        }
        Console.WriteLine($"el monto total es { montoTotal}");

        int edadJub =0;
        int antigueJub = 0;
         Empleado empleadoJub = new Empleado();
    int jub = 80;
            for (int i = 0; i < empleados.Length; i++)
            {
                int edad = empleados[i].antiguedad(empleados[i].FechaNac);
                
                
                if (empleados[i].aniosParaJub(edad, empleados[i].Genero) <=jub)
                {   edadJub = edad;
                    jub = empleados[i].aniosParaJub(edad, empleados[i].Genero);
                    antigueJub = empleados[i].antiguedad(empleados[i].FechaIngreso);
                    empleadoJub = empleados[i];
                    
                }

                
            }

            Console.WriteLine($"la edad del empleado mas proximo  a jubilarse es {edadJub}");
            Console.WriteLine($"la antiguedad del empleado mas proximo  a jubilarse es {antigueJub}");
            Console.WriteLine($"los años que le faltan para jubilarse son {jub} anios");

            montoTotal +=  empleadoJub.calcularSalario(antigueJub, empleadoJub.Cargo, empleadoJub.EstadoCivil, empleadoJub.SueldoBasico);
                        Console.WriteLine($" el sueldo neto del empleado cerca de jubliarse es de {montoTotal} anios"); 
            empleadoJub.MostrarDatos(empleadoJub);




        }


    }


}
