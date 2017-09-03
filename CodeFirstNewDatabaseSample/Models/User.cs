using System.ComponentModel.DataAnnotations;

namespace CodeFirstNewDatabaseSample.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }
}
