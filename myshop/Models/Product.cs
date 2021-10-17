namespace myshop.Models
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_ID { get; set; }

        [StringLength(50)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(100)]
        public string PRODUCT_DESCRIPTION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRODUCT_PURCHASEPRICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRODUCT_SALEPRICE { get; set; }

        [StringLength(200)]
        public string PRODUCT_PICTURE { get; set; }

        [NotMapped]
        public HttpPostedFileBase PRO_PIC { get; set; }


        public int? CATEGORY_FID { get; set; }

        public virtual Category Category { get; set; }
    }
}
