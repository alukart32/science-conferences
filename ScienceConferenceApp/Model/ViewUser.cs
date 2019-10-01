namespace ScienceConferenceApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewUser")]
    public partial class ViewUser
    {
        [StringLength(10)]
        public string role { get; set; }

        [StringLength(30)]
        public string firstName { get; set; }

        [StringLength(30)]
        public string secondName { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roleId { get; set; }

        [StringLength(30)]
        public string status { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int statusId { get; set; }
    }
}
