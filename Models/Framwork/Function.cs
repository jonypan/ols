namespace Models.Framwork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cms.Functions")]
    public partial class Function
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FunctionID { get; set; }

        [Required]
        [StringLength(150)]
        public string FunctionName { get; set; }

        [Required]
        [StringLength(100)]
        public string Url { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedTime { get; set; }

        public int? FatherID { get; set; }

        public int? Order { get; set; }
    }
}
