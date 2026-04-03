using System;
using System.Collections.Generic;

class Program
{
    static List<string> usuarios = new List<string>();

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE GESTION DE USUARIOS ===");
            Console.WriteLine("1. Crear usuario");
            Console.WriteLine("2. Ver usuarios");
            Console.WriteLine("3. Actualizar usuario");
            Console.WriteLine("4. Eliminar usuario");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opcion: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearUsuario();
                    break;
                case "2":
                    VerUsuarios();
                    break;
                case "3":
                    ActualizarUsuario();
                    break;
                case "4":
                    EliminarUsuario();
                    break;
                case "5":
                    salir = true;
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pausa();
                    break;
            }
        }
    }

    static void CrearUsuario()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nombre))
        {
            usuarios.Add(nombre);
            Console.WriteLine("Usuario creado.");
        }
        else
        {
            Console.WriteLine("Nombre invalido.");
        }

        Pausa();
    }

    static void VerUsuarios()
    {
        Console.WriteLine("=== USUARIOS ===");

        if (usuarios.Count == 0)
        {
            Console.WriteLine("No hay usuarios.");
        }
        else
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {usuarios[i]}");
            }
        }

        Pausa();
    }

    static void ActualizarUsuario()
    {
        VerUsuariosSinPausa();

        if (usuarios.Count == 0)
        {
            Pausa();
            return;
        }

        Console.Write("Numero: ");
        if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= usuarios.Count)
        {
            Console.Write("Nuevo nombre: ");
            usuarios[i - 1] = Console.ReadLine();
            Console.WriteLine("Actualizado.");
        }
        else
        {
            Console.WriteLine("Error.");
        }

        Pausa();
    }

    static void EliminarUsuario()
    {
        VerUsuariosSinPausa();

        if (usuarios.Count == 0)
        {
            Pausa();
            return;
        }

        Console.Write("Numero: ");
        if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= usuarios.Count)
        {
            usuarios.RemoveAt(i - 1);
            Console.WriteLine("Eliminado.");
        }
        else
        {
            Console.WriteLine("Error.");
        }

        Pausa();
    }

    static void VerUsuariosSinPausa()
    {
        Console.WriteLine("=== USUARIOS ===");

        if (usuarios.Count == 0)
        {
            Console.WriteLine("No hay usuarios.");
        }
        else
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {usuarios[i]}");
            }
        }
    }

    static void Pausa()
    {
        Console.WriteLine("Presiona una tecla...");
        Console.ReadKey();
    }
}