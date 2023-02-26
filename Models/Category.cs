using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Models
{
    public class Category
    {
        [Key] //entity frmwrk
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100 only!!")]
        public string DisplayOrder { get; set; }
        public string CreatedDateTime { get; set; } = DateTime.Now.ToString();

    }
}
