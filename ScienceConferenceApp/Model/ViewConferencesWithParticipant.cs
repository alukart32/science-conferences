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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int participantId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subjectId { get; set; }

        [StringLength(50)]
        public string subject { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int themeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string themeName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int scientistId { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string secondName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int degreeId { get; set; }

        [StringLength(5)]
        public string degree { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int companyId { get; set; }

        [StringLength(50)]
        public string companyName { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string conferenceName { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int conferenceId { get; set; }

        [StringLength(1)]
        public string publication { get; set; }
    }
}
