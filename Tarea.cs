public class Tarea
{
    private string descripcion;
    private bool completada;
    private int id;

    public Tarea(string descripcion, int id)
    {
        this.descripcion = descripcion;
        this.completada = false;
        this.id = id;
    }

    internal void marcarCompletada()
    {
        this.completada = true;
    }

    public void mostrarDatos()
    {
        Console.WriteLine($"Tarea N°: {id}\nDescripcion: {descripcion}\n");
    }

    internal bool getCompletada()
    {
        return this.completada;
    }
}