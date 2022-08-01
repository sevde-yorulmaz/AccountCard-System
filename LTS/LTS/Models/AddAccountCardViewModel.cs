using EntityLayer.Concrete;
using System.Collections.Generic;

namespace LTS.Models
{
    public class AddAccountCardViewModel
    {
        public AccountCard accountCard { get; set; }
        public List<AccountCardGroup> cardGroups { get; set; }
        public List<AccountCardSubGroup> cardSubGroups { get; set; }
        public List<AccountCardType> cardTypes { get; set; }
        public List<AccountCardKind> cardKinds { get; set; }
        public string tcNo { get; set; }
        public string taxNumber { get; set; }
        public string degree { get; set; }
        public string address { get; set; }
        public string taxAdministration { get; set; }
        public bool status { get; set; }

    }
}
