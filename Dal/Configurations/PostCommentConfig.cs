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
    /// Post Comments Configurations
    /// </summary>
    internal class PostCommentConfig : IEntityTypeConfiguration<PostComment>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            builder.HasKey(x => x.CommentId);
        }
    }
}
