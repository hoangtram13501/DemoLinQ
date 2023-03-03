using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Demo123.Models.Domain
{
    [Table("Job")]
    public class Job
        
    {
        public int id { get; set; }
        public string  jno { get; set; }
        public string jname { get; set; }
        public string city { get; set; }
    }

    //private var jobs = new List<Job>
    //{
    //    new Job{ id = 1,jno = "J1",jname = "Sorter", city = "Paris"},
    //    new Job{ id = 2,jno = "J2",jname = "Punch", city = "Rome"}
    //};
}
