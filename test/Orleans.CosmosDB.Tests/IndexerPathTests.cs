using Orleans.Persistence.CosmosDB;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Orleans.CosmosDB.Tests
{
    public class IndexerPathTests
    {
        [Fact]
        public void TestSimpleProperty()
        {
            var pathName = CosmosDBGrainStorage.PathName("FullName", new IndexAttribute());

            Assert.Equal("FullName", pathName);
        }

        [Fact]
        public void TestPrefix()
        {
            var pathName = CosmosDBGrainStorage.PathName("FullName", new IndexAttribute("Data"));

            Assert.Equal("Data/FullName", pathName);
        }

        [Fact]
        public void TestPath()
        {
            var pathName = CosmosDBGrainStorage.PathName("IgnoreMe", new IndexAttribute { Path = "Data/FullName" });

            Assert.Equal("Data/FullName", pathName);
        }

        [Fact]
        public void TestPathAndPrefix()
        {
            var pathName = CosmosDBGrainStorage.PathName("IgnoreMe", new IndexAttribute("Data") { Path = "FullName" });

            Assert.Equal("Data/FullName", pathName);
        }
    }
}
