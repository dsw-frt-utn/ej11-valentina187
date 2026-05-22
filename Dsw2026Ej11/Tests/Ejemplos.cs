using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

        CasoList gestionLista = new CasoList();


        // 1. Agregar 3 alumnos a la lista
        gestionLista.AgregarAlumno(new Alumno(1, "Javiera Mena", 8.5));
        gestionLista.AgregarAlumno(new Alumno(2, "Maria Elena Walsh", 9.2));
        gestionLista.AgregarAlumno(new Alumno(3, "Sara Facio", 7.8));

        // 2. Listar por consola los alumnos
        Console.WriteLine("--- Lista Inicial ---");
        foreach (var alumno in gestionLista.ObtenerLista()) 
        {
            Console.WriteLine(alumno); 
        }

        // 3. 
        Console.WriteLine("\n--- Buscando 'Sara Facio' ---");
        var encontrado = gestionLista.BuscarPorNombre("Sara Facio");
        if (encontrado is not null) 
            Console.WriteLine($"Encontrado: {encontrado}");

        // 4. 
        Console.WriteLine("\n--- Buscando alumno 'Umbertiño' ---");
        var noEncontrado = gestionLista.BuscarPorNombre("Umbertiño");
        Console.WriteLine(noEncontrado is null ? "No existe" : noEncontrado.ToString()); 

        // 5.
        Console.WriteLine("\n--- Eliminando a Sara Facio ---");
        if (encontrado is not null)
            gestionLista.EliminarAlumno(encontrado);
        foreach (var a in gestionLista.ObtenerLista()) Console.WriteLine(a);

        // 6. Eliminar el primer elemento y listar
        Console.WriteLine("\n--- Eliminando primer elemento (posicion 0) ---");
        gestionLista.EliminarEnPosicion(0);
        foreach (var a in gestionLista.ObtenerLista()) Console.WriteLine(a); 
    }


    

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary gestionDict = new CasoDictionary();

        // 1. Agregar 3 alumnos al diccionario (Legajo como clave)
        gestionDict.AgregarAlumno(new Alumno(101, "Javiera Mena", 8.5));
        gestionDict.AgregarAlumno(new Alumno(102, "Maria Elena Walsh", 9.2));
        gestionDict.AgregarAlumno(new Alumno(103, "Sara Facio", 7.8));

        // 2. Listar por consola los alumnos
        Console.WriteLine("\n--- Diccionario de Alumnos ---");
        foreach (var entrada in gestionDict.ObtenerDiccionario()) 
        {
            Console.WriteLine($"Clave (Legajo): {entrada.Key} -> Valor: {entrada.Value}");
        }

        // 3. Buscar un alumno por clave (legajo 102)
        Console.WriteLine("\n--- Buscando Legajo 102 ---");
        var alumno = gestionDict.BuscarPorLegajo(102);
        if (alumno is not null) Console.WriteLine($"Encontrado: {alumno}");

        // 4. Buscar un alumno por clave que no exista
        Console.WriteLine("\n--- Buscando Legajo 999 ---");
        var inexistente = gestionDict.BuscarPorLegajo(999);
        Console.WriteLine(inexistente is null ? "No existe" : inexistente.ToString());

        // 5. Eliminar un alumno por clave y listar
        Console.WriteLine("\n--- Eliminando Legajo 101 ---");
        gestionDict.EliminarPorLegajo(101);
        foreach (var a in gestionDict.ObtenerDiccionario().Values) Console.WriteLine(a);
    }




    

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {


        CasoLinq consulta = new CasoLinq();

       

    
        Console.WriteLine($"1. Primero: {consulta.GetPrimero()}");
        Console.WriteLine($"2. Último: {consulta.GetUltimo()}");
        Console.WriteLine($"3. Total Precios: {consulta.GetTotalPrecios():C}"); 
        Console.WriteLine($"4. Promedio Precios: {consulta.GetPromedioPrecios():C}");

        Console.WriteLine("5. Libros con Id > 15:");
        consulta.GetListById().ForEach(l => Console.WriteLine($"   - {l.Titulo} (Id: {l.Id})"));

        Console.WriteLine("6. Lista de strings (Título - Precio):");
        consulta.GetLibros().ForEach(s => Console.WriteLine($"   - {s}"));

        Console.WriteLine($"7. Mayor Precio: {consulta.GetMayorPrecio().Titulo}");
        Console.WriteLine($"8. Menor Precio: {consulta.GetMenorPrecio().Titulo}");

        Console.WriteLine("9. Libros con precio mayor al promedio:");
        consulta.GetMayorPromedio().ForEach(l => Console.WriteLine($"   - {l.Titulo} ({l.Precio:C})"));

        Console.WriteLine("10. Ordenados por título descendente (primeros 3):");
        var descendentes = consulta.GetOrdenadosPorTitulo();
        for (int i = 0; i < 3; i++) Console.WriteLine($"   - {descendentes[i].Titulo}"); 
    }


}

