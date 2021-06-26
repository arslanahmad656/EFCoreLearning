using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreWebApp.Core.Entities
{
    public class LookUp
    {
        [Key]
        public string Code { get; set; }

        public string Description { get; set; }

        public int LookUpType { get; set; }
    }
}
