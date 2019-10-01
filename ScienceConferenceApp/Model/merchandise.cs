namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class merchandise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public merchandise()
        {
            orderDetails = new HashSet<orderDetail>();
        }

        public int merchandiseId { get; set; }

        public int car { get; set; }

        public int? rest { get; set; }

        public int? deliveryTime { get; set; }

        public int orderDetail { get; set; }

        public virtual car car1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderDetail> orderDetails { get; set; }
    }
}
