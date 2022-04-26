using LiteDB;
using OdataFluentUI.Data.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OdataFluentUI.Data.Infrastructure
{
    public class DocumentRepository: IDocumentRepository
    {
        private readonly LiteDatabase _liteDatabase;

        public DocumentRepository(LiteDatabase liteDatabase)
        {
            _liteDatabase = liteDatabase;
        }

        public void CreateEntitySetConfig(EntitySetConfig entitySetConfig)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            dataSet.EnsureIndex(x => x.Name);
            dataSet.Insert(entitySetConfig);
        }

        public bool DeleteEntitySetConfig(string id)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            return dataSet.Delete(new ObjectId(id));
        }

        public EntitySetConfig GetEntitySetConfig(string id)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            EntitySetConfig entitySetConfig = dataSet.FindById(new ObjectId(id));
            return entitySetConfig;
        }

        public bool UpdateEntitySetConfig(EntitySetConfig entitySetConfig)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            return dataSet.Update(entitySetConfig);
        }
    }
}
