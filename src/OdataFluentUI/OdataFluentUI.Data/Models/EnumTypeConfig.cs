using LiteDB;
using System.ComponentModel.DataAnnotations;

namespace OdataFluentUI.Data.Models
{
    public class EnumTypeConfig
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [BsonId]
        public ObjectId EnumTypeConfigId { get; set; }

        /// <summary>
        /// 主键Id(冗余字段)
        /// </summary>
        [BsonIgnore]
        public string Id
        {
            get { return EnumTypeConfigId?.ToString(); }
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

        public List<EnumType> Enums { get; set; }
    }

    public class EnumType
    {
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
        /// 枚举值
        /// </summary>
        [Required]
        public int Value { get; set; }
    }
}
