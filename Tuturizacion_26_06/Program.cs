//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

using Tuturizacion_26_06.Models;

class Program
{
    static void Main(string[] args)
    {
        //agregarCliente();
        //consultarClientes();
        //consultarCliente();
        //modificarCliente();
        //eliminarCliente();
        consultarClientesFunciones();
    }

    //agregar cliente
    public static void agregarCliente()
    {
        Console.WriteLine("Método agregar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli.Nombre = "Luis";
        cli.Apellido = "Balladares";
        cli.Direccion = "Avenida 27 de Noviembre";
        cli.Telefono = "0983748389";
        cli.FechaNacimiento = new DateTime(1999, 10, 24);
        cli.Estado = "Activo";
        context.Clientes.Add(cli);
        context.SaveChanges();

        Console.WriteLine("Id: " + cli.Id + " Nombre: " + cli.Nombre + " Apellido: " + cli.Apellido);
    }

    public static void consultarClientes()
    {
        Console.WriteLine("Método consultar clientes");
        ClienteContext context = new ClienteContext();
        List<Cliente> listClientes = context.Clientes.ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Id: " + item.Id + " Nombre: " + item.Nombre + " Apellido: " + item.Apellido);
        }
    }

    public static void consultarCliente()
    {
        Console.WriteLine("Método consultar cliente por Id");
        ClienteContext context = new ClienteContext();
        Cliente cli = context.Clientes.Find(1);

        Console.WriteLine("Id: " + cli.Id + " Nombre: " + cli.Nombre + " Apellido: " + cli.Apellido);
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Método modificar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = context.Clientes.Find(1);

        cli.Nombre = "Ana";
        cli.Apellido = "Gómez";
        context.SaveChanges();
        Console.WriteLine("Id: " + cli.Id + " Nombre: " + cli.Nombre + " Apellido: " + cli.Apellido);
    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Método eliminar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = context.Clientes.Find(1);
        context.Remove(cli);
        context.SaveChanges();
        Console.WriteLine("Id: " + cli.Id + " Nombre: " + cli.Nombre + " Apellido: " + cli.Apellido);
    }

    public static void consultarClientesFunciones()
    {
        Console.WriteLine("Método consultar clientes con el uso de funciones");
        ClienteContext context = new ClienteContext();
        List<Cliente> listClientes;

        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente cli = context.Clientes.First();

        Console.WriteLine("Primer elemento de la tabla: " + cli.Id + "-" + cli.Nombre + "-" + cli.Apellido);

        listClientes = context.Clientes.Where(c => c.Nombre.StartsWith("A")).ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Id: " + item.Id + " Nombre: " + item.Nombre + " Apellido: " + item.Apellido);
        }
    }
}