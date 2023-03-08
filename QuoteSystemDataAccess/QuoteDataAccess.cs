using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteSystemDataModel;
namespace QuoteSystemDataAccess
{
    public class QuoteDataAccess
    {
        public static Quote AddQuote(Quote Quote)
        {

            Quote Quote1;
            using (var dbContext = new QuoteDataModelContainer())
            {
                dbContext.Quotes.Add(Quote);
                Quote1 = dbContext.Quotes.Where(q => q.QuoteNumber == Quote.QuoteNumber).FirstOrDefault<Quote>();
                dbContext.SaveChanges();
            }
            return Quote1;

        }

        /*
        public static void AddBusiness(string QuoteNumber,Business business)
        {
            Quote Quote1;
            using (var dbContext = new QuoteDataModelContainer())
            {
                Quote1 = dbContext.Quotes.Where(q => q.QuoteNumber == QuoteNumber).FirstOrDefault<Quote>();
                Prospect prospect1=Quote1.Prospect;
                prospect1.Businesses = new List<Business>();

                List<Business> ProspectBusiness = prospect1.Businesses.ToList();

                

                ProspectBusiness[0].Address.FirstLine = business.Address.FirstLine;
               /* ProspectBusiness[0].Coverages = business.Coverages;
                ProspectBusiness[0].IndustryType = business.IndustryType;
                ProspectBusiness[0].Territory = business.Territory;
                ProspectBusiness[0].Exposure = business.Exposure; 
                dbContext.SaveChanges();
            }
        }
        */

    }
}
