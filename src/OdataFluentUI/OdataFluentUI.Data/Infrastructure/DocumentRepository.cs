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

        #region EntityType
        public void CreateEntityTypeConfigs(List<EntityTypeConfig> entityTypeConfigs)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>("EntityTypeConfigs");
            dataSet.EnsureIndex(x => x.Name, true);
            dataSet.InsertBulk(entityTypeConfigs);
        }

        public bool DeleteEntityTypeConfig(string id)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>("EntityTypeConfigs");
            return dataSet.Delete(new ObjectId(id));
        }

        public EntityTypeConfig GetEntityTypeConfig(string id)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>("EntityTypeConfigs");
            EntityTypeConfig entityTypeConfig = dataSet.FindById(new ObjectId(id));
            return entityTypeConfig;
        }

        public List<EntityTypeConfig> GetEntityTypeConfigs(List<string> ids)
        {
            List<ObjectId> _ids = new();
            ids.ForEach(id =>
            {
                _ids.Add(new ObjectId(id));
            });
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>("EntityTypeConfigs");
            List<EntityTypeConfig> entityTypeConfigs = dataSet.Query().Where(d => _ids.Contains(d.EntityTypeConfigId)).ToList();
            return entityTypeConfigs;
        }

        public List<EntityTypeConfig> GetAllEntityTypeConfigs()
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>("EntityTypeConfigs");
            List<EntityTypeConfig> entityTypeConfigs = dataSet.Query().ToList();
            return entityTypeConfigs;
        }

        public bool UpdateEntityTypeConfig(EntityTypeConfig entityTypeConfig)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>("EntityTypeConfigs");
            return dataSet.Update(entityTypeConfig);
        }
        #endregion

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
            List<ObjectId> _ids = new();
            ids.ForEach(id =>
            {
                _ids.Add(new ObjectId(id));
            });
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>("EnumTypeConfigs");
            List<EnumTypeConfig> enumTypeConfigs = dataSet.Query().Where(d => _ids.Contains(d.EnumTypeConfigId)).ToList();
            return enumTypeConfigs;
        }

        public List<EnumTypeConfig> GetAllEnumTypeConfigs()
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>("EnumTypeConfigs");
            List<EnumTypeConfig> enumTypeConfigs = dataSet.Query().ToList();
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
            List<ObjectId> _ids = new();
            ids.ForEach(id =>
            {
                _ids.Add(new ObjectId(id));
            });
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            List<EntitySetConfig> entitySetConfigs = dataSet.Query().Where(d=> _ids.Contains(d.EntitySetConfigId)).ToList();
            return entitySetConfigs;
        }

        public List<EntitySetConfig> GetAllEntitySetConfigs()
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>("EntitySetConfigs");
            List<EntitySetConfig> entitySetConfigs = dataSet.Query().ToList();
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
