namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class transmission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transmission()
        {
            models = new HashSet<model>();
        }

        public int transmissionId { get; set; }

        [StringLength(1)]
        public string autoTrans { get; set; }

        public int manualTrans { get; set; }

        public virtual manualTransmission manualTransmission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<model> models { get; set; }
    }
}
