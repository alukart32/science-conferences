namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public model()
        {
            cars = new HashSet<car>();
        }

        public int modelId { get; set; }

        public int? type { get; set; }

        [Column("model")]
        [StringLength(30)]
        public string model1 { get; set; }

        public int? manufacturer { get; set; }

        public int? engine { get; set; }

        public int? transmission { get; set; }

        public int? colour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<car> cars { get; set; }

        public virtual carType carType { get; set; }

        public virtual colour colour1 { get; set; }

        public virtual engine engine1 { get; set; }

        public virtual manufacturer manufacturer1 { get; set; }

        public virtual transmission transmission1 { get; set; }
    }
}
