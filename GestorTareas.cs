public class GestorTareas
{
    private Dictionary<int, Tarea> tareas;

    public GestorTareas()
    {
        tareas = new Dictionary<int, Tarea>();
    }

    public void agregarTareas(string descripcion)
    {
        int id = 1;
        Tarea tarea = new Tarea(descripcion);
        tareas.Add(id, tarea);
        id++;
    }

    public bool buscarTareas(int id){
        bool tareaBuscar = false;
        tareaBuscar = tareas.ContainsKey(id);
        return tareaBuscar;
    }

    public bool marcarTareaCompletada(int id)
    {
        Tarea tareaCompletar = null;
        bool tareaEncontrar= tareas.ContainsKey(id);
        if(tareaEncontrar == true)
        {
            tareas[id].marcarCompletada();
        }
        return tareaEncontrar;
    }

    public void mostrarTareas()
    {
        foreach(Tarea tareasMostrar in tareas.Values)
        {
            tareasMostrar.mostrarDatos();
        }
    }

    public void mostrarPendientes()
    {
        foreach(Tarea tareasMostrar in tareas.Values)
        {
            if(tareasMostrar.getCompletada() == false)
            {
                tareasMostrar.mostrarDatos();
            }
        }
    }
}