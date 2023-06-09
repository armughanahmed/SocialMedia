namespace SocialMedia.Dal.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SocialMedia.Domain.Aggregates.PostAggregate;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// User Profile Basic Info Configurations
    /// </summary>
    internal class BasicInfoConfig : IEntityTypeConfiguration<BasicInfo>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<BasicInfo> builder)
        {
            // Intentionally Left Empty
        }
    }
}
