using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturar la información financiera de un cliente, nombre, numero de cuenta y saldo de apertura y permitirle realizar
            //consignaciones y retiros a la cuenta, finalmente consultar el saldo con el que queda la cuenta.
            string nombre;
            double numeroCuenta = 0;
            double saldoApertura = 0;
            double consignacion = 0, consignacionsuma=0;
            double retiro = 0;
            int decision = 0;
            char op = 's';
            char op1;
            double totalcuenta = 0;
            Console.WriteLine("Nombre de cliente: ");
            nombre = Console.ReadLine();
            Console.WriteLine("numero de cuenta: ");
            numeroCuenta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("saldo apertura: ");
            saldoApertura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("para consignacion digite 1");
            Console.WriteLine("para retiro digite 2 ");
            
            decision = Int32.Parse(Console.ReadLine());
            do { 
                if (decision == 1)
                {
                    Console.WriteLine("Cuanto dinero desea consignar: ");
                    consignacion = Convert.ToDouble(Console.ReadLine());
                    consignacionsuma = saldoApertura + consignacion;

                }
                else if (decision == 2)
                {
                    Console.WriteLine("Cuanto dinero desea retirar: ");
                    retiro = Convert.ToDouble(Console.ReadLine());
                    totalcuenta = consignacionsuma - retiro;
                }
                else
                {
                    Console.WriteLine("La opcion que desea elegir no esta Disponible");
                }
                Console.WriteLine("Desea realizar otro proceso? S/N");
                op1 = Convert.ToChar(Console.ReadLine());
                if(op1 =='s' ||op1 == 'S')
                {
                    Console.WriteLine("para consignacion digite 1");
                    Console.WriteLine("para retiro digite 2 ");
                    decision = Int32.Parse(Console.ReadLine());
                }else if (op1 == 'n' || op1 == 'N')
                {
                    op = 'N';
                }
                else
                {
                    Console.WriteLine("debe digitar S o N");
                }
            } while(op=='s');
            Console.WriteLine($"el saldo de su cuenta es:{totalcuenta} cosnignacion: {saldoApertura} + {consignacion}={consignacionsuma}");
            Console.ReadKey();
        }
    }
}
