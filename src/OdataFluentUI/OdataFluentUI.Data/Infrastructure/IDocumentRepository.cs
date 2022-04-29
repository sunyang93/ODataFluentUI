using OdataFluentUI.Data.Models;

namespace OdataFluentUI.Data.Infrastructure
{
    public interface IDocumentRepository
    {
        #region EntityType
        void CreateEntityTypeConfigs(List<EntityTypeConfig> entityTypeConfigs);

        bool UpdateEntityTypeConfig(EntityTypeConfig entityTypeConfig);

        EntityTypeConfig GetEntityTypeConfig(string id);

        List<EntityTypeConfig> GetEntityTypeConfigs(List<string> ids);

        List<EntityTypeConfig> GetAllEntityTypeConfigs();

        EntityTypeConfig QueryEntityTypeConfigByName(string name);

        bool DeleteEntityTypeConfig(string id);
        #endregion

        #region EnumType
        void CreateEnumTypeConfigs(List<EnumTypeConfig> enumTypeConfigs);

        bool UpdateEnumTypeConfig(EnumTypeConfig enumTypeConfig);

        EnumTypeConfig GetEnumTypeConfig(string id);

        List<EnumTypeConfig> GetEnumTypeConfigs(List<string> ids);

        List<EnumTypeConfig> GetAllEnumTypeConfigs();

        EnumTypeConfig QueryEnumTypeConfigByName(string name);

        bool DeleteEnumTypeConfig(string id);
        #endregion

        #region EntitySet
        void CreateEntitySetConfigs(List<EntitySetConfig> entitySetConfigs);

        bool UpdateEntitySetConfig(EntitySetConfig entitySetConfig);

        EntitySetConfig GetEntitySetConfig(string id);

        List<EntitySetConfig> GetEntitySetConfigs(List<string> ids);

        List<EntitySetConfig> GetAllEntitySetConfigs();

        EntitySetConfig QueryEntitySetConfigByName(string name);

        bool DeleteEntitySetConfig(string id);
        #endregion
    }
}
