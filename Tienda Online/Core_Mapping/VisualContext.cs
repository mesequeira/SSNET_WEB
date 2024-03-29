﻿using SSNET_DataModel.Mapping;
using SSNET_DataModel.Models;
using SSNET_DataModel.Models.Comercio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSNET_DataModel
{
    public class VisualContext : DbContext
    {
        public VisualContext()
            : base("Data Source=DESKTOP-VCVN96I;database=SSNET_WEB;user=sa;password=sqlcoop;persistsecurityinfo=true;language=spanish")
        {
        }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Compras> Compras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductosMap());
            modelBuilder.Configurations.Add(new UsuariosMap());
            modelBuilder.Configurations.Add(new ComprasMap());
        }
    }
}
