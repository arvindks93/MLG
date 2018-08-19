using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class CaseStep
    {
        public int CsAutoId { get; set; }
        public int CaseId { get; set; }
        public int CaseStepId { get; set; }
        public int CaseStepType { get; set; }
        public string Name { get; set; }
        public int? Sord { get; set; }
        public int? Confirmed { get; set; }
        public TimeSpan? CalTime { get; set; }
        public DateTime? PlnStartDt { get; set; }
        public DateTime? PlnEndDt { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public int? VendId { get; set; }
        public int? EntId { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public int? ForceUser { get; set; }
        public int? Quality { get; set; }
        public int? ConfirmedBy { get; set; }
        public DateTime? ConfirmedDt { get; set; }
        public int? StartedBy { get; set; }
        public DateTime? StartedDt { get; set; }
        public int? EndedBy { get; set; }
        public DateTime? EndedDt { get; set; }
        public string Notes { get; set; }
        public string NoteBy { get; set; }
        public DateTime? NoteDt { get; set; }
        public int? PredsDone { get; set; }
        public int? Cancelled { get; set; }
        public int? CvShowNote { get; set; }
        public int? CurStepShowNote { get; set; }
        public string NameEx { get; set; }
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
