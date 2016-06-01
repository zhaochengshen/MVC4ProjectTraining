using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample6.Models
{
    [DisplayName("个人信息")]
    public class Test2
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public string Name { get; set; }
        [DisplayName("年龄")]
        public int Age { get; set; }
    }
}