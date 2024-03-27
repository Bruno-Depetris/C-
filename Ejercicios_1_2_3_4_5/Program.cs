using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_1{
    internal class Program{
        static void Main(string[] args){

            int numero_uno, numero_dos, multiplicacion;

            Console.WriteLine("Ingrese dos valores por favor"); //writeline es para escribir sobre una una LINEA, mientras que solo write ocupa solo el texto
            Console.Write(": ");
            numero_uno = int.Parse(Console.ReadLine());      //int.parse se utiliza para escribir de cadena a numero entero
            Console.Write(": ");
            numero_dos = int.Parse(Console.ReadLine());


            multiplicacion = numero_uno * numero_dos;    
            Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacion);
//POSITIVO O NEGATIVO
            if(numero_dos  > 0 && numero_uno > 0){
                Console.WriteLine("Ambos numeros son positivos");
            }
            if(numero_dos  < 0 && numero_uno < 0){
                Console.WriteLine("Ambos numeros son Negativos");
            }
            if(numero_dos  < 0 && numero_uno > 0){
                Console.WriteLine("El segundo numero es negativo y el otro postivo");
            }
            if(numero_dos  > 0 && numero_uno < 0){
                Console.WriteLine("El primer numero es negativo y el otro postivo");
            }
//PAR IMPAR
            if(numero_dos % 2 == 0 && numero_uno % 2 == 0){
                Console.WriteLine("Ambos numeros son PAR");
            }
            if(numero_dos % 2 != 0 && numero_uno % 2 != 0){
                Console.WriteLine("Ambos numeros son IMPAR");
            }
            if(numero_dos % 2 == 0 && numero_uno % 2 != 0){
                Console.WriteLine("El segundo numero es PAR y el otro IMPAR");
            }
            if(numero_uno % 2 == 0 && numero_dos % 2 != 0){
                Console.WriteLine("El primer numero es PAR y el otro IMPAR");
            }
//MAYOR-MENOR
            if(numero_uno > numero_dos){
                Console.WriteLine("El numero uno es mayor");
            }else{
                Console.WriteLine("El numero dos es menor");
            }
        }
    }
}
