using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class CaseTypeLst
    {
        public int CaseTypeId { get; set; }
        public int CoId { get; set; }
        public string CaModule { get; set; }
        public string FileType { get; set; }
        public string Name { get; set; }
        public int? CasePurch { get; set; }
        public int? FinInfoFlg { get; set; }
        public int? LossMitFlg { get; set; }
        public int? CaseSaleFlg { get; set; }
        public int? RateCdReq { get; set; }
        public string AutoCd { get; set; }
        public int? Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
