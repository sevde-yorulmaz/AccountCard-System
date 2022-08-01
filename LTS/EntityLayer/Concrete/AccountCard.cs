using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AccountCard:BaseEntity
    {
       
        public string Degree { get; set; }
        public string TaxAdministration { get; set; }
        public string TaxNumber { get; set; }
        public string TCNo { get; set; }
        public string Address { get; set; }

        [ForeignKey("AccountCardKind")]//hesap türü
        public int AccountCardKindId { get; set; }
        public AccountCardKind AccountCardKind { get; set; }

        [ForeignKey("AccountCardType")]//hesap tipi
        public int AccountCardTypeId { get; set; }
        public AccountCardType AccountCardType { get; set; }

        [ForeignKey("AccountCardGroup")]//hesap grup
        public int AccountCardGroupId { get; set; }
        public AccountCardGroup AccountCardGroup { get; set; }

        [ForeignKey("AccountCardSubGroup")]//hesap altgrup
        public int AccountCardSubGroupId { get; set; }
        public AccountCardSubGroup AccountCardSubGroup { get; set; }

        public bool Status { get; set; }


    }
}
