using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class BenLst
    {
        public int BenId { get; set; }
        public string CoName { get; set; }
        public int? CorpTypeId { get; set; }
        public string Fname { get; set; }
        public string Middle { get; set; }
        public string Lname { get; set; }
        public string Ssn { get; set; }
        public string Gender { get; set; }
        public int? PeoplePrefixId { get; set; }
        public int? PeopleSuffixId { get; set; }
        public string LegalName { get; set; }
        public string Name2 { get; set; }
        public string FedId { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountyId { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string HomePh { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Notes { get; set; }
        public int? ElecCheckSig { get; set; }
        public string PrtCheckAs { get; set; }
        public string StateInc { get; set; }
        public int? TermDays { get; set; }
        public int? Status { get; set; }
        public int? ModSecLvl { get; set; }
        public string Name { get; set; }
        public int? CoId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
