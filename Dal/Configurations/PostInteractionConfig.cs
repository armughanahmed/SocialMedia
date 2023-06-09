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

    /// <summary>
    /// Post Interactions Configurations
    /// </summary>
    internal class PostInteractionConfig : IEntityTypeConfiguration<PostInteraction>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<PostInteraction> builder)
        {
            builder.HasKey(x => x.InteractionId);
        }
    }
}
