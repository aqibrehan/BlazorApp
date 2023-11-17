using DataModel.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.DataContext;

    public partial class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AmazonShippingOrderlist> AmazonShippingOrderlists { get; set; } = null!;
    public virtual DbSet<Employee> Employees { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Server=NL-DT-AQIB;Database=WebApiTuto;Trusted_connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AmazonShippingOrderlist>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("amazonShipping_orderlist");

            entity.Property(e => e.Dimension)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LabelWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label_weight");

            entity.Property(e => e.Orderno)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Ponumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Qty)
                .HasMaxLength(50)
                .IsUnicode(false);
        });


    }
 
}

