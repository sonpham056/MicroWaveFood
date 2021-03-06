using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MicroWaveFood.Models
{
    public class Comment
    {
        [Key]
        [Column(Order = 1)]
        public int CommentId { get; set; }
        public int BillId { get; set; }
        public string UserId { get; set; }
        [StringLength(1000, ErrorMessage = "Bình luận chỉ được tối đa 1000 ký tự!")]
        [Required]
        public string UserComment { get; set; }
        [Required]
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }
        public ApplicationUser User { get; set; }

        public virtual Bill Bill { get; set; }
    }
}