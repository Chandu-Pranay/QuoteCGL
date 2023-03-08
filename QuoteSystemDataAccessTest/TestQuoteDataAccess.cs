using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteSystemDataAccess;
using QuoteSystemDataModel;
namespace QuoteSystemDataAccessTest
{
    class TestQuoteDataAccess
    {
        public Quote AddQuoteTest()
        {

          Address Address = new Address()
            {
                FirstLine = "cherlapalli",
                SecondLine = "ECIL",
                City = "Hyd",
                State = "telangana",
                ZipCode = "505301",
            };

            List<Business> businesses = new List<Business>();
           

            Business business = new Business()
            {
                IndustryType = "software",
                Territory = "vmd",
                Exposure = 1000,
                Address = Address,
                Coverages = new List<Coverage>()
                {
                     new Coverage()
                     {
                          CoverageName="Theft",
                          Deductible=10000,
                          OccuranceLimit=50000,
                          AggregateLimit=100000,
                          CoveragePremium=500.0d

                     }
                }

            };
            businesses.Add(business);

            Prospect Prospect1 = new Prospect()
            {
                OrganisationName = "jarus",
                Contact = "6301736456",
                Email = "vijay@gmail.com",
                NumberOfBusinessUnits = 4,
                Businesses = businesses
            };

            PolicyTerm PolicyTerm = new PolicyTerm()
            {
                PolicyEffectiveDate = System.DateTime.Now,
                PolicyExpiryDate = System.DateTime.Now.AddDays(5)
            };

            Quote Quote = new Quote()
            {
                QuoteNumber = "Q-12345",
                RiskState = "India",
                Premium = 100.0d,
                AgentId = "A123",
                Prospect = Prospect1,
                PolicyTerm = PolicyTerm
            };

            return Quote;
        }

        public Business AddBusinessTest()
        {
            Address Address = new Address()
            {
                FirstLine = "tprn",
                SecondLine = "ECIL",
                City = "Hyd",
                State = "telangana",
                ZipCode = "505301",
            };
            Business business = new Business()
            {
                IndustryType = "kgh",
                Territory = "vmd",
                Exposure = 1000,
                Address = Address,
                Coverages = new List<Coverage>()
                {
                     new Coverage()
                     {
                          CoverageName="Fire",
                          Deductible=10000,
                          OccuranceLimit=50000,
                          AggregateLimit=100000,
                          CoveragePremium=500.0d

                     }
                }

            };
            return business;


        }
    }
}
