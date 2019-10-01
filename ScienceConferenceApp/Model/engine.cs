namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class engine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public engine()
        {
            models = new HashSet<model>();
        }

        public int engineId { get; set; }

        [Column("engine")]
        [StringLength(100)]
        public string engine1 { get; set; }

        public int power { get; set; }

        public int? engineType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<model> models { get; set; }

        public virtual engineType engineType1 { get; set; }
    }
}
