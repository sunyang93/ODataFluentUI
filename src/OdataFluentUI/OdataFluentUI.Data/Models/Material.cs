using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 物料
    /// </summary>
    public class Material
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int MaterialId { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        [Required]
        public string MaterialCode { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [Required]
        public string MaterialName { get; set; }

        /// <summary>
        /// 物料规格
        /// </summary>
        public string MaterialSpecification { get; set; }

        /// <summary>
        /// 物料型号
        /// </summary>
        [Required]
        public string MaterialModel { get; set; }

        /// <summary>
        /// 物料分类
        /// </summary>
        public MaterialClassification MaterialType { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        /// 可用状态
        /// </summary>
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

    /// <summary>
    /// 物料分类
    /// </summary>
    public enum MaterialClassification
    {
        /// <summary>
        /// 原料
        /// </summary>
        Raw=1,
        /// <summary>
        /// 辅料
        /// </summary>
        Accessories
    }

    /// <summary>
    /// 计量单位
    /// </summary>
    public enum Unit { 
        /// <summary>
        /// 千克
        /// </summary>
        KG=1,
        /// <summary>
        /// 吨
        /// </summary>
        T,
        /// <summary>
        /// 米
        /// </summary>
        M,
        /// <summary>
        /// 千米
        /// </summary>
        KM,
        /// <summary>
        /// 包
        /// </summary>
        PKG,
        /// <summary>
        /// 个
        /// </summary>
        PCS
    }


}
