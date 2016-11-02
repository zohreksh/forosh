using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class TbProductMap : EntityTypeConfiguration<TbProduct>
    {
        public TbProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Des)
                .IsRequired();

            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Barcode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TbProducts");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Des).HasColumnName("Des");
            this.Property(t => t.Tag).HasColumnName("Tag");
            this.Property(t => t.Unit_id).HasColumnName("Unit_id");
            this.Property(t => t.Group_id).HasColumnName("Group_id");
            this.Property(t => t.Barcode).HasColumnName("Barcode");

            // Relationships
            this.HasRequired(t => t.TbGroup)
                .WithMany(t => t.TbProducts)
                .HasForeignKey(d => d.Group_id);
            this.HasRequired(t => t.TbUnit)
                .WithMany(t => t.TbProducts)
                .HasForeignKey(d => d.Unit_id);

        }
    }
}
