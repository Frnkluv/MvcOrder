using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvsOrder.Models
{
    public class BidDbInitializer : DropCreateDatabaseIfModelChanges<BidContext>
    {
        protected override void Seed(BidContext context)
        {
            base.Seed(context);
        }
    }
}