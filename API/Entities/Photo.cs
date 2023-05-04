using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public int Url { get; set; }
        public int IsMain { get; set; }
        public int PublicMain { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}