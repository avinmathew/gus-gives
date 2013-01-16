using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;
using GUSGives.Entities;

namespace GUSGives
{
    public class Program
    {
        private static readonly int NUMBER_OF_MEMBERS = 50000;

        public static void Main(string[] args)
        {
            MemberGenerator generator = new MemberGenerator();
            var members = generator.Generate(NUMBER_OF_MEMBERS);

            using (TextWriter writer = File.CreateText("members.csv"))
            {
                writer.WriteLine("\"" + string.Join("\",\"",
                    "First Name",
                    "Last Name",
                    "Gender",
                    "Age",
                    "Unit",
                    "Number",
                    "Street",
                    "Suburb",
                    "State",
                    "Post Code",
                    "Country",
                    "Email",
                    "Home Phone",
                    "Mobile Phone",
                    "Membership Status",
                    "Optional Extras",
                    "Income",
                    "Number Of Adults",
                    "Number Of Teenagers",
                    "Number Of Children",
                    "Number Of Babies",
                    "Adults Working Full Time",
                    "Adults Working Part Time",
                    "Adults Retired",
                    "Adults Unemployed",
                    "Adult Students",
                    "Property Owner",
                    "Property Upgrades",
                    "Upgrade Kitchen",
                    "Upgrade Bathroom",
                    "Upgrade Bedroom",
                    "Upgrade Living Room",
                    "Upgrade Garden/Landscaping",
                    "Upgrade Pool",
                    "Purchase Electronics",
                    "Purchase Television",
                    "Purchase Home Theatre",
                    "Purchase Music System",
                    "Purchase Computer",
                    "Purchase Dishwasher",
                    "Purchase Fridge",
                    "Purchase Washing Machine",
                    "Purchase Vacuum Cleaner"
                    ) + "\"");
                foreach (Member member in members)
                {
                    writer.WriteLine("\"" + string.Join("\",\"",
                        member.FirstName,
                        member.LastName,
                        member.Gender,
                        member.Age.Name,
                        member.Address.Unit,
                        member.Address.Number,
                        member.Address.Street,
                        member.Address.Suburb,
                        member.Address.State,
                        member.Address.PostCode,
                        member.Address.Country,
                        member.Email,
                        member.HomePhone,
                        member.MobilePhone,
                        member.MembershipStatus,
                        member.OptionalExtras,
                        member.Income,
                        member.Household.NumberOfAdults,
                        member.Household.NumberOfTeenagers,
                        member.Household.NumberOfChildren,
                        member.Household.NumberOfBabies,
                        member.AdultMembers.WorkingFullTime,
                        member.AdultMembers.WorkingPartTime,
                        member.AdultMembers.Retired,
                        member.AdultMembers.Unemployed,
                        member.AdultMembers.Student,
                        member.PropertyOwner,
                        member.Property.Upgrades,
                        member.Property.UpgradeKitchen,
                        member.Property.UpgradeBathroom,
                        member.Property.UpgradeBedroom,
                        member.Property.UpgradeLivingRoom,
                        member.Property.UpgradeGarden,
                        member.Property.UpgradePool,
                        member.ElectronicPurchases,
                        member.Electronics.PurchaseTelevision,
                        member.Electronics.PurchaseHomeTheatre,
                        member.Electronics.PurchaseMusicSystem,
                        member.Electronics.PurchaseComputer,
                        member.Electronics.PurchaseDishwasher,
                        member.Electronics.PurchaseFridge,
                        member.Electronics.PurchaseWashingMachine,
                        member.Electronics.PurchaseVacuumCleaner
                        ) + "\"");
                }
            }
        }
    }
}
