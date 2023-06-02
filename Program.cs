// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        int opcion = 0;
         Calculadora calc1;
        public void pedirNum (){
        double num;
        bool valido = false;
        string entrada; 
         
          calc1 = new Calculadora(); 
        do
        {

        Console.WriteLine("ingrese el primer numero ");
        entrada = Console.ReadLine(); 
         valido = double.TryParse(entrada, out num);    
        Console.WriteLine("ingrese la operacion a realizar 1-suma\n 2-resta\n 3-multiplicacion\n 4-division\n");
        entrada = Console.ReadLine(); 
         valido = int.TryParse(entrada, out opcion);
       


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
                        
                        Console.Write(" El resultado de la suma es ");
                        calc1.suma(num);
                        Console.WriteLine(calc1.Resultado);
                        break;   

             case 4:
                        
                        Console.Write(" El resultado de la suma es ");
                       calc1.suma(num);
                        Console.WriteLine(calc1.Resultado);
                        break;            
            default: 
            break;
        }



         if (!valido)
         {
            Console.WriteLine(" el numero  ingresado no es valido");         
         }
        } while (!valido);
        }
        public void UsarCalc(){ 
                
                

            }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Calculadora cal = new Calculadora();
            cal.suma(15);
            Console.WriteLine(cal.Resultado);
            cal.resta(52);
            Console.WriteLine(cal.Resultado); 

            do
            {
                
            } while (true);
            
        }
    }
}
