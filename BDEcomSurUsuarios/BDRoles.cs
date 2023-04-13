using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDEcomSurUsuarios
{
    public class BDRoles
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fiIdRol { get; set; }    
        public string? fiName { get; set; }
    }
}
