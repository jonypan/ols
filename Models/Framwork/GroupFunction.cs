namespace Models.Framwork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cms.GroupFunctions")]
    public partial class GroupFunction
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FunctionID { get; set; }

        public DateTime CreateDate { get; set; }

        public bool? IsInsert { get; set; }

        public bool? IsUpdate { get; set; }

        public bool? IsDelete { get; set; }
    }
}
