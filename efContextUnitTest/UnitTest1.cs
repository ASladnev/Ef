using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using efContext;
using System.Data.Entity;
using System.Linq;

namespace efContextUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Context context; 

        [TestInitialize]
        public void TestInitial ()
        {
            Database.SetInitializer<Context>(new DatabaseInitializer());


        }


        [TestMethod]
        public void TestMethod1()
        {
            using (var context = new Context())
            {
                Assert.AreEqual(3, context.Printer.Count());
                Assert.AreEqual(2, context.Computer.Count());
            }    
        
        }
    }
}
