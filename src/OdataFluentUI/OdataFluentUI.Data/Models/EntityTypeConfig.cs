using LiteDB;
using System.ComponentModel.DataAnnotations;

namespace OdataFluentUI.Data.Models
{
    public class EntityTypeConfig
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [BsonId]
        public ObjectId EntityTypeConfigId { get; set; }

        /// <summary>
        /// 主键Id(冗余字段)
        /// </summary>
        [BsonIgnore]
        public string Id
        {
            get { return EntityTypeConfigId?.ToString(); }
        }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [Required]
        public string DisplayName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
