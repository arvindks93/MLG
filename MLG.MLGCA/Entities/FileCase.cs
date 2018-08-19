using System;
using System.Collections.Generic;

namespace MLG.MLGCA.Entities
{
    public partial class FileCase
    {
        public int FileId { get; set; }
        public int CaseId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime? UpdDt { get; set; }
    }
}
