using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class TbUnitMap : EntityTypeConfiguration<TbUnit>
    {
        public TbUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Des)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("TbUnits");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Des).HasColumnName("Des");
        }
    }
}
