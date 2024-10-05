using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Models
{
    [Table ("t_usuarios")]
    public class usuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}