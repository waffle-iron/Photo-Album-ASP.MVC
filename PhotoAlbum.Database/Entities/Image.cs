using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoAlbum.Domain.Entities
{
    [Table("Image")]
    public class Image
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(10)]
        public string Expansion { get; set; }

        [Required]
        [StringLength(10)]
        public string Size { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}