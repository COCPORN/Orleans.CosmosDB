using System;
using System.Collections.Generic;
using System.Text;

namespace Orleans.Persistence.CosmosDB
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class IndexAttribute : Attribute
    {
        public IndexAttribute() { }

        public IndexAttribute(string prefix)
        {
            this.Prefix = prefix;
        }

        public string Prefix { get; set; }

        public string Path { get; set; }
    }
}
