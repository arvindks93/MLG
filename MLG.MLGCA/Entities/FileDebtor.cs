using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class FileDebtor
    {
        public int FileDebtorId { get; set; }
        public int FileId { get; set; }
        public int DebtorId { get; set; }
        public int DebtorClassId { get; set; }
        public int? ProSe { get; set; }
        public int? NoToClosed { get; set; }
        public string Notes { get; set; }
        public int? Sord { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
