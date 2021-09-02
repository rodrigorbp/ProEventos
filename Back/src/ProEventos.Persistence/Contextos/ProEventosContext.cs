using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contextos
{
    public class ProEventosContext : DbContext
    {
        //Construtor para passar as informações de strin de conexão para a classe base
        public ProEventosContext(DbContextOptions<ProEventosContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }        
        public DbSet<Lote> Lotes { get; set; }  
        public DbSet<Palestrante> Palestrantes { get; set; }  
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }  
        public DbSet<RedeSocial> RedesSociais { get; set; }  

        //Configuração para mostrar ao Entity que a tabela PalestranteEvento é junçâo de N*N para as tabelas Evento e Palestrante
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new {PE.EventoId, PE.PalestranteId});

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.RedesSociais)
                .WithOne(rs => rs.Evento)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Palestrante>()
                .HasMany(p => p.RedesSociais)
                .WithOne(rs => rs.Palestrante)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}