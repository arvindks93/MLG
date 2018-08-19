using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class ClientLst
    {
        public int ClientId { get; set; }
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
        public int? Priority { get; set; }
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
        public string LossMitPh { get; set; }
        public string Email { get; set; }
        public int BillFlag { get; set; }
        public string AutoCd { get; set; }
        public string Notes { get; set; }
        public string Note2 { get; set; }
        public int? ElecCheckSig { get; set; }
        public string PrtCheckAs { get; set; }
        public string PrtAddressAs { get; set; }
        public string StateInc { get; set; }
        public int? TermDays { get; set; }
        public string ColReimburseCosts { get; set; }
        public string ColRemitGrossNet { get; set; }
        public double? ColFeeFlat { get; set; }
        public string ColApplyFlatFee { get; set; }
        public double? ColFeePcnt { get; set; }
        public int? Status { get; set; }
        public int? HrFeeAuthReq { get; set; }
        public int? ModSecLvl { get; set; }
        public string Name { get; set; }
        public string SignAs { get; set; }
        public string ClientCompany { get; set; }
        public string Originator { get; set; }
        public string MarketRep { get; set; }
        public string PrefCloser { get; set; }
        public int? CoId { get; set; }
        public int? AddAllCont { get; set; }
        public int? ClientCatId { get; set; }
        public int? UseRefAddrInv { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string Udf6 { get; set; }
        public string Udf7 { get; set; }
        public string Udf8 { get; set; }
        public string Udf9 { get; set; }
        public string Udf10 { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
