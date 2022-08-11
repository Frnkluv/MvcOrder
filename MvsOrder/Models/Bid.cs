using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvsOrder.Models
{
    public class Bid
    {
        public virtual int BidId { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Город отправителя")]
        public virtual string FromCity { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Адрес отправителя")]
        public virtual string FromAdress { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Город получателя")]
        public virtual string ToCity { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Адрес получателя")]
        public virtual string ToAdress { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Вес груза (кг)")]
        public virtual int Weight { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public virtual DateTime BidDate { get; set; }
    }
}