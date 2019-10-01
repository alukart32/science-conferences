namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class orderDetail
    {
        public int orderDetailId { get; set; }

        public int order { get; set; }

        public int merchandise { get; set; }

        public int? amount { get; set; }

        [Required]
        [StringLength(1)]
        public string approved { get; set; }

        public int? total { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public virtual merchandise merchandise1 { get; set; }

        public virtual order order1 { get; set; }
    }
}
