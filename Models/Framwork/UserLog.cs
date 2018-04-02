namespace Models.Framwork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cms.UserLogs")]
    public partial class UserLog
    {
        [Key]
        public int LogID { get; set; }

        public int UserID { get; set; }

        public int ExeType { get; set; }

        public int? FunctionID { get; set; }

        public DateTime LogTime { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}
