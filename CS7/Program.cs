using System;

namespace CS7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Bloque de función
            // Sesión 15: Funciones 151020206
            /*
            Función: Bloque de instrucciones para realizar una tarea especifica, que se ejecuta cuando es invocado.
            Sintaxis: Definicion de función
            tipo de dato_devuelto identifiador_función(parametros)
            {
             Bloque de instrucciones
            }
            Nota1:Los parametros se definen incluyendo tipo de dato.
            Nota2: Los parametros van separados por comas.
            Sintaxis: Invocacion de función.
            identifiador_función(argumentos);
            Argumento: Valor del parametros.
            */
            // Ejemplo 1: Función vacia y sin parametros.
            void Saludar()
            {
                string salon = "331";
                Console.WriteLine($"¡Hola, {salon}!");
            }
            // Invocación
            Saludar();
            // Ejercitación
            // 1. Definir e invocar una funcion para imprimir: nombr, clave y salon.
            void ejercitacion()
            {
                string nombre = "Santiago Robles";
                string clave = "331-32";
                string salon = "331";
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Clave: {clave}");
                Console.WriteLine($"Salón: {salon}");
            }
            // Invocación
            ejercitacion();

            // 2. Definir e invocar una funcion sin parametros para desplegar el horario de hoy.
            void horario()
            {
                string primera = "7:00: Calculo";
                string segunda = "7:50: Formacion Humana";
                string tercera = "8:40: Programacion";
                string cuarta = "9:50: Psicologia";
                string quinta = "10:40: Idiomas";
                string sexta = "11:50: Dibujo Tecnico";
                string septima = "12:40: Dibujo Tecnico";
                Console.WriteLine($"Primer hora: {primera}");
                Console.WriteLine($"Segunda hora: {segunda}");
                Console.WriteLine($"Tercer hora: {tercera}");
                Console.WriteLine($"Cuarta hora: {cuarta}");
                Console.WriteLine($"Quinta hora: {quinta}");
                Console.WriteLine($"Sexta hora: {sexta}");
                Console.WriteLine($"Septima hora: {septima}");
            }
            // Invocación
            horario();
            // Sesion 16: Función con parámetros
            // return: Palabra reservada para terminar una función y devoler una expresión.
            // Ejemplos 1: Doble
            // Definición
            int CalcularDoble(int numero)
            {
                int resultado = 2 * numero;
                return resultado;
            }
            // Invocación
            int devolución;
            devolución = CalcularDoble(3);
            Console.WriteLine($"Devolución: {devolución}");
            // Ejercitación
            // 1. Definir e invocar una función que devuelva la evaluacion de la siguiente expresión: f(x) = 4x -7/5
            double f(double x)
            {
                double y = 4 * x - 7 / 5D;
                return y;
            }
            double d;
            d= f(0);
            Console.WriteLine($"f(0): {d}");
        }
    }
}