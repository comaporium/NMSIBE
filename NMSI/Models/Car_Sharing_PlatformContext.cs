using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NMSI.Models
{
    public partial class Car_Sharing_PlatformContext : DbContext
    {
        public Car_Sharing_PlatformContext()
        {
        }

        public Car_Sharing_PlatformContext(DbContextOptions<Car_Sharing_PlatformContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DodatneUsluge> DodatneUsluges { get; set; }
        public virtual DbSet<DodatniTroskovi> DodatniTroskovis { get; set; }
        public virtual DbSet<Kompanija> Kompanijas { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<NivoNaloga> NivoNalogas { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }
        public virtual DbSet<Recenzije> Recenzijes { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<Slike> Slikes { get; set; }
        public virtual DbSet<Troskovi> Troskovis { get; set; }
        public virtual DbSet<Usluge> Usluges { get; set; }
        public virtual DbSet<VrstaUsluge> VrstaUsluges { get; set; }
        public virtual DbSet<VwRecenzija> VwRecenzijas { get; set; }
        public virtual DbSet<VwRecenzije> VwRecenzijes { get; set; }
        public virtual DbSet<VwRezervacijeKorisnika> VwRezervacijeKorisnikas { get; set; }
        public virtual DbSet<VwSveOuslugama> VwSveOuslugamas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Car_Sharing_Platform;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<DodatneUsluge>(entity =>
            {
                entity.HasKey(e => e.IddodatneUsluge);

                entity.ToTable("DODATNE_USLUGE");

                entity.Property(e => e.IddodatneUsluge)
                    .HasMaxLength(5)
                    .HasColumnName("IDDodatneUsluge")
                    .IsFixedLength(true);

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.Idkompanije)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.NazivDodatneUsluge)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);

                entity.Property(e => e.OpisDodatneUsluge)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdkompanijeNavigation)
                    .WithMany(p => p.DodatneUsluges)
                    .HasForeignKey(d => d.Idkompanije)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DODATNE_USLUGE_KOMPANIJA");
            });

            modelBuilder.Entity<DodatniTroskovi>(entity =>
            {
                entity.HasKey(e => e.IddodatnogTroska);

                entity.ToTable("DODATNI_TROSKOVI");

                entity.Property(e => e.IddodatnogTroska)
                    .HasMaxLength(5)
                    .HasColumnName("IDDodatnogTroska")
                    .IsFixedLength(true);

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.NazivTroska)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Kompanija>(entity =>
            {
                entity.HasKey(e => e.Idkompanije);

                entity.ToTable("KOMPANIJA");

                entity.Property(e => e.Idkompanije)
                    .HasMaxLength(5)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.Kontakt)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.NazivKompanije)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.OpisKompanije)
                    .HasMaxLength(150)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.HasKey(e => e.Idkorisnika);

                entity.ToTable("KORISNIK");

                entity.Property(e => e.Idkorisnika)
                    .HasMaxLength(13)
                    .HasColumnName("IDKorisnika")
                    .IsFixedLength(true);

                entity.Property(e => e.BrojTelefona)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);

                entity.Property(e => e.IdnivoaKorisnika)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("IDNivoaKorisnika")
                    .IsFixedLength(true);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdnivoaKorisnikaNavigation)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.IdnivoaKorisnika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KORISNIK_NIVO_NALOGA");
            });

            modelBuilder.Entity<NivoNaloga>(entity =>
            {
                entity.HasKey(e => e.IdnivoaKorisnika);

                entity.ToTable("NIVO_NALOGA");

                entity.Property(e => e.IdnivoaKorisnika)
                    .HasMaxLength(1)
                    .HasColumnName("IDNivoaKorisnika")
                    .IsFixedLength(true);

                entity.Property(e => e.Idkompanije)
                    .HasMaxLength(5)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.NazivNaloga)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdkompanijeNavigation)
                    .WithMany(p => p.NivoNalogas)
                    .HasForeignKey(d => d.Idkompanije)
                    .HasConstraintName("FK_NIVO_NALOGA_KOMPANIJA");
            });

            modelBuilder.Entity<Recenzija>(entity =>
            {
                entity.HasKey(e => e.Idrecenzije)
                    .HasName("PK__RECENZIJ__D04F100E0174CFA2");

                entity.ToTable("RECENZIJA");

                entity.Property(e => e.Idrecenzije).HasColumnName("IDRecenzije");

                entity.Property(e => e.Idkompanije)
                    .HasMaxLength(3)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.Idkorisnika)
                    .HasMaxLength(3)
                    .HasColumnName("IDKorisnika")
                    .IsFixedLength(true);

                entity.Property(e => e.Ocjena)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.Poruka)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Recenzije>(entity =>
            {
                entity.HasKey(e => e.Idrecenzije);

                entity.ToTable("RECENZIJE");

                entity.Property(e => e.Idrecenzije)
                    .HasMaxLength(5)
                    .HasColumnName("IDRecenzije")
                    .IsFixedLength(true);

                entity.Property(e => e.Idkompanije)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.Idkorisnika)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("IDKorisnika")
                    .IsFixedLength(true);

                entity.Property(e => e.Ocjena)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.Poruka)
                    .HasMaxLength(250)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdkompanijeNavigation)
                    .WithMany(p => p.Recenzijes)
                    .HasForeignKey(d => d.Idkompanije)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECENZIJE_KOMPANIJA");

                entity.HasOne(d => d.IdkorisnikaNavigation)
                    .WithMany(p => p.Recenzijes)
                    .HasForeignKey(d => d.Idkorisnika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECENZIJE_KORISNIK");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasKey(e => e.Idrezervacije);

                entity.ToTable("REZERVACIJA");

                entity.Property(e => e.Idrezervacije)
                    .HasMaxLength(5)
                    .HasColumnName("IDRezervacije")
                    .IsFixedLength(true);

                entity.Property(e => e.DatumDo).HasColumnType("datetime");

                entity.Property(e => e.DatumOd).HasColumnType("datetime");

                entity.Property(e => e.IddodatneUsluge)
                    .HasMaxLength(5)
                    .HasColumnName("IDDodatneUsluge")
                    .IsFixedLength(true);

                entity.Property(e => e.Idkorisnika)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("IDKorisnika")
                    .IsFixedLength(true);

                entity.Property(e => e.Idusluge)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDUsluge")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IddodatneUslugeNavigation)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.IddodatneUsluge)
                    .HasConstraintName("FK_REZERVACIJA_DODATNE_USLUGE");

                entity.HasOne(d => d.IdkorisnikaNavigation)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.Idkorisnika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REZERVACIJA_KORISNIK");

                entity.HasOne(d => d.IduslugeNavigation)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.Idusluge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REZERVACIJA_USLUGE");
            });

            modelBuilder.Entity<Slike>(entity =>
            {
                entity.HasKey(e => e.Idslike);

                entity.ToTable("SLIKE");

                entity.Property(e => e.Idslike)
                    .HasMaxLength(5)
                    .HasColumnName("IDSlike")
                    .IsFixedLength(true);

                entity.Property(e => e.Idusluge)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDUsluge")
                    .IsFixedLength(true);

                entity.Property(e => e.Urlslike)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("URLSlike")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IduslugeNavigation)
                    .WithMany(p => p.Slikes)
                    .HasForeignKey(d => d.Idusluge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SLIKE_USLUGE");
            });

            modelBuilder.Entity<Troskovi>(entity =>
            {
                entity.HasKey(e => e.IdtroskovaRezervacije);

                entity.ToTable("TROSKOVI");

                entity.Property(e => e.IdtroskovaRezervacije)
                    .HasMaxLength(5)
                    .HasColumnName("IDTroskovaRezervacije")
                    .IsFixedLength(true);

                entity.Property(e => e.DatumTroska).HasColumnType("datetime");

                entity.Property(e => e.IddodatnogTroska)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDDodatnogTroska")
                    .IsFixedLength(true);

                entity.Property(e => e.Idrezervacije)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDRezervacije")
                    .IsFixedLength(true);

                entity.Property(e => e.Kolicina)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IddodatnogTroskaNavigation)
                    .WithMany(p => p.Troskovis)
                    .HasForeignKey(d => d.IddodatnogTroska)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TROSKOVI_DODATNI_TROSKOVI");

                entity.HasOne(d => d.IdrezervacijeNavigation)
                    .WithMany(p => p.Troskovis)
                    .HasForeignKey(d => d.Idrezervacije)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TROSKOVI_REZERVACIJA");
            });

            modelBuilder.Entity<Usluge>(entity =>
            {
                entity.HasKey(e => e.Idusluge);

                entity.ToTable("USLUGE");

                entity.Property(e => e.Idusluge)
                    .HasMaxLength(5)
                    .HasColumnName("IDUsluge")
                    .IsFixedLength(true);

                entity.Property(e => e.BrojSjedista)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.DatumIstekaRegistracije).HasColumnType("date");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(150)
                    .IsFixedLength(true);

                entity.Property(e => e.Idkompanije)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.Idvrste)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDVrste")
                    .IsFixedLength(true);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);

                entity.Property(e => e.NazivUsluge)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);

                entity.Property(e => e.Snaga)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdkompanijeNavigation)
                    .WithMany(p => p.Usluges)
                    .HasForeignKey(d => d.Idkompanije)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USLUGE_KOMPANIJA");

                entity.HasOne(d => d.IdvrsteNavigation)
                    .WithMany(p => p.Usluges)
                    .HasForeignKey(d => d.Idvrste)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USLUGE_VRSTA_USLUGE");
            });

            modelBuilder.Entity<VrstaUsluge>(entity =>
            {
                entity.HasKey(e => e.Idvrste);

                entity.ToTable("VRSTA_USLUGE");

                entity.Property(e => e.Idvrste)
                    .HasMaxLength(5)
                    .HasColumnName("IDVrste")
                    .IsFixedLength(true);

                entity.Property(e => e.Vrsta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwRecenzija>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwRecenzija");

                entity.Property(e => e.Idkompanije)
                    .HasMaxLength(3)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.Idrecenzije).HasColumnName("IDRecenzije");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Ocjena)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.Poruka)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsFixedLength(true);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwRecenzije>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwRecenzije");

                entity.Property(e => e.Idkompanije)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDKompanije")
                    .IsFixedLength(true);

                entity.Property(e => e.Idrecenzije)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDRecenzije")
                    .IsFixedLength(true);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Ocjena)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.Poruka)
                    .HasMaxLength(250)
                    .IsFixedLength(true);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwRezervacijeKorisnika>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwRezervacijeKorisnika");

                entity.Property(e => e.CijenaDodatneUsluge)
                    .HasColumnType("money")
                    .HasColumnName("cijenaDodatneUsluge");

                entity.Property(e => e.CijenaUsluge)
                    .HasColumnType("money")
                    .HasColumnName("cijenaUsluge");

                entity.Property(e => e.DatumDo).HasColumnType("datetime");

                entity.Property(e => e.DatumOd).HasColumnType("datetime");

                entity.Property(e => e.IddodatneUsluge)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDDodatneUsluge")
                    .IsFixedLength(true);

                entity.Property(e => e.Idkorisnika)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("IDKorisnika")
                    .IsFixedLength(true);

                entity.Property(e => e.Idrezervacije)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDRezervacije")
                    .IsFixedLength(true);

                entity.Property(e => e.Idusluge)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDUsluge")
                    .IsFixedLength(true);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);

                entity.Property(e => e.NazivDodatneUsluge)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwSveOuslugama>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwSveOUslugama");

                entity.Property(e => e.BrojSjedista)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength(true);

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.DatumIstekaRegistracije).HasColumnType("date");

                entity.Property(e => e.Idusluge)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("IDUsluge")
                    .IsFixedLength(true);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength(true);

                entity.Property(e => e.NazivKompanije)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Snaga)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Urlslike)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("URLSlike")
                    .IsFixedLength(true);

                entity.Property(e => e.Vrsta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
