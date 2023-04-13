using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDEcomSurUsuarios
{
    public class BDRolesPermisos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fiId { get; set; }
        public int fiIdRol { get; set; }
        public int fiIdPermiso { get; set; }

        [ForeignKey("fiIdRol")]
        public virtual BDRoles BDRoles { get; set; }

        [ForeignKey("fiIdPermiso")]
        public virtual BDPermisos BDPermisos { get; set; }
    }
}
