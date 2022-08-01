using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AccountCardGroup:BaseEntity
    {
        public string GroupName { get; set; }
        public List<AccountCardSubGroup> AccountCardSubGroup { get; set; }

        public List<AccountCard> AccountCard { get; set; }
        public bool Status { get; set; }


    }
}
