class Program
{
    static void Main(string[] args)
    {
        GestorTareas gestor = new GestorTareas();

        int menu;
        
        do
        {
        Console.WriteLine("1. Agregar una nueva tarea\n2. Buscar tarea por ID \n3. Marcar una tarea como completada \n4. Mostrar todas las tareas \n5. Mostrar tareas pendientes \n6. Salir");
        Console.WriteLine("Ingrese a la opción que desea ingresar: ");
        menu = int.Parse(Console.ReadLine());
        while(menu < 1 || menu >= 7)
        {
        Console.WriteLine("1. Agregar una nueva tarea\n2. Buscar tarea por ID \n3. Marcar una tarea como completada \n4. Mostrar todas las tareas \n5. Mostrar tareas pendientes \n6. Salir");
        Console.WriteLine("Ingrese a la opción que desea ingresar: ");
        menu = int.Parse(Console.ReadLine());
        }
        
        switch(menu)
        {
            case 1:
            string descr;
            Console.WriteLine ("Ingrese la descripcion de la tarea: ");
            descr = Console.ReadLine();
            gestor.agregarTareas(descr);
            Console.WriteLine ("Tarea agregada.");
            break;

            case 2: 
            int idProgram;
            Tarea tareaMostrar = null;
            Console.WriteLine ("Ingrese el ID de la tarea: ");
            idProgram = int.Parse(Console.ReadLine());
            tareaMostrar = gestor.buscarTarea(idProgram);
            tareaMostrar.mostrarDatos();
            break; 

            case 3:
            int idP;
            Console.WriteLine ("Ingrese el ID de la tarea: ");
            idP = int.Parse(Console.ReadLine());
            gestor.marcarTareaCompletada(idP);
            Console.WriteLine("Tarea marcada");
            break;

            case 4:
            gestor.mostrarTareas();
            break;

            case 5:
            gestor.mostrarPendientes();
            break;

            case 6:
            Console.WriteLine("Saliste del menú.");
            break;
        }
        }while(menu != 6);
    }
}
