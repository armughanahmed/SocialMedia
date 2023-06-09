namespace SocialMedia.Dal.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Identity User Configurations
    /// </summary>
    internal class IdentityUserLoginConfig : IEntityTypeConfiguration<IdentityUserLogin<string>>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
        {
            builder.HasKey(x => x.UserId);
        }
    }
}
