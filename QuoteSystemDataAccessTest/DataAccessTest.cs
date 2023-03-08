using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteSystemDataModel;
using QuoteSystemDataAccess;
namespace QuoteSystemDataAccessTest
{
    class DataAccessTest
    {
        static void Main(string[] args)
        {
            // Quote Quote = new TestQuoteDataAccess().AddQuoteTest();
            //Console.WriteLine(Quote.QuoteNumber);
            // Quote quote = QuoteDataAccess.AddQuote(Quote);
            // Console.WriteLine(quote.QuoteNumber);

            Business bus = new TestQuoteDataAccess().AddBusinessTest();

            QuoteDataAccess.AddBusiness("Q-12345", bus);
            Console.ReadKey();
        }
    }
}
