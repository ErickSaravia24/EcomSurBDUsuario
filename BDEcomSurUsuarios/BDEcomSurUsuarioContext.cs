using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDEcomSurUsuarios
{
    public class BDEcomSurUsuarioContext:DbContext
    {
        public BDEcomSurUsuarioContext(DbContextOptions<BDEcomSurUsuarioContext> options) : base(options) { }
        public DbSet<BDUsuarios> BDUsuarios { get; set;}
        public DbSet<BDRoles> BDRoles { get; set;}
        public DbSet<BDPermisos> BDPermisos { get; set;}
        public DbSet<BDRolesPermisos> BDRolesPermisos { get;}
    }
}
