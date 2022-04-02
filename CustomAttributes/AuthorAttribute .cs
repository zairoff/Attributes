using System;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)
]
    public class AuthorAttribute : Attribute
    {
        private readonly string name;
        public double version;

        public AuthorAttribute(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }
}
