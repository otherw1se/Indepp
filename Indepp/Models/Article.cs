﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indepp.Models
{
    public class Article
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [AllowHtml]
        public string ShortDescription { get; set; }

        [Required]
        [AllowHtml]
        public string Description { get; set; }

        public DateTime PostedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public int? PlaceID { get; set; }
        public virtual Place Place { get; set; }
    }
}