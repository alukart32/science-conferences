namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class participant
    {
        public int participantId { get; set; }

        public int subject { get; set; }

        public int scientist { get; set; }

        public int conference { get; set; }

        [StringLength(1)]
        public string publication { get; set; }

        public int? theme { get; set; }

        public virtual conference conference1 { get; set; }

        public virtual scientist scientist1 { get; set; }

        public virtual subject subject1 { get; set; }

        public virtual theme theme1 { get; set; }
    }
}
