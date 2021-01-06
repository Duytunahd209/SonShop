using SonShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SonShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public string ProductID { set; get; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

    }
}
