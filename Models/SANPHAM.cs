﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace btlMVC01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class SANPHAM
    {
        [DisplayName("Mã sản phẩm")]
        public string masp { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string tensp { get; set; }
        [DisplayName("Mô tả")]
        public string Mota { get; set; }
        [DisplayName("Hình sản phẩm")]
        public string hinhanh { get; set; }
        [DisplayName("Giá sản phẩm")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Nullable<int> gia { get; set; }
        [DisplayName("Số lượng")]
        public Nullable<int> soluong { get; set; }
        public string maloaisp { get; set; }
    
        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
    }
}
