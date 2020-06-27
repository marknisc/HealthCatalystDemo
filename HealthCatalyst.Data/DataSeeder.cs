using HealthCatalyst.Models;

using System;
using System.Collections.Generic;

namespace HealthCatalyst.Data
{
    /// <summary>
    /// Internal class to generate seed data
    /// </summary>
    internal class DataSeeder
    {
        /// <summary>
        /// Generate list of Persons
        /// </summary>
        /// <returns>List{Person}</returns>
        public static List<Person> GeneratePersons()
        {
            List<Person> persons = new List<Person>();

            for (int x = 1; x < 11; x++)
            {
                persons.Add(new Person()
                {
                    PersonId = x,
                    GivenName = GetRandomGivenName(),
                    Surname = GetRandomSurname(),
                    Photo = null
                });
            }

            return persons;
        }

        /// <summary>
        /// Generate phones
        /// </summary>
        /// <returns>List{Phone}</returns>
        public static List<Phone> GeneratePhones(List<Person> persons)
        {
            List<Phone> phones = new List<Phone>();

            int id = 1;
            // Create two phones for each person
            persons.ForEach(p =>
            {
                phones.Add(new Phone() { PhoneId = id++, PersonId = p.PersonId, Number = CreateRandonPhoneNumber(), Type = PhoneType.Home });
                phones.Add(new Phone() { PhoneId = id++, PersonId = p.PersonId, Number = CreateRandonPhoneNumber(), Type = PhoneType.Mobile });
            });

            return phones;
        }

        /// <summary>
        /// Generate addresses
        /// </summary>
        /// <returns>List{Address}</returns>
        public static List<Address> GenerateAddresses(List<Person> persons)
        {
            List<Address> addresses = new List<Address>();

            int id = 1;

            persons.ForEach(p =>
            {
                addresses.Add(new Address()
                {
                    AddressId = id++,
                    EntityId = p.PersonId,
                    Line1 = GetRandomAddress(),
                    City = GetRandomCity(),
                    State = GetRandomState(),
                    PostalCode = CreateRandomPostalCode()
                });
            });

            return addresses;
        }

        /// <summary>
        /// Generate interests
        /// </summary>
        /// <returns>List{Interest}</returns>
        public static List<Interest> GenerateInterests(List<Person> persons)
        {
            List<Interest> interests = new List<Interest>();

            int id = 1;

            persons.ForEach(p =>
            {
                interests.Add(new Interest()
                {
                    InterestId = id++,
                    PersonId = p.PersonId,
                    Description = GetRandomInterest()
                });

                interests.Add(new Interest()
                {
                    InterestId = id++,
                    PersonId = p.PersonId,
                    Description = GetRandomInterest()
                });

                interests.Add(new Interest()
                {
                    InterestId = id++,
                    PersonId = p.PersonId,
                    Description = GetRandomInterest()
                });
            });

            return interests;
        }

        #region Private Methods

        /// <summary>
        /// Get a random name for data seeding
        /// </summary>
        /// <returns>Random given name</returns>
        private static string GetRandomGivenName()
        {
            List<string> names = new List<string>()
            {
                "Francois",
                "Claudine",
                "Chic",
                "Shane",
                "Goober",
                "Anni",
                "Elvis",
                "Mikaela",
                "Bordie",
                "Karlene",
                "Trenton",
                "Benoite",
                "Monroe",
                "Tallulah",
                "Bron",
                "Shirl",
                "Hakeem",
                "Maible",
                "Gorden",
                "Odetta"
            };

            Random rnd = new Random();
            int idx = rnd.Next(0, names.Count - 1);

            return names[idx];
        }

        /// <summary>
        /// Get a random name for data seeding
        /// </summary>
        /// <returns>Random surname</returns>
        private static string GetRandomSurname()
        {
            List<string> names = new List<string>()
            {
                "Georgi",
                "Bruno",
                "Whitesides",
                "Orr",
                "Houston",
                "Anand-apte",
                "Henneman",
                "Reese",
                "Maynadier",
                "Schifini",
                "Tohen",
                "Cordova",
                "Rutan",
                "Parks",
                "Siegfriedt",
                "Luoma",
                "Matarazzo",
                "Croshaw",
                "Ritzau",
                "Britton"
            };

            Random rnd = new Random();
            int idx = rnd.Next(0, names.Count - 1);

            return names[idx];
        }

        /// <summary>
        /// Generate random 10 digit number
        /// </summary>
        /// <returns>Random phone number</returns>
        private static long CreateRandonPhoneNumber()
        {
            Random rnd = new Random();

            List<int> numbers = new List<int>();

            while (numbers.Count < 10)
            {
                numbers.Add(rnd.Next(0, 9));
            }

            long number = 0;

            numbers.ForEach(n => { number = 10 * number + n; });

            return number;
        }

        /// <summary>
        /// Return random state
        /// </summary>
        /// <returns>State abbr</returns>
        private static string GetRandomState()
        {
            List<string> states = new List<string>()
            {
                "AL",
                "AK",
                "AZ",
                "AR",
                "CA",
                "CO",
                "CT",
                "DE",
                "DC",
                "FL",
                "GA",
                "HI",
                "ID",
                "IL",
                "IN",
                "IA",
                "KS",
                "KY",
                "LA",
                "ME",
                "MD",
                "MA",
                "MI",
                "MN",
                "MS",
                "MO",
                "MT",
                "NE",
                "NV",
                "NH",
                "NJ",
                "NM",
                "NY",
                "NC",
                "ND",
                "OH",
                "OK",
                "OR",
                "PA",
                "RI",
                "SC",
                "SD",
                "TN",
                "TX",
                "UT",
                "VT",
                "VA",
                "WA",
                "WV",
                "WI",
                "WY"
            };

            Random rnd = new Random();
            return states[rnd.Next(0, states.Count - 1)];
        }

        /// <summary>
        /// Return random address line
        /// </summary>
        /// <returns>Address line1</returns>
        private static string GetRandomAddress()
        {
            List<string> addr = new List<string>()
            {
                "226 Pinehurst Ave",
                "816 Nixon Dr",
                "7935 Sherry Creek Rd",
                "609 S Level St",
                "700 Salem St #312",
                "1169 E 4020th S #APT A",
                "1790 Woodbine Way #1723",
                "130 Harris School Rd",
                "1111 N Walnut Grove Rd",
                "806 Behl Rd",
            };

            Random rnd = new Random();

            return addr[rnd.Next(0, addr.Count - 1)];
        }

        /// <summary>
        /// Return random city name
        /// </summary>
        /// <returns>City name</returns>
        private static string GetRandomCity()
        {
            List<string> cities = new List<string>()
            {
                "Berna",
                "Quebec",
                "Bellevue",
                "Jersey City",
                "Atlanta",
                "Oklahoma City",
                "Sacramento",
                "Scottsdale",
                "Hollywood",
                "San Diego",
                "Indianapolis",
                "Louisville",
                "Jacksonville",
                "Tallahassee",
                "Henderson",
                "Amarillo",
                "Madison",
                "London",
                "Memphis",
                "Chicago"
            };

            Random rnd = new Random();

            return cities[rnd.Next(0, cities.Count - 1)];
        }

        /// <summary>
        /// Generate random enhanced postal code
        /// </summary>
        /// <returns>Postal code</returns>
        private static string CreateRandomPostalCode()
        {
            Random rnd = new Random();

            List<int> numbers = new List<int>();

            while (numbers.Count < 5)
            {
                numbers.Add(rnd.Next(0, 9));
            }

            int part1 = 0;

            numbers.ForEach(n => { part1 = 10 * part1 + n; });

            numbers = new List<int>();
            while (numbers.Count < 4)
            {
                numbers.Add(rnd.Next(0, 9));
            }

            int part2 = 0;

            numbers.ForEach(n => { part2 = 10 * part2 + n; });

            return $"{part1}-{part2}";
        }


        /// <summary>
        /// Return random interest
        /// </summary>
        /// <returns>Interest</returns>
        private static string GetRandomInterest()
        {
            List<string> interests = new List<string>()
            {
                "Trigonometry",
                "Physical Education",
                "Speech",
                "Mathematics",
                "Physics",
                "Music",
                "Handwriting",
                "German",
                "French",
                "Art",
                "German",
                "Dramatics",
                "Instrumental Music",
                "Speech",
                "Health",
                "Design and technology",
                "Language Arts",
                "English IV",
                "Dramatics"
            };

            Random rnd = new Random();
            return interests[rnd.Next(0, interests.Count - 1)];
        }

        #endregion
    }
}
