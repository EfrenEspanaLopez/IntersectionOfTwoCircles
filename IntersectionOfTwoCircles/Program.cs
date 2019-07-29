using System;

namespace IntersectionOfTwoCircles
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                ValidateCircle();

                Console.Write("Salir (S)= ");
                var salir = Console.ReadLine();
                if (salir.ToLower() == "s")
                    break;
            }
            
        }

        static void ValidateCircle()
        {
            float y1, y2, x1, x2, r1, r2;

            Console.WriteLine("Ingrese cordenadas (x1) del primer circulo ");
            Console.Write("x1= ");
            x1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ingrese cordenadas (y1) del primer circulo ");
            Console.Write("y1= ");
            y1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ingrese radio (r1) del primer circulo ");
            Console.Write("r1= ");
            r1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ingrese cordenadas (x2) del segundo circulo ");
            Console.Write("x2= ");
            x2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ingrese cordenadas (x2) del segundo circulo ");
            Console.Write("y2= ");
            y2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ingrese radio (r2) del segundo circulo ");
            Console.Write("r2= ");
            r2 = Convert.ToInt64(Console.ReadLine());

            //Calcular la distancia entre dos puntos en el plano            
            var distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            ///Suma de los dos radios
            var sumaRadios = r1 + r2;
            ///Calcular la diferencia entre los radios
            var diferenciaRadios = Math.Abs(r1 - r2);


            if (distancia > sumaRadios || distancia < diferenciaRadios)
            {
                Console.WriteLine("No se intersectan");
                return;
            }

            if (distancia == 0 && r1 == r2)
            {
                Console.WriteLine("Los circulos son iguales");
                return;
            }

            if (distancia == sumaRadios || distancia == diferenciaRadios)
            {
                Console.WriteLine("Los circulos se intersentan");
                return;
            }

            if (distancia < sumaRadios || distancia > diferenciaRadios)
            {
                Console.WriteLine("Los circulos se intersentan");
                return;
            }
        }
    }
}
