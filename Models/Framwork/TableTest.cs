namespace Models.Framwork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableTest")]
    public partial class TableTest
    {
        [Key]
        public int TestID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
