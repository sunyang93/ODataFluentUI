using OdataFluentUI.Data.Models;

namespace OdataFluentUI.Data.Infrastructure
{
    public interface IDocumentRepository
    {
        #region EnumType
        void CreateEnumTypeConfigs(List<EnumTypeConfig> enumTypeConfigs);

        bool UpdateEnumTypeConfig(EnumTypeConfig enumTypeConfig);

        EnumTypeConfig GetEnumTypeConfig(string id);

        List<EnumTypeConfig> GetEnumTypeConfigs(List<string> ids);

        bool DeleteEnumTypeConfig(string id);
        #endregion

        #region EntitySet
        void CreateEntitySetConfigs(List<EntitySetConfig> entitySetConfigs);

        bool UpdateEntitySetConfig(EntitySetConfig entitySetConfig);

        EntitySetConfig GetEntitySetConfig(string id);

        List<EntitySetConfig> GetEntitySetConfigs(List<string> ids);

        bool DeleteEntitySetConfig(string id);
        #endregion
    }
}
