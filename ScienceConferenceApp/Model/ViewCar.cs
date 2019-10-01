namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViewCar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carId { get; set; }

        public int? price { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string company { get; set; }

        [StringLength(30)]
        public string model { get; set; }

        [StringLength(100)]
        public string engine { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int power { get; set; }

        [StringLength(25)]
        public string type { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string manualTrans { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int engineId { get; set; }

        [StringLength(1)]
        public string autoTrans { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int transmissionId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int manualTransId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int typeId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int manufacturerId { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string colourName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int colourId { get; set; }
    }
}
