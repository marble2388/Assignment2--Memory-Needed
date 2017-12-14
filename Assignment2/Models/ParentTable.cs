namespace Assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParentTable")]
    public partial class ParentTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        [StringLength(10)]
        public string otherthing1 { get; set; }

        [StringLength(10)]
        public string otherthing2 { get; set; }

        [StringLength(10)]
        public string otherthing3 { get; set; }
    }
}
