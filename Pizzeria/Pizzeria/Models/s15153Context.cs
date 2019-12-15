using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pizzeria.Models
{
    public partial class s15153Context : DbContext
    {
        public s15153Context()
        {
        }

        public s15153Context(DbContextOptions<s15153Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DaneKontaktowe> DaneKontaktowe { get; set; }
        public virtual DbSet<Dostawa> Dostawa { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Lokal> Lokal { get; set; }
        public virtual DbSet<Platnosc> Platnosc { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<ProduktSkladnik> ProduktSkladnik { get; set; }
        public virtual DbSet<Promocja> Promocja { get; set; }
        public virtual DbSet<RodzajProduktu> RodzajProduktu { get; set; }
        public virtual DbSet<RozmiarProduktu> RozmiarProduktu { get; set; }
        public virtual DbSet<Skladnik> Skladnik { get; set; }
        public virtual DbSet<SkladnikDodatkowy> SkladnikDodatkowy { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public virtual DbSet<ZamowienieSkladnikDodatkowy> ZamowienieSkladnikDodatkowy { get; set; }

        // Unable to generate entity type for table 'dbo.DEPT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SALGRADE'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s15153;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<DaneKontaktowe>(entity =>
            {
                entity.HasKey(e => e.IdDaneKontaktowe)
                    .HasName("DaneKontaktowe_pk");

                entity.Property(e => e.IdDaneKontaktowe).ValueGeneratedNever();

                entity.Property(e => e.KodPocztowy)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Miasto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumerDomu)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumerTel)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ulica)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLokalNavigation)
                    .WithMany(p => p.DaneKontaktowe)
                    .HasForeignKey(d => d.IdLokal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DaneKontaktowe_Lokal");

                entity.HasOne(d => d.IdUzytkownikNavigation)
                    .WithMany(p => p.DaneKontaktowe)
                    .HasForeignKey(d => d.IdUzytkownik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DaneKontaktowe_Uzytkownik");
            });

            modelBuilder.Entity<Dostawa>(entity =>
            {
                entity.HasKey(e => e.IdDostawa)
                    .HasName("Dostawa_pk");

                entity.Property(e => e.IdDostawa).ValueGeneratedNever();

                entity.Property(e => e.Cena).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.Rodzaj)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PK__EMP__14CCF2EE577E0493");

                entity.ToTable("EMP");

                entity.Property(e => e.Empno)
                    .HasColumnName("EMPNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasColumnName("ENAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hiredate)
                    .HasColumnName("HIREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<Lokal>(entity =>
            {
                entity.HasKey(e => e.IdLokal)
                    .HasName("Lokal_pk");

                entity.Property(e => e.IdLokal).ValueGeneratedNever();
            });

            modelBuilder.Entity<Platnosc>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosc)
                    .HasName("Platnosc_pk");

                entity.Property(e => e.IdPlatnosc).ValueGeneratedNever();

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RodzajPlatnosci)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Produkt>(entity =>
            {
                entity.HasKey(e => e.IdProdukt)
                    .HasName("Produkt_pk");

                entity.Property(e => e.IdProdukt).ValueGeneratedNever();

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocjaNavigation)
                    .WithMany(p => p.Produkt)
                    .HasForeignKey(d => d.IdPromocja)
                    .HasConstraintName("Produkt_Promocja");

                entity.HasOne(d => d.IdRodzajProduktuNavigation)
                    .WithMany(p => p.Produkt)
                    .HasForeignKey(d => d.IdRodzajProduktu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Produkt_RodzajProduktu");

                entity.HasOne(d => d.IdRozmiarProduktuNavigation)
                    .WithMany(p => p.Produkt)
                    .HasForeignKey(d => d.IdRozmiarProduktu)
                    .HasConstraintName("Produkt_RozmiarProduktu");
            });

            modelBuilder.Entity<ProduktSkladnik>(entity =>
            {
                entity.HasKey(e => new { e.IdProduktSkladnik, e.IdProdukt, e.IdSkladnik })
                    .HasName("ProduktSkladnik_pk");

                entity.HasOne(d => d.IdProduktNavigation)
                    .WithMany(p => p.ProduktSkladnik)
                    .HasForeignKey(d => d.IdProdukt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProduktSkladnik_Produkt");

                entity.HasOne(d => d.IdSkladnikNavigation)
                    .WithMany(p => p.ProduktSkladnik)
                    .HasForeignKey(d => d.IdSkladnik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProduktSkladnik_Skladnik");
            });

            modelBuilder.Entity<Promocja>(entity =>
            {
                entity.HasKey(e => e.IdPromocja)
                    .HasName("Promocja_pk");

                entity.Property(e => e.IdPromocja).ValueGeneratedNever();

                entity.Property(e => e.Koniec).HasColumnType("date");

                entity.Property(e => e.Start).HasColumnType("date");
            });

            modelBuilder.Entity<RodzajProduktu>(entity =>
            {
                entity.HasKey(e => e.IdRodzajProduktu)
                    .HasName("RodzajProduktu_pk");

                entity.Property(e => e.IdRodzajProduktu).ValueGeneratedNever();

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RozmiarProduktu>(entity =>
            {
                entity.HasKey(e => e.IdRozmiarProduktu)
                    .HasName("RozmiarProduktu_pk");

                entity.Property(e => e.IdRozmiarProduktu).ValueGeneratedNever();

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skladnik>(entity =>
            {
                entity.HasKey(e => e.IdSkladnik)
                    .HasName("Skladnik_pk");

                entity.Property(e => e.IdSkladnik).ValueGeneratedNever();

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Wartosc).HasColumnType("decimal(3, 2)");
            });

            modelBuilder.Entity<SkladnikDodatkowy>(entity =>
            {
                entity.HasKey(e => e.IdSkladnikDodatkowy)
                    .HasName("SkladnikDodatkowy_pk");

                entity.Property(e => e.IdSkladnikDodatkowy).ValueGeneratedNever();

                entity.Property(e => e.SkladnikIdSkladnik).HasColumnName("Skladnik_IdSkladnik");

                entity.HasOne(d => d.SkladnikIdSkladnikNavigation)
                    .WithMany(p => p.SkladnikDodatkowy)
                    .HasForeignKey(d => d.SkladnikIdSkladnik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SkladnikDodatkowy_Skladnik");
            });

            modelBuilder.Entity<Uzytkownik>(entity =>
            {
                entity.HasKey(e => e.IdUzytkownik)
                    .HasName("Uzytkownik_pk");

                entity.Property(e => e.IdUzytkownik).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Haslo)
                    .IsRequired()
                    .HasColumnName("haslo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zamowienie>(entity =>
            {
                entity.HasKey(e => e.IdZamowienie)
                    .HasName("Zamowienie_pk");

                entity.Property(e => e.IdZamowienie).ValueGeneratedNever();

                entity.Property(e => e.Cena).HasColumnType("decimal(4, 2)");

                entity.HasOne(d => d.IdDostawaNavigation)
                    .WithMany(p => p.Zamowienie)
                    .HasForeignKey(d => d.IdDostawa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienie_Dostawa");

                entity.HasOne(d => d.IdLokalNavigation)
                    .WithMany(p => p.Zamowienie)
                    .HasForeignKey(d => d.IdLokal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienie_Lokal");

                entity.HasOne(d => d.IdPlatnoscNavigation)
                    .WithMany(p => p.Zamowienie)
                    .HasForeignKey(d => d.IdPlatnosc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienie_Platnosc");

                entity.HasOne(d => d.IdProduktNavigation)
                    .WithMany(p => p.Zamowienie)
                    .HasForeignKey(d => d.IdProdukt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienie_Produkt");

                entity.HasOne(d => d.IdUzytkownikNavigation)
                    .WithMany(p => p.Zamowienie)
                    .HasForeignKey(d => d.IdUzytkownik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienie_Uzytkownik");
            });

            modelBuilder.Entity<ZamowienieSkladnikDodatkowy>(entity =>
            {
                entity.HasKey(e => e.IdZamowienieSkladnikDodatkowy)
                    .HasName("ZamowienieSkladnikDodatkowy_pk");

                entity.Property(e => e.IdZamowienieSkladnikDodatkowy).ValueGeneratedNever();

                entity.Property(e => e.SkladnikDodatkowyIdSkladnikDodatkowy).HasColumnName("SkladnikDodatkowy_IdSkladnikDodatkowy");

                entity.Property(e => e.ZamowienieIdZamowienie).HasColumnName("Zamowienie_IdZamowienie");

                entity.HasOne(d => d.SkladnikDodatkowyIdSkladnikDodatkowyNavigation)
                    .WithMany(p => p.ZamowienieSkladnikDodatkowy)
                    .HasForeignKey(d => d.SkladnikDodatkowyIdSkladnikDodatkowy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ZamowienieSkladnikDodatkowy_SkladnikDodatkowy");

                entity.HasOne(d => d.ZamowienieIdZamowienieNavigation)
                    .WithMany(p => p.ZamowienieSkladnikDodatkowy)
                    .HasForeignKey(d => d.ZamowienieIdZamowienie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ZamowienieSkladnikDodatkowy_Zamowienie");
            });
        }
    }
}
