public class GestorTareas
{
    private List <Tarea> tareas;

    public GestorTareas()
    {
        tareas = new List<Tarea>();
    }

    public void agregarTareas(string descripcion)
    {
        int id = 1;
        tareas.Add(new Tarea(descripcion));
        id++;
    }

    public Tarea buscarTarea(int id)
    {
        int i = 0;
        Tarea tareaEncontrada = null;
        while(i < this.tareas.Count && !this.tareas[i].esMismoId(id))
        {
            i++;
        }
        if(i < this.tareas.Count)
        {
            tareaEncontrada = this.tareas[i];
        }
        return tareaEncontrada;
    }

    public void marcarTareaCompletada(int id)
    {
        Tarea tareaCompletar = buscarTarea(id);
        tareaCompletar.marcarCompletada();
    }

    public void mostrarTareas()
    {
        foreach(Tarea tareasMostrar in tareas)
        {
            tareasMostrar.mostrarDatos();
        }
    }

    public void mostrarPendientes()
    {
        foreach(Tarea tareasMostrar in tareas)
        {
            if(tareasMostrar.getCompletada() == false)
            {
                tareasMostrar.mostrarDatos();
            }
        }
    }
}