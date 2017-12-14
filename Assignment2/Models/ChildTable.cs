namespace Assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChildTable")]
    public partial class ChildTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }


        public int PID { get; set; }
        [Required]
        [StringLength(10)]
        public string thing1 { get; set; }

        [StringLength(10)]
        public string thing2 { get; set; }
    }
}
