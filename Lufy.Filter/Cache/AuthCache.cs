using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufy.Filter.Cache
{
    public abstract class AuthCache
    {
        private static IList<string> TokenList;

        protected AuthCache(IList<string> tokens)
        {
            TokenList = tokens;
        }

        public static bool ContainsToken(string token)
        {
            return TokenList.Any(n => n.Equals(token));
        }
    }
}
