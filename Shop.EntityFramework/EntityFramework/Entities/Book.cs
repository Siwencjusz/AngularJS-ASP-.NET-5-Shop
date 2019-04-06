using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.EntityFramework.Entities.Base;

namespace Shop.EntityFramework.Entities
{
    public class Book : BaseEntity
    {
      //  [ForeignKey("BookTypeId"), Required]
        public virtual BookType BookType { get; set; }

       // public int BookTypeId { get; set; }
        [Required]
        public string BookName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }

       // [ForeignKey("AuthorId"), Required]
        public virtual Author Author { get; set; }

     //   public int AuthorId { get; set; }
       // [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }

       // public int PublisherId { get; set; }
        public bool SuperOpportunity { get; set; }
    }
}
