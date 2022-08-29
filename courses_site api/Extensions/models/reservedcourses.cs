using System.ComponentModel.DataAnnotations;

namespace courses_site_api.Extensions.models
{
    public class reservedcourse
    {
        public int id { set; get; }
        [Required]
        public string email { set; get; }
        [Required]
        public string username { set; get; }
        [Required]
        public int courseid { set; get; }
        [Required]
        public string name { set; get; }
        [Required]
        public double finalprice { set; get; }
    }
}
