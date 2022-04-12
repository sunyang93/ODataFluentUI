using System.ComponentModel;

namespace OdataFluentUI.Data
{
    public class BaseEntity
    {
        /// <summary>
        /// 可用状态
        /// </summary>
        [DefaultValue(true)]
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
    }
}
