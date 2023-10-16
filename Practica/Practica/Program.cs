using Practica;

using (var DbContext = new Context())
{
    DbContext.Database.EnsureCreated();
    var Agregar_Nuevo_Registros = true;
    while (Agregar_Nuevo_Registros)
    {
        Console.WriteLine("Ingrese el nombre del estudiante: ");
        var Nuevo_Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido del estudiante");
        var Nuevo_apellido = Console.ReadLine();
        Console.WriteLine("Ingrese la edad del estudiante (Solo numeros enteros)");
        int Nuevo_Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el sexo del estudiante (Usar F= Femenino o Usar M= Masculino");
        var Nuevo_Sexo = Console.ReadLine();
        var Estudiante1 = new Student()
        {
            Nombres = Nuevo_Nombre,
            Apellidos = Nuevo_apellido,
            Edad = Nuevo_Edad,
            Sexo = Nuevo_Sexo
        };
        DbContext.Add(Estudiante1);
        DbContext.SaveChanges();
        Console.WriteLine("Registro completado");

        Console.Write(@"Usuario ¿Desea agregar más registros?
Si su respuesta es si ingrese la letra: S
Si su respuesta es No ingrese la letra: N
Ingrese su respuesta: ");
        string Respuesta_del_usuario = Console.ReadLine();

        Agregar_Nuevo_Registros = (Respuesta_del_usuario.Trim().ToUpper() == "S");
    }

}

using (var bd = new Context())
{
    Console.WriteLine("Datos de la tabla:");
    foreach (var item in bd.Estudiante)
    {
        Console.WriteLine("==============================");
        Console.WriteLine("Id del estudiante: " + item.Id);
        Console.WriteLine("Nombre del estudiante " + item.Nombres);
        Console.WriteLine("Apellidos del estudiante: " + item.Apellidos);
        Console.WriteLine("Edad del estudiante: " + item.Edad + " años");
        Console.WriteLine("Sexo del estudiante: " + item.Sexo);
    }
    Console.WriteLine("==============================");
}