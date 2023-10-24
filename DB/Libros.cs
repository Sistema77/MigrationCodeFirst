using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Libros
    {
        [Key] // Para que el idLibro sea el Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key AutoCompetable
        public int idLibro { get; set; }
        public string name { get; set; }
    }
}
