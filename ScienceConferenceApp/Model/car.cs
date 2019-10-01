namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public car()
        {
            merchandises = new HashSet<merchandise>();
        }

        public int carId { get; set; }

        public int manufacturer { get; set; }

        public int? price { get; set; }

        public int? model { get; set; }

        public virtual manufacturer manufacturer1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<merchandise> merchandises { get; set; }

        public virtual model model1 { get; set; }
    }
}
