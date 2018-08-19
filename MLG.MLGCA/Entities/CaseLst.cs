using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class CaseLst
    {
        public int CaseId { get; set; }
        public string CaseNum { get; set; }
        public int? ClientId { get; set; }
        public int? ClientCdId { get; set; }
        public string LoanNum { get; set; }
        public string RefCaseNum { get; set; }
        public int? UserId { get; set; }
        public int? AttyId { get; set; }
        public int? UserBarnumId { get; set; }
        public int? AttyId2 { get; set; }
        public int? UserBarnumId2 { get; set; }
        public int? ColUserId { get; set; }
        public int? CaseTypeId { get; set; }
        public int? CaseSeqId { get; set; }
        public int? CaseStatAutoId { get; set; }
        public DateTime CurCaseStatDt { get; set; }
        public int CurCaseStatId { get; set; }
        public DateTime? MinOpenDt { get; set; }
        public double? BidAmt { get; set; }
        public double? SaleAmt { get; set; }
        public string ExtId { get; set; }
        public int? RateCdId { get; set; }
        public int? LockFeesCost { get; set; }
        public string ColReimburseCosts { get; set; }
        public string ColRemitGrossNet { get; set; }
        public double? ColFeeFlat { get; set; }
        public string ColApplyFlatFee { get; set; }
        public double? ColFeePcnt { get; set; }
        public int? InvToBenId { get; set; }
        public int? InvToClientCdId { get; set; }
        public int? InvToDebtorId { get; set; }
        public int? InvToEntId { get; set; }
        public int? InvToVendId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
