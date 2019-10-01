namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewTransmissionCar")]
    public partial class ViewTransmissionCar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int transmissionId { get; set; }

        [StringLength(1)]
        public string autoTrans { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int manualTransId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string manualTrans { get; set; }
    }
}
