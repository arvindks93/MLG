using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class CaseSeqLst
    {
        public int CaseSeqId { get; set; }
        public int CaseTypeId { get; set; }
        public string Name { get; set; }
        public int? StdDays { get; set; }
        public string State { get; set; }
        public int? CountyId { get; set; }
        public int? LoanTypeId { get; set; }
        public int? ClientId { get; set; }
        public int? EntId { get; set; }
        public int? FinInfoId { get; set; }
        public int? FcstStatChg { get; set; }
        public int? FeeAuthDefShow { get; set; }
        public string InvCd { get; set; }
        public int? Status { get; set; }
        public int? SecLvl { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
