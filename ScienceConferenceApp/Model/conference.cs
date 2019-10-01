namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class conference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public conference()
        {
            participants = new HashSet<participant>();
        }

        public int conferenceId { get; set; }

        [Required]
        [StringLength(100)]
        public string conferenceName { get; set; }

        public int? address { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public virtual address address1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participant> participants { get; set; }
    }
}
