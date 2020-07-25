using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WSTowerWebApi.Domains;

namespace WSTowerWebApi.Contexts
{
    public partial class WSTowerContext : DbContext
    {
        public WSTowerContext()
        {
        }

        public WSTowerContext(DbContextOptions<WSTowerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estadio> Estadio { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<EventoESports> EventoESports { get; set; }
        public virtual DbSet<EventoFutebol> EventoFutebol { get; set; }
        public virtual DbSet<EventoShow> EventoShow { get; set; }
        public virtual DbSet<Favoritos> Favoritos { get; set; }
        public virtual DbSet<Times> Times { get; set; }
        public virtual DbSet<TipoEvento> TipoEvento { get; set; }
        public virtual DbSet<TipoParticipacao> TipoParticipacao { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-0VF65US\\SQLEXPRESS; Initial Catalog=WSTower;integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estadio>(entity =>
            {
                entity.HasKey(e => e.IdEstadio)
                    .HasName("PK__Estadio__A8BF7A24A3CA5B4E");

                entity.HasIndex(e => e.NomeEstadio)
                    .HasName("UQ__Estadio__B2537B1315C115E6")
                    .IsUnique();

                entity.Property(e => e.IdEstadio).HasColumnName("idEstadio");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.NomeEstadio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.IdEvento)
                    .HasName("PK__Evento__C8DC7BDAD3E524F1");

                entity.Property(e => e.IdEvento).HasColumnName("idEvento");

                entity.Property(e => e.AcessoLivre)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DataEvento).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.HoraDoEvento).HasColumnType("datetime");

                entity.Property(e => e.IdEstadio).HasColumnName("idEstadio");

                entity.Property(e => e.IdEventoESports).HasColumnName("idEventoE_Sports");

                entity.Property(e => e.IdEventoFutebol).HasColumnName("idEventoFutebol");

                entity.Property(e => e.IdEventoShow).HasColumnName("idEventoShow");

                entity.Property(e => e.IdTipoEvento).HasColumnName("idTipoEvento");

                entity.Property(e => e.IdTipoParticipacao).HasColumnName("idTipoParticipacao");

                entity.HasOne(d => d.IdEstadioNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdEstadio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evento__idEstadi__5EBF139D");

                entity.HasOne(d => d.IdEventoESportsNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdEventoESports)
                    .HasConstraintName("FK__Evento__idEvento__6383C8BA");

                entity.HasOne(d => d.IdEventoFutebolNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdEventoFutebol)
                    .HasConstraintName("FK__Evento__idEvento__628FA481");

                entity.HasOne(d => d.IdEventoShowNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdEventoShow)
                    .HasConstraintName("FK__Evento__idEvento__619B8048");

                entity.HasOne(d => d.IdTipoEventoNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdTipoEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evento__idTipoEv__5FB337D6");

                entity.HasOne(d => d.IdTipoParticipacaoNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdTipoParticipacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evento__idTipoPa__60A75C0F");
            });

            modelBuilder.Entity<EventoESports>(entity =>
            {
                entity.HasKey(e => e.IdEventoESports)
                    .HasName("PK__EventoE___414EEA3AD7EC78C4");

                entity.ToTable("EventoE_Sports");

                entity.Property(e => e.IdEventoESports).HasColumnName("idEventoE_Sports");

                entity.Property(e => e.NomeEventoESports)
                    .IsRequired()
                    .HasColumnName("NomeEventoE_Sports")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventoFutebol>(entity =>
            {
                entity.HasKey(e => e.IdEventoFutebol)
                    .HasName("PK__EventoFu__4FA454CA6C1E2DF8");

                entity.Property(e => e.IdEventoFutebol).HasColumnName("idEventoFutebol");

                entity.Property(e => e.IdTimeCasa).HasColumnName("idTimeCasa");

                entity.Property(e => e.IdTimeVisitante).HasColumnName("idTimeVisitante");

                entity.HasOne(d => d.IdTimeCasaNavigation)
                    .WithMany(p => p.EventoFutebolIdTimeCasaNavigation)
                    .HasForeignKey(d => d.IdTimeCasa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventoFut__idTim__5AEE82B9");

                entity.HasOne(d => d.IdTimeVisitanteNavigation)
                    .WithMany(p => p.EventoFutebolIdTimeVisitanteNavigation)
                    .HasForeignKey(d => d.IdTimeVisitante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventoFut__idTim__5BE2A6F2");
            });

            modelBuilder.Entity<EventoShow>(entity =>
            {
                entity.HasKey(e => e.IdEventoShow)
                    .HasName("PK__EventoSh__4AF0833E4BB89618");

                entity.Property(e => e.IdEventoShow).HasColumnName("idEventoShow");

                entity.Property(e => e.NomeEventoShow)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Favoritos>(entity =>
            {
                entity.HasKey(e => e.IdFavoritos)
                    .HasName("PK__Favorito__399BE5926B63AD4D");

                entity.Property(e => e.IdFavoritos).HasColumnName("idFavoritos");

                entity.Property(e => e.IdEvento).HasColumnName("idEvento");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.StatusFavorito).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdEventoNavigation)
                    .WithMany(p => p.Favoritos)
                    .HasForeignKey(d => d.IdEvento)
                    .HasConstraintName("FK__Favoritos__idEve__68487DD7");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Favoritos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Favoritos__idUsu__6754599E");
            });

            modelBuilder.Entity<Times>(entity =>
            {
                entity.HasKey(e => e.IdTimes)
                    .HasName("PK__Times__D219ACFD52A8FEAB");

                entity.HasIndex(e => e.NomeTime)
                    .HasName("UQ__Times__785837A6D94F39A3")
                    .IsUnique();

                entity.Property(e => e.IdTimes).HasColumnName("idTimes");

                entity.Property(e => e.NomeTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEvento>(entity =>
            {
                entity.HasKey(e => e.IdTipoEvento)
                    .HasName("PK__TipoEven__09EED93AE6119493");

                entity.HasIndex(e => e.NomeTipoEvento)
                    .HasName("UQ__TipoEven__B7CA5C862072BB18")
                    .IsUnique();

                entity.Property(e => e.IdTipoEvento).HasColumnName("idTipoEvento");

                entity.Property(e => e.NomeTipoEvento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoParticipacao>(entity =>
            {
                entity.HasKey(e => e.IdTipoParticipacao)
                    .HasName("PK__TipoPart__C3B421B4B79F10B5");

                entity.HasIndex(e => e.TituloParticipacao)
                    .HasName("UQ__TipoPart__45CA55CA8E3B0368")
                    .IsUnique();

                entity.Property(e => e.IdTipoParticipacao).HasColumnName("idTipoParticipacao");

                entity.Property(e => e.TituloParticipacao)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__03006BFFE7815D56");

                entity.HasIndex(e => e.NomeTipoUsuario)
                    .HasName("UQ__TipoUsua__C6FB90A86BF4C93E")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A6C364E94C");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Usuario__A9D10534B1BA696D")
                    .IsUnique();

                entity.HasIndex(e => e.Telefone)
                    .HasName("UQ__Usuario__4EC504B637FD2889")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__idTipoU__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
