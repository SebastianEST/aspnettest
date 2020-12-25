using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ContactType : BaseEntity
    {
        [MaxLength(64)] [MinLength(2)] public string ContactTypeValue { get; set; } = default!;

        public List<Contact> Contacts { get; set; }
    }
}