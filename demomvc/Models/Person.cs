using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace demomvc.Models
{
    [Table("Persons")]
    public class Person

    {
        internal object fullname;

        [Key]
    public string PersonID { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    }
}