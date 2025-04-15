using System;

class Program
{
    static void Main()
    {
        string nombre = "";
        int cantidadNotas = 0;
        double sumaNotas = 0;
        int notasIngresadas = 0;

        Console.Write("Ingrese el nombre del estudiante: ");
        nombre = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.");
            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
        }

        Console.Write("¿Cuántas calificaciones tiene el estudiante? (1 a 5): ");
        string entradaCantidad = Console.ReadLine();
        cantidadNotas = int.Parse(entradaCantidad);

        while (cantidadNotas < 1 || cantidadNotas > 5)
        {
            Console.WriteLine("La cantidad debe estar entre 1 y 5.");
            Console.Write("¿Cuántas calificaciones tiene el estudiante? (1 a 5): ");
            entradaCantidad = Console.ReadLine();
            cantidadNotas = int.Parse(entradaCantidad);
        }

        while (notasIngresadas < cantidadNotas)
        {
            Console.Write("Ingrese la calificación #" + (notasIngresadas + 1) + " (1 a 10): ");
            string entradaNota = Console.ReadLine();
            double nota = double.Parse(entradaNota);

            if (nota >= 1 && nota <= 10)
            {
                sumaNotas += nota;
                notasIngresadas++;
            }
            else
            {
                Console.WriteLine("La calificación debe estar entre 1 y 10. Intente nuevamente.");
            }
        }

        double promedio = sumaNotas / cantidadNotas;

        string clasificacion = "";

        if (promedio >= 9)
        {
            clasificacion = "Excelente";
        }
        else if (promedio >= 7)
        {
            clasificacion = "Bueno";
        }
        else if (promedio >= 6)
        {
            clasificacion = "Regular";
        }
        else
        {
            clasificacion = "Reprobado";
        }

        Console.WriteLine("\nEstudiante: " + nombre);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Clasificación: " + clasificacion);

        Console.WriteLine("\nPresione Enter para salir...");
        Console.ReadLine();
    }
}