namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewManufacturerCar")]
    public partial class ViewManufacturerCar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int manufacturerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string company { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int modelId { get; set; }

        [StringLength(30)]
        public string model { get; set; }

        public int? type { get; set; }

        public int? engine { get; set; }

        public int? transmission { get; set; }

        public int? colour { get; set; }
    }
}
