﻿namespace SocialMedia.Dal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SocialMedia.Dal.Configurations;
    using SocialMedia.Domain.Aggregates.PostAggregate;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// Database Context Class
    /// </summary>
    public class SocialMediaContext : IdentityDbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaContext"/> class for using options.
        /// </summary>
        /// <param name="options">dbcontext options</param>
        public SocialMediaContext(DbContextOptions options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets UserProfile DbContext
        /// </summary>
        public DbSet<UserProfile>? UserProfiles { get; set; }

        /// <summary>
        /// Gets or sets Posts DbContext
        /// </summary>
        public DbSet<Post>? Posts { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PostCommentConfig());
            builder.ApplyConfiguration(new PostInteractionConfig());
            builder.ApplyConfiguration(new UserProfileConfig());
            builder.ApplyConfiguration(new IdentityUserLoginConfig());
            builder.ApplyConfiguration(new IdentityUserRoleConfig());
            builder.ApplyConfiguration(new IdentityUserTokenConfig());
        }
    }
}
