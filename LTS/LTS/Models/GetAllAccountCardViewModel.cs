using EntityLayer.Concrete;
using System.Collections.Generic;

namespace LTS.Models
{
    public class GetAllAccountCardViewModel
    {
        public List<AccountCard> cards { get; set; }
        public List<AccountCardType> cardTypes { get; set; }
        public List<AccountCardKind> cardKinds { get; set; }
        public List<AccountCardGroup> cardGroups { get; set; }
        public List<AccountCardSubGroup> cardSubGroups { get; set; }
    }
}
