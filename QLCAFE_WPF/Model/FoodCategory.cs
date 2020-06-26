namespace QLCAFE_WPF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodCategory")]
    public partial class FoodCategory
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }
    }
}
