using LiteDB;
using OdataFluentUI.Data.Models;

namespace OdataFluentUI.Data.Infrastructure
{
    public class DocumentRepository: IDocumentRepository
    {
        private readonly LiteDatabase _liteDatabase;

        public DocumentRepository(LiteDatabase liteDatabase)
        {
            _liteDatabase = liteDatabase;
        }

        public void CreateEntitySetConfigs(List<EntitySetConfig> entitySetConfigs)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            dataSet.EnsureIndex(x => x.Name,true);
            dataSet.InsertBulk(entitySetConfigs);
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

        public List<EntitySetConfig> GetEntitySetConfigs(List<string> ids)
        {
            List<ObjectId> _ids = new List<ObjectId>();
            ids.ForEach(id =>
            {
                _ids.Add(new ObjectId(id));
            });
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            List<EntitySetConfig> entitySetConfigs = dataSet.Query().Where(d=> _ids.Contains(d.EntitySetConfigId)).ToList();
            return entitySetConfigs;
        }

        public bool UpdateEntitySetConfig(EntitySetConfig entitySetConfig)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            return dataSet.Update(entitySetConfig);
        }
    }
}
