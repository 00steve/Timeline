namespace TimelineApp.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timeline.TimelineTag")]
    public partial class TimelineTag
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal TimelineID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal TagID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        public virtual Tag Tag { get; set; }

        public virtual Timeline Timeline { get; set; }
    }
}
