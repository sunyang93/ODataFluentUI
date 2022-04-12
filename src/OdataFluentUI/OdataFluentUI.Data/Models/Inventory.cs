using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 库存
    /// </summary>
    public class Inventory
    {
        ///// <summary>
        ///// 主键Id
        ///// </summary>
        //public int InventoryId { get; set; }

        /// <summary>
        /// 物料Id
        /// </summary>
        [Key]
        public int MaterialId { get; set; }

        /// <summary>
        /// 物料
        /// </summary>
        public Material Material { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        [Key]
        [MaxLength(50)]
        public string Batch { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public ulong Number { get; set; }

        /// <summary>
        /// 可用状态
        /// </summary>
        [DefaultValue(true)]
        public bool IsAvailable { get; set; }

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
