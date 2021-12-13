using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("sinhvien")]
    public class sinhvien
    {
        [Key]
        public int MaSV { get; set; }
        public string  TenSV { get; set; }
        [DataType(DataType.Date)]
        public DateTime namsinh { get; set; }

    }
}