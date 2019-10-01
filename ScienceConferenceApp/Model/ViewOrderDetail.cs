namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewOrderDetail")]
    public partial class ViewOrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int car { get; set; }

        public int? deliveryTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderDetailId { get; set; }

        public int? amount { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string approved { get; set; }

        public int? total { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }
    }
}
