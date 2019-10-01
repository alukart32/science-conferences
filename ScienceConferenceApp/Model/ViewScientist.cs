namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViewScientist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int scientistId { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string secondName { get; set; }

        [StringLength(5)]
        public string degree { get; set; }

        [StringLength(50)]
        public string institution { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int institutionId { get; set; }

        [StringLength(3)]
        public string scientistCountry { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int scientistCountryId { get; set; }

        [StringLength(50)]
        public string subject { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subjectId { get; set; }

        public int? conference { get; set; }

        [StringLength(50)]
        public string theme { get; set; }

        [StringLength(1)]
        public string publication { get; set; }
    }
}
