using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
        public DbSet<Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Models.historialconversion> Datahistorialconversion { get; set; }
        public DbSet<Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Models.transacciones> Datatransacciones { get; set; }
        public DbSet<Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Models.usuarios> Datausuarios { get; set; }

}
