using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_6{
    internal class Program{
        static void Main(string[] args){
            
            string[] Dias_Semana =  {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"};
            int Horas_trabajadas, Horas_Semanales, Pago_hora, sueldo_millonario;
            Horas_Semanales = 0;
            Pago_hora = 0;


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t*******************Por favor complete los siguentes datos*******************\t\t");
            Console.ResetColor();
            Console.WriteLine("Ingrese las horas trabajadas hoy:");

            for(int i = 0; i <= 4; i++){
                Console.Write("Dia " + Dias_Semana[i] + ": " );
                Horas_trabajadas = int.Parse(Console.ReadLine());
                Horas_Semanales = Horas_Semanales + Horas_trabajadas;
            } 

            if(Horas_Semanales <= 40){
                Pago_hora = 150;
            }
            if(Horas_Semanales > 40){
                Pago_hora = 250;
            }

            sueldo_millonario = Pago_hora * Horas_Semanales;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("El sueldo es de: $" + sueldo_millonario);
            Console.ResetColor();



        }
    }
}
