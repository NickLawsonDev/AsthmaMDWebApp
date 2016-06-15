using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsthmaMDWebApp.Data
{
    public class UserProfile
    {
        [Key, ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

    }
}