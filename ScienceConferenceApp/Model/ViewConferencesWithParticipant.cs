namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViewConferencesWithParticipant
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string conferenceName { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime date { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string subject { get; set; }

        [StringLength(1)]
        public string publication { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int scientist { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subjectId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int countryId { get; set; }

        [StringLength(3)]
        public string conferenceCountry { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int conferenceId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int themeId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string themeName { get; set; }
    }
}
