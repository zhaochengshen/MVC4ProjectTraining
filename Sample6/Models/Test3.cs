using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Sample6.Models
{
    [DisplayName("学生信息")]
    public class Test3
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        [DisplayName("姓名")]
        public string StuName { get; set; }
        [DisplayName("电话")]
        public string Phone { get; set; }
        [DisplayName("电子邮件")]
        [DataType(DataType.EmailAddress)]
        [UIHint("EmailAddress")]
        public string Email { get; set; }
        [DisplayName("地址")]
        public string Address { get; set; }
        [DisplayName("城市")]
        public string City { get; set; }
        [DisplayName("省份")]
        public string State { get; set; }

    }
}