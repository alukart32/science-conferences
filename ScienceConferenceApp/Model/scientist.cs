namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class scientist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public scientist()
        {
            participants = new HashSet<participant>();
        }

        public int scientistId { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string secondName { get; set; }

        public int? academicDegree { get; set; }

        public int? company { get; set; }

        public int? country { get; set; }

        public virtual academicDegree academicDegree1 { get; set; }

        public virtual company company1 { get; set; }

        public virtual country country1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participant> participants { get; set; }
    }
}
