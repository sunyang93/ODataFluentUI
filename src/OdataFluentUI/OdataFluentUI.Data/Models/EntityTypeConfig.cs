using LiteDB;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

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

        /// <summary>
        /// Entity主键
        /// </summary>
        public List<string> Keys { get; set; }

        public List<EntityTypeConfigProperty> Properties { get; set; }
    }

    public class EntityTypeConfigProperty
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 是否为主键
        /// </summary>
        public bool IsPKey { get; set; }

        /// <summary>
        /// 是否为外键
        /// </summary>
        public bool IsFKey { get; set; }

        /// <summary>
        /// 编辑器
        /// </summary>
        public Editor Editor { get; set; }

        /// <summary>
        /// EnumTypeConfig(引用类型)
        /// </summary>
        [BsonRef("EnumTypeConfigs")]
        public EnumTypeConfig EnumTypeConfig { get; set; }

        /// <summary>
        /// EnumTypeConfig
        /// </summary>
        [BsonIgnore]
        public EnumTypeConfig EnumTypeConfigValue { get; set; }

        /// <summary>
        /// 编辑器类型
        /// </summary>
        public EditorType? EditorType { get; set; }

        /// <summary>
        /// 最大长度
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// 是否只读
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        public bool IsRequired { get; set; }
    }

    /// <summary>
    /// 编辑器
    /// </summary>
    public enum Editor
    { 
        /// <summary>
        /// 文本框
        /// </summary>
        Input=1,
        /// <summary>
        /// 下拉列表
        /// </summary>
        Select,
        /// <summary>
        /// 文本域
        /// </summary>
        Textarea
    }

    /// <summary>
    /// 编辑器类型
    /// </summary>
    public enum EditorType
    {
        /// <summary>
        /// 文本
        /// </summary>
        Text=1,
        /// <summary>
        /// 数字
        /// </summary>
        Number,
        /// <summary>
        /// 日期
        /// </summary>
        Date,
        /// <summary>
        /// 时间
        /// </summary>
        Datetime,
        /// <summary>
        /// 复选框
        /// </summary>
        Checkbox
    }
}
