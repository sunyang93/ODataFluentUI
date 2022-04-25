using LiteDB;
using OdataFluentUI.Core.Infrastructure;
using OdataFluentUI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdataFluentUI.Data.Infrastructure
{
    public class DocumentRepository: IDocumentRepository
    {
        public DocumentRepository()
        {

        }

        public void Test()
        {
            using (var db = new LiteDatabase(@"mydb.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<EntitySetConfig>("EntitySetConfigs");

                // Create your new customer instance
                var customer = new EntitySetConfig()
                {
                    Name="test",
                    DisplayName="重试",
                    Description="这是测试",
                    Properties=new List<EntitySetConfigProperty>()
                    {
                        new EntitySetConfigProperty()
                        {
                            Name="hello",
                            DisplayName="测试一下",
                            DataType=ConfigDataType.Text
                        }
                    }
                };

                // Insert new customer document (Id will be auto-incremented)
                col.Insert(customer);

                // Update a document inside a collection
                //customer.Name = "Jane Doe";

                //col.Update(customer);

                // Index document using document Name property
                col.EnsureIndex(x => x.Name);

                // Use LINQ to query documents (filter, sort, transform)
                var results = col.Query()
                    .Where(x => x.Name.StartsWith("J"))
                    .OrderBy(x => x.Name)
                    .Select(x => new { x.EntitySetConfigId,x.Name, NameUpper = x.Name.ToUpper() })
                    .Limit(10)
                    .ToList();
                var jj = 1;
            }
        }
    }
}
