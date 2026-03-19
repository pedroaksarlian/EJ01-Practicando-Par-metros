public class Tarea
{
    private int id;
    private string descripcion;
    private bool completada;

    public Tarea(string descripcion)
    {
        this.id = 1;
        this.descripcion = descripcion;
        this.completada = false;
    }

    internal bool esMismoId(int idBuscar)
    {
        return this.id == idBuscar;
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