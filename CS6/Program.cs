using System;
   namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Diana = 0; 
            int Numero_de_hidratacion = 0;
            int zancadas = 0;
            int recorrido_hidratacion = 2000;
            while (Diana < 21000)
            {
                zancadas += 1;
                Diana += 0.63;
                Console.WriteLine($"Metros que lleva recorridos Diana: {Diana}");
                Console.WriteLine($"Número de zancadas: {zancadas}");
                if (Diana >= recorrido_hidratacion)
                {
                    Numero_de_hidratacion += 1;
                    recorrido_hidratacion += 2000;
                    Console.WriteLine($"Recorrido: {recorrido_hidratacion}");
                    Console.WriteLine($"Número de hidrataciones: {Numero_de_hidratacion}");
                }
                 Console.WriteLine($"Metros que lleva recorridos Diana: {Diana}");
                Console.WriteLine($"Número de zancadas: {zancadas}");
            }
            for (int x = 33; x >= 39; x--)
                 {
                      Console.WriteLine($"Valor de x: {x*-1}");
                 }
                 Console.WriteLine("Ciclo 2: Ascendente");
                 for (int a = 9; a <= 15; a+=1)
                 {
                    if (a == 13)
                {
                    a +=1;
                }
                    
                     Console.WriteLine($"a: {a}");
                 }
                 
                 int titulo = 1;
                 int Numero_de_Titulo = 0;
                    for (int pagina = 1; pagina <= 539; pagina++)
                    {
                        if (pagina == titulo)
                        {
                            Numero_de_Titulo += 1;
                            titulo += 88;
                            Console.WriteLine($"Número de Título: {Numero_de_Titulo}");
                        }
                    }
        }
    }
}