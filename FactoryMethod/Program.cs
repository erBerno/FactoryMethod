using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        public interface ICarSupplier
        {
            string CarColor { get; }
            void GetCarModel();
        }
        class Honda : ICarSupplier
        {
            public string CarColor
            {
                get { return "RED"; }
            }

            public void GetCarModel()
            {
                Console.WriteLine("Honda Car Model is Honda 2014");
            }
        }
        class BMW : ICarSupplier
        {
            public string CarColor
            {
                get { return "WHITE"; }
            }
            public void GetCarModel()
            {
                Console.WriteLine("BMW Car Model is BMW 2000");
            }
        }

        class Nano : ICarSupplier
        {
            public string CarColor
            {
                get { return "YELLOW"; }
            }
            public void GetCarModel()
            {
                Console.WriteLine("Nano Car Model is Nano 2016");
            }
        }
        class Suzuki : ICarSupplier
        {
            public string CarColor
            {
                get { return "Orange"; }
            }
            public void GetCarModel()
            {
                Console.WriteLine("Suzuki Car Model is Suzuki 2006");
            }
        }

        //Factory Method
        class CarFactory
        {
            public static ICarSupplier GetCarInstance(int Id)
            {
                switch (Id)
                {
                    case 0:
                        return new Honda();
                    case 1:
                        return new BMW();
                    case 2:
                        return new Nano();
                    case 3:
                        return new Suzuki();
                    default:
                        return null;
                }
            }
        }

        static void Main(string[] args)
        {
            //Codigo sin implementar Factory Method
            Console.WriteLine("* Código sin implementar Factory Method *");
            Honda objHonda = new Honda();
            objHonda.GetCarModel();

            BMW objBMW = new BMW();
            objBMW.GetCarModel();

            Nano objNano = new Nano();
            objNano.GetCarModel();

            Console.WriteLine("----------------------------------------------------------------------------");

            //Codigo con Factory Method incluido
            Console.WriteLine("* Código con Factory Method incluido *");
            Console.WriteLine("Ingrese el ID: (0-3)");
            int id = int.Parse(Console.ReadLine());

            ICarSupplier objCarSupplier = CarFactory.GetCarInstance(id);
            objCarSupplier.GetCarModel();
            Console.WriteLine("And Car Color is " + objCarSupplier.CarColor);

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("* Mostrando todos los autos: *");

            for (int i = 0; i < 4; i++)
            {
                objCarSupplier = CarFactory.GetCarInstance(i);
                objCarSupplier.GetCarModel();
                Console.WriteLine("And Car Color is " + objCarSupplier.CarColor);
            }

            Console.ReadKey();
        }
    }
}
