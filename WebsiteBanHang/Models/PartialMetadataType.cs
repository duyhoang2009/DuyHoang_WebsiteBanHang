using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Context
{
    public class PartialMetadataType
    {
        [MetadataType(typeof(ProductMasterData))]
        public class Product
        {
            [NotMapped]
            public System.Web.HttpPostedFileBase ImageUpload { get; set; }
        }
}
    
}