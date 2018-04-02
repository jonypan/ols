namespace Models.Framwork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cms.Users")]
    public partial class User
    {
        public int UserID { get; set; }

        public int? GroupID { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(30)]
        public string FullName { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? IsActive { get; set; }
    }
}
