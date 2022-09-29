using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoLibrary;

public class StockModule2
{
    //public delegate void NoofItemCount(List<ProductModel> productModels);
    //public delegate decimal AfterDiscoutTotal(decimal total);
    public List<ProductModel> Items { get; set; } = new List<ProductModel>();
    public decimal TotalCalc(Action<List<ProductModel>> noofItemCount, Func<decimal,decimal> afterDiscoutTotal)
    {
        noofItemCount(Items);
        decimal Total = Items.Sum(x => x.Price);
        decimal AfterDiscount = afterDiscoutTotal(Total);
        return AfterDiscount;
    }
}
