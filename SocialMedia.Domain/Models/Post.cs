namespace SocialMedia.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Post Domain Model
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Gets Or Sets Id of Post
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets Or Sets Text of Post
        /// </summary>
        public string Text { get; set; } = string.Empty;
    }
}
