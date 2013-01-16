using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GUSGives.Generators;
using GUSGives.Entities;

namespace GUSGives
{
    public class MemberGenerator
    {
        private readonly Random _rand = new Random();

        public IEnumerable<Member> Generate(int numberOfMembers)
        {
            NameGenerator names = new NameGenerator(_rand);
            names.Load(@"Data\names_last.txt", @"Data\names_female.txt", @"Data\names_male.txt");

            GenderGenerator genders = new GenderGenerator(_rand);
            AgeGenerator ages = new AgeGenerator(_rand);
            AddressGenerator addresses = new AddressGenerator(_rand);
            addresses.Load(@"Data\au_streets.txt", @"Data\au_suburbs.txt", @"Data\gb_streets.txt", @"Data\gb_suburbs.txt", @"Data\nz_streets.txt", @"Data\nz_suburbs.txt");

            EmailGenerator emails = new EmailGenerator(_rand);
            HashSet<string> allEmails = new HashSet<string>();

            HomePhoneGenerator homePhones = new HomePhoneGenerator(_rand);
            HashSet<string> allHomePhones = new HashSet<string>();

            MobilePhoneGenerator mobilePhones = new MobilePhoneGenerator(_rand);
            HashSet<string> allMobilePhones = new HashSet<string>();

            MembershipStatusGenerator membershipStatuses = new MembershipStatusGenerator(_rand);
            IncomeGenerator incomes = new IncomeGenerator(_rand);

            HouseholdGenerator households = new HouseholdGenerator(_rand);
            AdultGenerator adults = new AdultGenerator(_rand);

            PropertyGenerator properties = new PropertyGenerator(_rand);

            ElectronicsGenerator electronics = new ElectronicsGenerator(_rand);

            List<Member> members = new List<Member>();
            for (int i = 0; i < numberOfMembers; i++)
            {
                Member member = new Member();
                member.Gender = genders.GetGender();
                member.LastName = names.GetLastName();
                if (member.Gender == Gender.Female)
                    member.FirstName = names.GetFemaleName();
                else
                    member.FirstName = names.GetMaleName();

                member.Age = ages.GetAge(member.Gender);
                member.Address = addresses.GetAddress(member.Age);
                member.Email = emails.GetEmail(member.FirstName, member.LastName, member.Address.Country, allEmails);
                allEmails.Add(member.Email);

                member.HomePhone = homePhones.GetNumber(member.Address.Country, member.Address.State, allHomePhones);
                allHomePhones.Add(member.HomePhone);

                member.MobilePhone = mobilePhones.GetNumber(member.Address.Country, allMobilePhones);
                allMobilePhones.Add(member.MobilePhone);

                member.MembershipStatus = membershipStatuses.GetMembershipStatus();
                if (member.MembershipStatus == MembershipStatus.Paying)
                    member.OptionalExtras = membershipStatuses.GetOptionalExtras();

                member.Income = incomes.GetIncome();
                member.Household = households.GetHousehold(member.Age);

                member.AdultMembers = adults.GetAdultMembers(member.Age, member.Household);

                member.PropertyOwner = properties.IsPropertyOwner();
                member.Property = properties.GetProperty(member.PropertyOwner);

                member.ElectronicPurchases = electronics.IsElectronicPurchaser();
                member.Electronics = electronics.GetElectronics(member.ElectronicPurchases);

                members.Add(member);
            }
            return members;
        }
    }
}
