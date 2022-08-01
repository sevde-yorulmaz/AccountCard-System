using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AccountCardSubGroup:BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("AccountCardGroup")]
        public int AccountCardGroupId { get; set; }
        public AccountCardGroup AccountCardGroup { get; set; }


        public List<AccountCard> AccountCard { get; set; }
        public bool Status { get; set; }

    }
}
