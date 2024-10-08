using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Dateren.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Alder { get; set; }
 


    }
}
