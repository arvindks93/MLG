using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class FileLst
    {
        public int FileId { get; set; }
        public string FileType { get; set; }
        public string FileNum { get; set; }
        public int SecLvl { get; set; }
        public int SiteId { get; set; }
        public int? GrpId { get; set; }
        public int? RoGrpId { get; set; }
        public int ClientId { get; set; }
        public int ClientCdId { get; set; }
        public int? BenId { get; set; }
        public int? PropId { get; set; }
        public string PropAddr1 { get; set; }
        public string PropAddr2 { get; set; }
        public string PropAddr3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountyId { get; set; }
        public string ParcelId { get; set; }
        public string PropDesc { get; set; }
        public int? DwellTypeId { get; set; }
        public string LoanNum { get; set; }
        public int? LoanTypeId { get; set; }
        public DateTime? LoanOrigDt { get; set; }
        public double? IntRate { get; set; }
        public double? LoanOrigAmt { get; set; }
        public double? LoanAmt { get; set; }
        public double? UnpaidPrncpl { get; set; }
        public double? LoanCurBal { get; set; }
        public double? PerDiem { get; set; }
        public DateTime? LoanDelinqDt { get; set; }
        public DateTime? LoanClosingDt { get; set; }
        public string FhaLoanNum { get; set; }
        public double? Amt { get; set; }
        public DateTime? TtlContrctDt { get; set; }
        public double? TtlErnstAmt { get; set; }
        public DateTime? TtlErnstRecvdDt { get; set; }
        public int? CurFileStatId { get; set; }
        public DateTime? CurFileStatDt { get; set; }
        public int? FileStatAutoId { get; set; }
        public string ExtId { get; set; }
        public string Cust1 { get; set; }
        public string Cust2 { get; set; }
        public string Cust3 { get; set; }
        public string Cust4 { get; set; }
        public string Cust5 { get; set; }
        public DateTime? ArchDt { get; set; }
        public string ArchBy { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
