using GigHubChMask2011.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace GigHubChMask2011.Persistence.EntityConfigurations
{
    public class GigConfiguration : EntityTypeConfiguration<Gig>//βάλαμε μια γραμμη στο applicationdbcontext στο fluent api.
    {
        public GigConfiguration()
        {//πρώτα τα pk,fk και μετά τα properties αλφαβητικά.
            Property(g => g.ArtistId)
            .IsRequired();

            Property(g => g.GenreId)
            .IsRequired();

            Property(g => g.Venue)
            .IsRequired()
            .HasMaxLength(255);

            HasMany(g => g.Attendances)
                .WithRequired(a => a.Gig)
                .WillCascadeOnDelete(false);
        }
    }
}