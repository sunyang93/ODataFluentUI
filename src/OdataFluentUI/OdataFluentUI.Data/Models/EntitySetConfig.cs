using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdataFluentUI.Data.Models
{
    public class EntitySetConfig
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [BsonId]
        public ObjectId EntitySetConfigId{get;set;}

        /// <summary>
        /// 主键Id(冗余字段)
        /// </summary>
        [BsonIgnore]
        public string Id
        {
            get { return EntitySetConfigId?.ToString(); }
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
        /// 是否可见
        /// </summary>
        public bool IsVisible { get; set; }

        public List<EntitySetConfigProperty> Properties { get; set; }
    }

    public class EntitySetConfigProperty
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
        /// 数据类型
        /// </summary>
        public ConfigDataType DataType { get; set; }

        /// <summary>
        /// 是否为主键
        /// </summary>
        public bool IsPKey { get; set; }
        
        /// <summary>
        /// 是否为外键
        /// </summary>
        public bool IsFKey { get; set; }

        /// <summary>
        /// 是否可以排序
        /// </summary>
        public bool CanSort { get; set; }

        /// <summary>
        /// 是否可以筛选
        /// </summary>
        public bool CanFilter { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        public bool IsVisible { get; set; }
    }

    /// <summary>
    /// 数据类型
    /// </summary>
    public enum ConfigDataType
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
        Date
    }
}
