using OdataFluentUI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdataFluentUI.Data.Infrastructure
{
    public interface IDocumentRepository
    {
        void CreateEntitySetConfigs(List<EntitySetConfig> entitySetConfigs);

        bool UpdateEntitySetConfig(EntitySetConfig entitySetConfig);

        EntitySetConfig GetEntitySetConfig(string id);

        List<EntitySetConfig> GetEntitySetConfigs(List<string> ids);

        bool DeleteEntitySetConfig(string id);
    }
}
