public class Tarea
{
    private int id;
    private string descripcion;
    private bool completada;

    public Tarea(int id, string descripcion)
    {
        this.id = 1;
        this.descripcion = descripcion;
        this.completada = false;
    }

    internal bool esMismoId(int idBuscar)
    {
        return this.id == idBuscar;
    }
}