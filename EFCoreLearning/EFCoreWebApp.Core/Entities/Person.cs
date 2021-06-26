using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static EFCoreWebApp.Core.Helpers.Constants;

namespace EFCoreWebApp.Core.Entities
{
    [Table("Persons", Schema = coreSchemaName)]
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
