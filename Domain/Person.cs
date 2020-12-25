using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Person : BaseEntity
    {
        [MaxLength(64)] [MinLength(2)] public string FirstName { get; set; } = default!;
        [MaxLength(64)] [MinLength(1)] public string LastName { get; set; } = default!;

        public List<Contact> Contacts { get; set; }

        public string FirstLastName => FirstName + " " + LastName;
        public string LastFirstName => LastName + " " + FirstName;
    }
}