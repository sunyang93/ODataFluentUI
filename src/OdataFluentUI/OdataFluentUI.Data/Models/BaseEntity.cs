using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace OdataFluentUI.Data
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// 可用状态
        /// </summary>
        [DefaultValue(true)]
        [Comment("可用状态")]
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// 创建时间
        /// </summary>
        [Comment("创建时间")]
        public DateTime CreateTime { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Comment("最后更新时间")]
        public DateTime? UpdateTime { get; set; }
    }
}
