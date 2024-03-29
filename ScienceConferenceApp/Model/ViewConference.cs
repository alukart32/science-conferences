namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViewConference
    {
        [StringLength(50)]
        public string code { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int addressId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int countryId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int conferenceId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string conferenceName { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime date { get; set; }

        [StringLength(50)]
        public string address { get; set; }
    }
}
