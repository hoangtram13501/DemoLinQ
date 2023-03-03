using System.ComponentModel.DataAnnotations.Schema;

namespace Demo123.Models.Domain
{
    [Table ("Supplier")]
    public class Supplier
    {
       
        public int id { get; set; }
        public string sno { get; set; }
        public string sname { get; set;}
        public int status { get; set; }
        public string city{ get; set;}
    }
}
