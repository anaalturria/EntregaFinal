﻿using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        //        public DbSet<Usuario> Usuario { get; set; }//

    }
}
