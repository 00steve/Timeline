namespace TimelineApp.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timeline.EventReference")]
    public partial class EventReference
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EventID { get; set; }

        [Required]
        [StringLength(2000)]
        public string URL { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SourceDate { get; set; }

        public byte StatusID { get; set; }

        public byte MediaTypeID { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public virtual Event Event { get; set; }

        public virtual MediaType MediaType { get; set; }

        public virtual Status Status { get; set; }
    }
}
