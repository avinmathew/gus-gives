using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Age Age { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public MembershipStatus MembershipStatus { get; set; }
        public OptionalExtras? OptionalExtras { get; set; }
        public string Income { get; set; }
        public Household Household { get; set; }
        public AdultMembers AdultMembers { get; set; }
        public bool PropertyOwner { get; set; }
        public Property Property { get; set; }
        public bool ElectronicPurchases { get; set; }
        public Electronics Electronics { get; set; }
    }
}
