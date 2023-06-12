using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace test_mongo
{
    public class ProductWasNotFoundException : Exception
    {
        public ProductWasNotFoundException(string? message) : base(message)
        {
        }

        protected ProductWasNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
