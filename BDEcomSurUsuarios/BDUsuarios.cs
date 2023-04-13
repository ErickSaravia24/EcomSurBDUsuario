using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BDEcomSurUsuarios
{
    public class BDUsuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fiId { get; set; }
        public int fiUsuarioId { get; set; }
        public string? fcNombre { get; set; }
        public string? fcAmaterno { get; set; }
        public string? fcApaterno { get; set; }
        public string? fcCalle { get; set; }
        public string? fcNumero { get; set; }
        public string? fcColonia { get; set; }
        public string? fcFechaCreacion { get; set; }
        public string? fcCorrero { get; set; }
        public string? fcPassword { get; set; }
        public int fiIdRol { get; set; }

        [ForeignKey("fiIdRol")]
        public virtual BDRoles BDRoles { get; set; }
    }
}