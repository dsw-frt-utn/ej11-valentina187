using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>) => a)
//Incluir un método para agregar alumnos a la lista => b)
//Incluir un método para retornar la lista => c)
//Incluir un método para buscar un alumno por nombre => d) 
//Incluir un método para eliminar un alumno (debe recibir un alumno) => e) 
//Incluir un método para eliminar un alumno en una determinada posición de la lista => f)


public class CasoList
{
    //a)
    public List<Alumno> alumnos = new List<Alumno>();

    //b)
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    //c)
    public List<Alumno> ObtenerLista()
    {
        return alumnos;
    }

    //d)
    public Alumno? BuscarPorNombre(string nombre)
    {
        return alumnos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    //e)
    public bool EliminarAlumno(Alumno alumno)
    {
        return alumnos.Remove(alumno);
    }

    //f)
    public void EliminarEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
    }
}
