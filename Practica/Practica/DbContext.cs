using Microsoft.EntityFrameworkCore;
using Practica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Context : DbContext
{
    public DbSet<Student> Estudiante { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=AWITA28\\SQLEXPRESS;Database=Programcio2;Trusted_Connection=True;");
    }
}