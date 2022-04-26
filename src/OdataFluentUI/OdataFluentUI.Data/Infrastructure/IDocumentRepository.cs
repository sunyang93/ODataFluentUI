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
        void CreateEntitySetConfig(EntitySetConfig entitySetConfig);

        bool UpdateEntitySetConfig(EntitySetConfig entitySetConfig);

        EntitySetConfig GetEntitySetConfig(string id);

        bool DeleteEntitySetConfig(string id);
    }
}
