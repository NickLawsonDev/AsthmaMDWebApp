﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AsthmaMDWebApp.Data
{
    public class ChildEntity
    {
        [Key]
        public int ChildId { get; set; }

        [Display(Name = "Child Name")]
        public string ChildName { get; set; }

        [Display(Name = "Child Age")]
        public int ChildAge { get; set; }

        [Display(Name = "Child Height")]
        public float ChildHeight { get; set; }

        [Display(Name = "Peak Flow Meter")]
        public int PeakFlowMeter { get; set; }

        [Display(Name = "FEV-1")]
        public float FEV1 { get; set; }

        public GenderType Gender { get; set; }

        public enum GenderType
        {
            Male = 1,
            Female = 2,
            Other = 3
        }
    }
}