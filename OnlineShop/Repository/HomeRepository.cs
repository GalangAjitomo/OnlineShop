using OnlineShop.DataModel;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Repository
{
    public class HomeRepository
    {
        public List<ProductDetail> GetProduct(string search)
        {
            if (search == null) search = "";
            List<ProductDetail> result = new List<ProductDetail>();
            try
            {
                using (var db = new MyContext())
                {
                    result = (from p in db.Tbl_Product
                              join c in db.Tbl_Category on p.CategoryId equals c.CategoryId
                              where p.ProductName.Contains(search) || c.CategoryName.Contains(search)
                              select new ProductDetail

                              {
                                  ProductId = p.ProductId,
                                  ProductName = p.ProductName,
                                  CategoryId = p.CategoryId,
                                  ProductImage = p.ProductImage,
                                  Quantity = p.Quantity,
                                  Price = p.Price,
                                  IsActive = p.IsActive,
                                  IsDelete = p.IsDelete,
                                  IsFeatured = p.IsFeatured
                              }).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result == null ? new List<ProductDetail>() : result;
        }
    }
}