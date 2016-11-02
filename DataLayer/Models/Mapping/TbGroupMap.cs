using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Models.Mapping
{
    public class TbGroupMap : EntityTypeConfiguration<TbGroup>
    {
        public TbGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Des)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("TbGroups");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Des).HasColumnName("Des");
            this.Property(t => t.Parent_id).HasColumnName("Parent_id");

            // Relationships
            this.HasRequired(t => t.TbGroup1)
                .WithMany(t => t.TbGroups1)
                .HasForeignKey(d => d.Parent_id);

        }
    }
}
