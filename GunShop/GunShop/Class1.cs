using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{   
/// <summary>
/// Магазин
/// </summary>
    public class Shop
    {
    /// <summary>
    /// Название магазина
    /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Адрес магазина
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Фото магазина
        /// </summary>
        public byte[] Photo { get; set; }
    
        /// <summary>
        /// Оружие
        /// </summary>
        public List<Specifications> Guns { get; set; }

        /// <summary>
        /// Патроны
        /// </summary>
        public List<Specifications> Ammunition { get; set; }
    }

    /// <summary>
    /// Характеристики
    /// </summary>
   public class Specifications
    {
        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Вид оружия
        /// </summary>
        public GunType GunType { get; set; }

        /// <summary>
        /// В наличии или нет
        /// </summary>
        public bool Status { get; set; }
               
        /// <summary>
        /// Калибр
        /// </summary>
        public string Caliber { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

    }

    /// <summary>
    /// Вид оружия
    /// </summary>
    public enum GunType
    {
        /// <summary>
        /// Дробовик
        /// </summary>
        Shotgun,

        /// <summary>
        /// Пистолет
        /// </summary>
        Handgun,

        /// <summary>
        /// Винтовка/Ружье
        /// </summary>
        Rifle
    }
}
