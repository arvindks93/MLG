using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class CaseStepLst
    {
        public int CaseStepId { get; set; }
        public int CaseSeqId { get; set; }
        public int? CaseStepType { get; set; }
        public int? MspCatId { get; set; }
        public int? MspTrkFailAttps { get; set; }
        public string Name { get; set; }
        public int Sord { get; set; }
        public int? SecLvl { get; set; }
        public int? Confirm { get; set; }
        public int? Calendar { get; set; }
        public string TimeDef { get; set; }
        public int? Req { get; set; }
        public int? CreasReq { get; set; }
        public int? CreasNoteCatId { get; set; }
        public int? BeforeOpn { get; set; }
        public int? HolidayOk { get; set; }
        public int? TgtDays { get; set; }
        public int? TgtDaysCaval { get; set; }
        public int? MinDays { get; set; }
        public int? MinDaysCaval { get; set; }
        public int? WkDay { get; set; }
        public int? ReqDt { get; set; }
        public int? DayOfWk { get; set; }
        public int? CurOnHld { get; set; }
        public int? CurOnCld { get; set; }
        public string Responsible { get; set; }
        public int? VendCatId { get; set; }
        public int? EntCatId { get; set; }
        public int? GrpId { get; set; }
        public int? GrpIdCaval { get; set; }
        public int? Delay { get; set; }
        public int? DelayCaval { get; set; }
        public int? MinDelay { get; set; }
        public int? MinDelayCaval { get; set; }
        public string Bgcolor { get; set; }
        public string CalColor { get; set; }
        public int? StatusColorOvr { get; set; }
        public int? ReqNote { get; set; }
        public int? BusDays { get; set; }
        public int? BusDayDelay { get; set; }
        public int? SstChkId { get; set; }
        public int? MaxRfcstCnt { get; set; }
        public int? MaxRfcstDays { get; set; }
        public int? MaxRfcstSl { get; set; }
        public int? DispPartyLnk { get; set; }
        public int? StDeadline { get; set; }
        public int? ClDeadline { get; set; }
        public int? StepToAudId { get; set; }
        public int? SaleStep { get; set; }
        public int? MajorMilestone { get; set; }
        public string Notes { get; set; }
        public int? NameExCaval { get; set; }
        public int? CvShowNote { get; set; }
        public int? CurStepShowNote { get; set; }
        public int? Status { get; set; }
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
