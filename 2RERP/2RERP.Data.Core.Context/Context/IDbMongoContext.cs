﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2RERP.Data.Core.Context.Context
{
   public interface IDbMongoContext
   {
       MongoContext GetMongoDatabase();
   }
}
