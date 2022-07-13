using Microsoft.EntityFrameworkCore;
using ProyectoUnidad1.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoUnidad1.AplicationDbContext
{
    public class AplicationdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server = localhost; database = proyecto23bv; user= root; pasword= ");
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
