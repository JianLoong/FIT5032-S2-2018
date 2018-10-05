namespace FIT5032_Week05E.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class Comment
    {
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Contents { get; set; }
    }
}
