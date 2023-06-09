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
    /// User Profile Configurations
    /// </summary>
    internal class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.OwnsOne(x => x.BasicInfo);
        }
    }
}
