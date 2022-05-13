using LiteDB;
using OdataFluentUI.Data.Models;
using Humanizer;

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
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());
            ILiteCollection<EnumTypeConfig> _dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            entityTypeConfigs.ForEach(entityTypeConfig => {
                entityTypeConfig.Properties.ForEach(property => {
                    if (property.Editor == Editor.Select)
                    {
                        EnumTypeConfig enumTypeConfig = _dataSet.Query().Where(d => d.Name == property.Name).FirstOrDefault();
                        if (enumTypeConfig != null)
                        {
                            property.EnumTypeConfig = enumTypeConfig;
                        }
                    }
                });
            });
            dataSet.EnsureIndex(x => x.Name, true);
            dataSet.InsertBulk(entityTypeConfigs);
        }

        public bool DeleteEntityTypeConfig(string id)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());
            return dataSet.Delete(new ObjectId(id));
        }

        public EntityTypeConfig GetEntityTypeConfig(string id)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());           
            EntityTypeConfig entityTypeConfig = dataSet.FindById(new ObjectId(id));
            ILiteCollection<EnumTypeConfig> _dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            entityTypeConfig.Properties.ForEach(property =>
            {
                if (property.EnumTypeConfig != null)
                {
                    property.EnumTypeConfigValue=_dataSet.FindById(property.EnumTypeConfig.EnumTypeConfigId);
                }
            });
            return entityTypeConfig;
        }

        public List<EntityTypeConfig> GetEntityTypeConfigs(List<string> ids)
        {
            List<ObjectId> _ids = new();
            ids.ForEach(id =>
            {
                _ids.Add(new ObjectId(id));
            });
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());
            List<EntityTypeConfig> entityTypeConfigs = dataSet.Query().Where(d => _ids.Contains(d.EntityTypeConfigId)).ToList();
            return entityTypeConfigs;
        }

        public List<EntityTypeConfig> GetAllEntityTypeConfigs()
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());
            List<EntityTypeConfig> entityTypeConfigs = dataSet.Query().ToList();
            return entityTypeConfigs;
        }

        public EntityTypeConfig QueryEntityTypeConfigByName(string name)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());
            EntityTypeConfig entityTypeConfig = dataSet.Query().Where(d => d.Name == name).FirstOrDefault();
            return entityTypeConfig;
        }

        public bool UpdateEntityTypeConfig(EntityTypeConfig entityTypeConfig)
        {
            ILiteCollection<EntityTypeConfig> dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());
            return dataSet.Update(entityTypeConfig);
        }
        #endregion

        #region EnumType
        public List<EnumTypeConfig> CreateEnumTypeConfigs(List<EnumTypeConfig> enumTypeConfigs)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            dataSet.EnsureIndex(x => x.Name, true);
            dataSet.InsertBulk(enumTypeConfigs);
            return enumTypeConfigs;
        }

        public bool DeleteEnumTypeConfig(string id)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            return dataSet.Delete(new ObjectId(id));
        }

        public EnumTypeConfig GetEnumTypeConfig(string id)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
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
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            List<EnumTypeConfig> enumTypeConfigs = dataSet.Query().Where(d => _ids.Contains(d.EnumTypeConfigId)).ToList();
            return enumTypeConfigs;
        }

        public List<EnumTypeConfig> GetAllEnumTypeConfigs()
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            List<EnumTypeConfig> enumTypeConfigs = dataSet.Query().ToList();
            return enumTypeConfigs;
        }

        public EnumTypeConfig QueryEnumTypeConfigByName(string name)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            EnumTypeConfig enumTypeConfig = dataSet.Query().Where(d => d.Name == name).FirstOrDefault();
            return enumTypeConfig;
        }

        public bool UpdateEnumTypeConfig(EnumTypeConfig enumTypeConfig)
        {
            ILiteCollection<EnumTypeConfig> dataSet = _liteDatabase.GetCollection<EnumTypeConfig>(nameof(EnumTypeConfig).Pluralize());
            return dataSet.Update(enumTypeConfig);
        }
        #endregion

        #region EntitySet
        public void CreateEntitySetConfigs(List<EntitySetConfig> entitySetConfigs)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>(nameof(EntitySetConfig).Pluralize());
            ILiteCollection<EntityTypeConfig> _dataSet = _liteDatabase.GetCollection<EntityTypeConfig>(nameof(EntityTypeConfig).Pluralize());
            entitySetConfigs.ForEach(entitySetConfig =>
            {
                EntityTypeConfig entityTypeConfig = _dataSet.Query().Where(d => entitySetConfig.EntityType.EndsWith(d.Name)).FirstOrDefault();
                if(entityTypeConfig != null)
                {
                    entitySetConfig.EntityTypeConfig = entityTypeConfig;
                }
            });
            dataSet.EnsureIndex(x => x.Name,true);
            dataSet.InsertBulk(entitySetConfigs);
        }

        public bool DeleteEntitySetConfig(string id)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>(nameof(EntitySetConfig).Pluralize());
            return dataSet.Delete(new ObjectId(id));
        }

        public EntitySetConfig GetEntitySetConfig(string id)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>(nameof(EntitySetConfig).Pluralize());
            EntitySetConfig entitySetConfig = dataSet.FindById(new ObjectId(id));
            if (entitySetConfig.EntityTypeConfig != null)
            {
                entitySetConfig.EntityTypeConfigValue = GetEntityTypeConfig(entitySetConfig.EntityTypeConfig.Id);
            }
            return entitySetConfig;
        }

        public List<EntitySetConfig> GetEntitySetConfigs(List<string> ids)
        {
            List<ObjectId> _ids = new();
            ids.ForEach(id =>
            {
                _ids.Add(new ObjectId(id));
            });
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>(nameof(EntitySetConfig).Pluralize());
            List<EntitySetConfig> entitySetConfigs = dataSet.Query().Where(d=> _ids.Contains(d.EntitySetConfigId)).ToList();
            return entitySetConfigs;
        }

        public List<EntitySetConfig> GetAllEntitySetConfigs()
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>(nameof(EntitySetConfig).Pluralize());
            List<EntitySetConfig> entitySetConfigs = dataSet.Query().ToList();
            return entitySetConfigs;
        }

        public EntitySetConfig QueryEntitySetConfigByName(string name)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>(nameof(EntitySetConfig).Pluralize());
            EntitySetConfig entitySetConfig = dataSet.Query().Where(d => d.Name == name).FirstOrDefault();
            return entitySetConfig;
        }

        public bool UpdateEntitySetConfig(EntitySetConfig entitySetConfig)
        {
            ILiteCollection<EntitySetConfig> dataSet = _liteDatabase.GetCollection<EntitySetConfig>(nameof(EntitySetConfig).Pluralize());
            return dataSet.Update(entitySetConfig);
        }
        #endregion
    }
}
