using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_basicas_pilas_y_colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueWithArray cola = new QueueWithArray(5); // Tamaño de la cola: 5 elementos

            Console.WriteLine("Operaciones de Cola:");

            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Enqueue(5);

            Console.WriteLine("Elemento frontal de la cola: " + cola.Front()); // Debe imprimir 1

            Console.WriteLine("Desencolar de la cola: " + cola.Dequeue()); // Debe imprimir 1
            Console.WriteLine("Elemento frontal de la cola después del Desencolar: " + cola.Front()); // Debe imprimir 2

            cola.Enqueue(6);
            Console.WriteLine("Nuevo elemento frontal de la cola: " + cola.Front()); // Debe imprimir 2
        }
    }
    }
class QueueWithArray
{
    private int[] arreglo;
    private int frente;
    private int fin;
    private int capacidad;
    private int count;

    public QueueWithArray(int capacidad)
    {
        this.capacidad = capacidad;
        arreglo = new int[capacidad];
        frente = 0;
        fin = -1;
        count = 0;
    }

    public void Enqueue(int elemento)
    {
        if (count < capacidad)
        {
            fin = (fin + 1) % capacidad;
            arreglo[fin] = elemento;
            count++;
        }
        else
        {
            Console.WriteLine("Error: Cola llena.");
        }
    }
    public int Dequeue()
    {
        if (count > 0)
        {
            int elemento = arreglo[frente];
            frente = (frente + 1) % capacidad;
            count--;
            return elemento;
        }
        else
        {
            Console.WriteLine("Error: Cola vacía.");
            return -1;
        }
    }

    public int Front()
    {
        if (count > 0)
        {
            return arreglo[frente];
        }
        else
        {
            Console.WriteLine("Error: Cola vacía.");
            return -1;
        }

    }

}