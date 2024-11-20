﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace FinalTest.Models.ViewModel
{
    public class ProductDetailsVM
    {
        public Product product { get; set; }
        public int quantity { get; set; } = 1;
        // Tính giá trị tạm thời 
        public decimal estimatedValue => quantity * product.ProductPrice;

        // Các thuộc tính hỗ trợ phân trang 
        public int PageNumber { get; set; } // Trang hiện tại 
        public int PageSize { get; set; } = 3; // Số sản phẩm mỗi trang

        // danh sách 8 sản phẩm cùng danh mục 
        //public PagedList.IPagedList<Product> RelatedProducts { get; set; }
        public List<Product> RelatedProducts { get; set; }

        // danh sách 8 sản phẩm bán chạy nhất cùng danh mục 
        public PagedList.IPagedList<Product> TopProducts { get; set; }
    }
}