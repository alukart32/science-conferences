namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            orders = new HashSet<order>();
        }

        public int userId { get; set; }

        [StringLength(30)]
        public string firstName { get; set; }

        [StringLength(30)]
        public string secondName { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        public int? sysRole { get; set; }

        public int? status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }

        public virtual role role { get; set; }

        public virtual status status1 { get; set; }
    }
}
