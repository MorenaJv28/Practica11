using Registro.Models;

using (var bd = new Contexto())
{
    bd.Database.EnsureCreated();
    var Registro = true;
    while (Registro)
    {
        Console.WriteLine("Ingrese el nombre del estudiante: ");
        var Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido del estudiante");
        var Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese la edad del estudiante (Solo numeros enteros)");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el sexo del estudiante (Usar F= Femenino o Usar M= Masculino");
        var Sexo = Console.ReadLine();
        var Estudiante = new Estudiante()
        {
            Nombres = Nombre,
            Apellidos = Apellido,
            Edad = Edad,
            Sexo = Sexo
        };
        bd.Add(Estudiante);
        bd.SaveChanges();
        Console.WriteLine("Registro completado");

        Console.Write(@"Usuario ¿Desea agregar más registros?
Si su respuesta es si ingrese la letra: S
Si su respuesta es No ingrese la letra: N
Ingrese su respuesta: ");
        string Menu = Console.ReadLine();

        Registro = (Menu.Trim().ToUpper() == "S");

        Console.WriteLine("Datos de la tabla:");
        foreach (var item in bd.Estudiante)
        {
            Console.WriteLine("Id del estudiante: " + item.Id);
            Console.WriteLine("Nombre del estudiante " + item.Nombres);
            Console.WriteLine("Apellidos del estudiante: " + item.Apellidos);
            Console.WriteLine("Edad del estudiante: " + item.Edad + " años");
            Console.WriteLine("Sexo del estudiante: " + item.Sexo);
        }
    }

}
