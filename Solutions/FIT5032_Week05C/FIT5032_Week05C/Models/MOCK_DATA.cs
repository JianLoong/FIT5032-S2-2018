namespace FIT5032_Week05C.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOCK_DATA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [DisplayName("First Name")]
        [StringLength(50)]
        public string first_name { get; set; }
        [DisplayName("Last Name")]
        [StringLength(50)]
        public string last_name { get; set; }
        [DisplayName("Email")]
        [StringLength(50)]
        public string email { get; set; }
        [DisplayName("Gender")]
        [StringLength(50)]
        public string gender { get; set; }
        [DisplayName("IP Address")]
        [StringLength(20)]
        public string ip_address { get; set; }
    }
}
