using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class test
    {
        [Key]
        public int testID { get; set; }
        public string Name { get; set; }
    }
}
