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

        #region EnumType
        public void CreateEnumTypeConfigs(List<EnumTypeConfig> enumTypeConfigs)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>("EnumTypeConfigs");
            dataSet.EnsureIndex(x => x.Name, true);
            dataSet.InsertBulk(enumTypeConfigs);
        }

        public bool DeleteEnumTypeConfig(string id)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>("EnumTypeConfigs");
            return dataSet.Delete(new ObjectId(id));
        }

        public EnumTypeConfig GetEnumTypeConfig(string id)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>("EnumTypeConfigs");
            EnumTypeConfig enumTypeConfig = dataSet.FindById(new ObjectId(id));
            return enumTypeConfig;
        }

        public List<EnumTypeConfig> GetEnumTypeConfigs(List<string> ids)
        {
            List<ObjectId> _ids = new List<ObjectId>();
            ids.ForEach(id =>
            {
                _ids.Add(new ObjectId(id));
            });
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>("EnumTypeConfigs");
            List<EnumTypeConfig> enumTypeConfigs = dataSet.Query().Where(d => _ids.Contains(d.EnumTypeConfigId)).ToList();
            return enumTypeConfigs;
        }

        public bool UpdateEnumTypeConfig(EnumTypeConfig enumTypeConfig)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>("EnumTypeConfigs");
            return dataSet.Update(enumTypeConfig);
        }
        #endregion

        #region EntitySet
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
        #endregion
    }
}
