using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno ==> a)
//Incluir un método para agregar un alumno al diccionario ==> b)
//Incluir un método para buscar un alumno utilizando la clave ==> c)
//Incluir un método para retornar el diccionario ==> d)
//Incluir un método para eliminar un alumno utilizando la clave ==> e)
public class CasoDictionary
{
    //a)
    private Dictionary<int, Alumno> alumnosDict = new Dictionary<int, Alumno>();

    //b)
    public void AgregarAlumno(Alumno alumno)
    {
        if (!alumnosDict.ContainsKey(alumno.Legajo))
        {
            alumnosDict.Add(alumno.Legajo, alumno);
        }

    }
    //c)
    public Alumno? BuscarPorLegajo(int legajo)
    {
        
        if (alumnosDict.ContainsKey(legajo))
        {
            return alumnosDict[legajo]; 
        }
        return null;
    }

    //d)
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return alumnosDict;
    }

    //e)
    public bool EliminarPorLegajo(int legajo)
    {
        
        return alumnosDict.Remove(legajo); 
    }







}
