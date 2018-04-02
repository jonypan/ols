namespace Models.Framwork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cms.LoginLog")]
    public partial class LoginLog
    {
        public long LoginLogID { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(30)]
        public string ClientIP { get; set; }

        public DateTime? LoginDate { get; set; }
    }
}
