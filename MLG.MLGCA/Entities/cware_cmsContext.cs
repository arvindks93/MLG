using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MLG.MLGCA.Entities
{
    public partial class cware_cmsContext : DbContext
    {
        public cware_cmsContext()
        {
        }

        public cware_cmsContext(DbContextOptions<cware_cmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BenLst> BenLst { get; set; }
        public virtual DbSet<CaseLst> CaseLst { get; set; }
        public virtual DbSet<CaseSeqLst> CaseSeqLst { get; set; }
        public virtual DbSet<CaseStep> CaseStep { get; set; }
        public virtual DbSet<CaseStepLst> CaseStepLst { get; set; }
        public virtual DbSet<CaseTypeLst> CaseTypeLst { get; set; }
        public virtual DbSet<ClientLst> ClientLst { get; set; }
        public virtual DbSet<FileCase> FileCase { get; set; }
        public virtual DbSet<FileDebtor> FileDebtor { get; set; }
        public virtual DbSet<FileLst> FileLst { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=172.24.12.4;userid=cware_mtc;password=xespat6A;port=3306;database=cware_cms;sslmode=none;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenLst>(entity =>
            {
                entity.HasKey(e => e.BenId);

                entity.ToTable("ben_lst");

                entity.HasIndex(e => e.CoId)
                    .HasName("i7_ben_lst");

                entity.HasIndex(e => e.CoName)
                    .HasName("i1_ben_lst");

                entity.HasIndex(e => e.CountyId)
                    .HasName("i5_ben_lst");

                entity.HasIndex(e => e.Lname)
                    .HasName("i3_ben_lst");

                entity.HasIndex(e => e.Name)
                    .HasName("i4_ben_lst");

                entity.HasIndex(e => e.State)
                    .HasName("i6_ben_lst");

                entity.HasIndex(e => e.Zip)
                    .HasName("i2_ben_lst");

                entity.Property(e => e.BenId)
                    .HasColumnName("ben_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Addr1)
                    .HasColumnName("addr1")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Addr2)
                    .HasColumnName("addr2")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Addr3)
                    .HasColumnName("addr3")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CoId)
                    .HasColumnName("co_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoName)
                    .HasColumnName("co_name")
                    .HasColumnType("text");

                entity.Property(e => e.CorpTypeId)
                    .HasColumnName("corp_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ElecCheckSig)
                    .HasColumnName("elec_check_sig")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.FedId)
                    .HasColumnName("fed_id")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.HomePh)
                    .HasColumnName("home_ph")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.LegalName)
                    .IsRequired()
                    .HasColumnName("legal_name")
                    .HasColumnType("text");

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Middle)
                    .HasColumnName("middle")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ModSecLvl)
                    .HasColumnName("mod_sec_lvl")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text");

                entity.Property(e => e.Name2)
                    .HasColumnName("name2")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("text");

                entity.Property(e => e.PeoplePrefixId)
                    .HasColumnName("people_prefix_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PeopleSuffixId)
                    .HasColumnName("people_suffix_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.PrtCheckAs)
                    .HasColumnName("prt_check_as")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Ssn)
                    .HasColumnName("ssn")
                    .HasColumnType("text");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StateInc)
                    .HasColumnName("state_inc")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(1)");

                entity.Property(e => e.TermDays)
                    .HasColumnName("term_days")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CaseLst>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("case_lst");

                entity.HasIndex(e => e.AttyId)
                    .HasName("i4_case_lst");

                entity.HasIndex(e => e.AttyId2)
                    .HasName("i5_case_lst");

                entity.HasIndex(e => e.CaseNum)
                    .HasName("i1_case_lst");

                entity.HasIndex(e => e.CaseSeqId)
                    .HasName("i20_case_lst");

                entity.HasIndex(e => e.CaseStatAutoId)
                    .HasName("i11_case_lst");

                entity.HasIndex(e => e.CaseTypeId)
                    .HasName("i18_case_lst");

                entity.HasIndex(e => e.ClientCdId)
                    .HasName("i9_case_lst");

                entity.HasIndex(e => e.ClientId)
                    .HasName("i8_case_lst");

                entity.HasIndex(e => e.ColUserId)
                    .HasName("i6_case_lst");

                entity.HasIndex(e => e.CreateDt)
                    .HasName("i21_case_lst");

                entity.HasIndex(e => e.CurCaseStatId)
                    .HasName("i7_case_lst");

                entity.HasIndex(e => e.ExtId)
                    .HasName("i10_case_lst");

                entity.HasIndex(e => e.InvToBenId)
                    .HasName("i13_case_lst");

                entity.HasIndex(e => e.InvToClientCdId)
                    .HasName("i14_case_lst");

                entity.HasIndex(e => e.InvToDebtorId)
                    .HasName("i15_case_lst");

                entity.HasIndex(e => e.InvToEntId)
                    .HasName("i16_case_lst");

                entity.HasIndex(e => e.InvToVendId)
                    .HasName("i17_case_lst");

                entity.HasIndex(e => e.LoanNum)
                    .HasName("i19_case_lst");

                entity.HasIndex(e => e.RateCdId)
                    .HasName("i12_case_lst");

                entity.HasIndex(e => e.UserId)
                    .HasName("i3_case_lst");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttyId)
                    .HasColumnName("atty_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttyId2)
                    .HasColumnName("atty_id2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BidAmt).HasColumnName("bid_amt");

                entity.Property(e => e.CaseNum)
                    .IsRequired()
                    .HasColumnName("case_num")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseSeqId)
                    .HasColumnName("case_seq_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CaseStatAutoId)
                    .HasColumnName("case_stat_auto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CaseTypeId)
                    .HasColumnName("case_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientCdId)
                    .HasColumnName("client_cd_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColApplyFlatFee)
                    .HasColumnName("col_apply_flat_fee")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ColFeeFlat).HasColumnName("col_fee_flat");

                entity.Property(e => e.ColFeePcnt).HasColumnName("col_fee_pcnt");

                entity.Property(e => e.ColReimburseCosts)
                    .HasColumnName("col_reimburse_costs")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ColRemitGrossNet)
                    .HasColumnName("col_remit_gross_net")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ColUserId)
                    .HasColumnName("col_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurCaseStatDt)
                    .HasColumnName("cur_case_stat_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CurCaseStatId)
                    .HasColumnName("cur_case_stat_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtId)
                    .HasColumnName("ext_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InvToBenId)
                    .HasColumnName("inv_to_ben_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvToClientCdId)
                    .HasColumnName("inv_to_client_cd_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvToDebtorId)
                    .HasColumnName("inv_to_debtor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvToEntId)
                    .HasColumnName("inv_to_ent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvToVendId)
                    .HasColumnName("inv_to_vend_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoanNum)
                    .HasColumnName("loan_num")
                    .HasColumnType("text");

                entity.Property(e => e.LockFeesCost)
                    .HasColumnName("lock_fees_cost")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinOpenDt)
                    .HasColumnName("min_open_dt")
                    .HasColumnType("date");

                entity.Property(e => e.RateCdId)
                    .HasColumnName("rate_cd_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RefCaseNum)
                    .HasColumnName("ref_case_num")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SaleAmt).HasColumnName("sale_amt");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserBarnumId)
                    .HasColumnName("user_barnum_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserBarnumId2)
                    .HasColumnName("user_barnum_id2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CaseSeqLst>(entity =>
            {
                entity.HasKey(e => e.CaseSeqId);

                entity.ToTable("case_seq_lst");

                entity.HasIndex(e => e.ClientId)
                    .HasName("i2_case_seq_lst");

                entity.HasIndex(e => e.EntId)
                    .HasName("i3_case_seq_lst");

                entity.HasIndex(e => e.FinInfoId)
                    .HasName("i1_case_seq_lst");

                entity.HasIndex(e => new { e.CaseTypeId, e.Name })
                    .HasName("u1_case_seq_lst")
                    .IsUnique();

                entity.Property(e => e.CaseSeqId)
                    .HasColumnName("case_seq_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CaseTypeId)
                    .HasColumnName("case_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntId)
                    .HasColumnName("ent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FcstStatChg)
                    .HasColumnName("fcst_stat_chg")
                    .HasColumnType("int(1)");

                entity.Property(e => e.FeeAuthDefShow)
                    .HasColumnName("fee_auth_def_show")
                    .HasColumnType("int(1)");

                entity.Property(e => e.FinInfoId)
                    .HasColumnName("fin_info_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvCd)
                    .HasColumnName("inv_cd")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.LoanTypeId)
                    .HasColumnName("loan_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.SecLvl)
                    .HasColumnName("sec_lvl")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(1)");

                entity.Property(e => e.StdDays)
                    .HasColumnName("std_days")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CaseStep>(entity =>
            {
                entity.HasKey(e => e.CsAutoId);

                entity.ToTable("case_step");

                entity.HasIndex(e => e.CaseId)
                    .HasName("i1_case_step");

                entity.HasIndex(e => e.ClientId)
                    .HasName("i13_case_step");

                entity.HasIndex(e => e.EndDt)
                    .HasName("i5_case_step");

                entity.HasIndex(e => e.EndedDt)
                    .HasName("i7_case_step");

                entity.HasIndex(e => e.EntId)
                    .HasName("i9_case_step");

                entity.HasIndex(e => e.PlnEndDt)
                    .HasName("i8_case_step");

                entity.HasIndex(e => e.PlnStartDt)
                    .HasName("i11_case_step");

                entity.HasIndex(e => e.StartedDt)
                    .HasName("i6_case_step");

                entity.HasIndex(e => e.Udf1)
                    .HasName("i14_case_step");

                entity.HasIndex(e => e.Udf2)
                    .HasName("i15_case_step");

                entity.HasIndex(e => e.Udf3)
                    .HasName("i16_case_step");

                entity.HasIndex(e => e.UserId)
                    .HasName("i4_case_step");

                entity.HasIndex(e => e.VendId)
                    .HasName("i10_case_step");

                entity.HasIndex(e => new { e.CaseId, e.CaseStepId })
                    .HasName("u1_case_step")
                    .IsUnique();

                entity.HasIndex(e => new { e.CaseId, e.Sord })
                    .HasName("i12_case_step");

                entity.HasIndex(e => new { e.CaseStepId, e.CaseId })
                    .HasName("i3_case_step");

                entity.HasIndex(e => new { e.CaseStepId, e.ConfirmedDt })
                    .HasName("i4_assign_load");

                entity.HasIndex(e => new { e.CaseStepId, e.EndDt, e.PredsDone })
                    .HasName("i3_assign_load");

                entity.HasIndex(e => new { e.CaseStepId, e.StartDt, e.PredsDone })
                    .HasName("i2_assign_load");

                entity.HasIndex(e => new { e.EndDt, e.PlnStartDt, e.PredsDone })
                    .HasName("i1_assign_load");

                entity.Property(e => e.CsAutoId)
                    .HasColumnName("cs_auto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalTime)
                    .HasColumnName("cal_time")
                    .HasColumnType("time");

                entity.Property(e => e.Cancelled)
                    .HasColumnName("cancelled")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CaseStepId)
                    .HasColumnName("case_step_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CaseStepType)
                    .HasColumnName("case_step_type")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ConfirmedBy)
                    .HasColumnName("confirmed_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConfirmedDt)
                    .HasColumnName("confirmed_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurStepShowNote)
                    .HasColumnName("cur_step_show_note")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CvShowNote)
                    .HasColumnName("cv_show_note")
                    .HasColumnType("int(1)");

                entity.Property(e => e.EndDt)
                    .HasColumnName("end_dt")
                    .HasColumnType("date");

                entity.Property(e => e.EndedBy)
                    .HasColumnName("ended_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EndedDt)
                    .HasColumnName("ended_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntId)
                    .HasColumnName("ent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ForceUser)
                    .HasColumnName("force_user")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.NameEx)
                    .HasColumnName("name_ex")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.NoteBy)
                    .HasColumnName("note_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.NoteDt)
                    .HasColumnName("note_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("text");

                entity.Property(e => e.PlnEndDt)
                    .HasColumnName("pln_end_dt")
                    .HasColumnType("date");

                entity.Property(e => e.PlnStartDt)
                    .HasColumnName("pln_start_dt")
                    .HasColumnType("date");

                entity.Property(e => e.PredsDone)
                    .HasColumnName("preds_done")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sord)
                    .HasColumnName("sord")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDt)
                    .HasColumnName("start_dt")
                    .HasColumnType("date");

                entity.Property(e => e.StartedBy)
                    .HasColumnName("started_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartedDt)
                    .HasColumnName("started_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Udf1)
                    .HasColumnName("udf_1")
                    .HasColumnType("text");

                entity.Property(e => e.Udf10)
                    .HasColumnName("udf_10")
                    .HasColumnType("text");

                entity.Property(e => e.Udf2)
                    .HasColumnName("udf_2")
                    .HasColumnType("text");

                entity.Property(e => e.Udf3)
                    .HasColumnName("udf_3")
                    .HasColumnType("text");

                entity.Property(e => e.Udf4)
                    .HasColumnName("udf_4")
                    .HasColumnType("text");

                entity.Property(e => e.Udf5)
                    .HasColumnName("udf_5")
                    .HasColumnType("text");

                entity.Property(e => e.Udf6)
                    .HasColumnName("udf_6")
                    .HasColumnType("text");

                entity.Property(e => e.Udf7)
                    .HasColumnName("udf_7")
                    .HasColumnType("text");

                entity.Property(e => e.Udf8)
                    .HasColumnName("udf_8")
                    .HasColumnType("text");

                entity.Property(e => e.Udf9)
                    .HasColumnName("udf_9")
                    .HasColumnType("text");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VendId)
                    .HasColumnName("vend_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CaseStepLst>(entity =>
            {
                entity.HasKey(e => e.CaseStepId);

                entity.ToTable("case_step_lst");

                entity.HasIndex(e => e.DelayCaval)
                    .HasName("i9_case_step_lst");

                entity.HasIndex(e => e.GrpId)
                    .HasName("i4_case_step_lst");

                entity.HasIndex(e => e.GrpIdCaval)
                    .HasName("i11_case_step_lst");

                entity.HasIndex(e => e.MinDaysCaval)
                    .HasName("i8_case_step_lst");

                entity.HasIndex(e => e.MinDelayCaval)
                    .HasName("i10_case_step_lst");

                entity.HasIndex(e => e.NameExCaval)
                    .HasName("i12_case_step_lst");

                entity.HasIndex(e => e.SstChkId)
                    .HasName("i5_case_step_lst");

                entity.HasIndex(e => e.StepToAudId)
                    .HasName("i6_case_step_lst");

                entity.HasIndex(e => e.TgtDaysCaval)
                    .HasName("i7_case_step_lst");

                entity.HasIndex(e => new { e.CaseSeqId, e.Name })
                    .HasName("u1_case_step_lst")
                    .IsUnique();

                entity.HasIndex(e => new { e.CaseSeqId, e.Sord })
                    .HasName("i2_case_step_lst");

                entity.HasIndex(e => new { e.CaseStepId, e.CaseSeqId })
                    .HasName("i3_case_step_lst");

                entity.Property(e => e.CaseStepId)
                    .HasColumnName("case_step_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BeforeOpn)
                    .HasColumnName("before_opn")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Bgcolor)
                    .HasColumnName("bgcolor")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BusDayDelay)
                    .HasColumnName("bus_day_delay")
                    .HasColumnType("int(1)");

                entity.Property(e => e.BusDays)
                    .HasColumnName("bus_days")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CalColor)
                    .HasColumnName("cal_color")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Calendar)
                    .HasColumnName("calendar")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CaseSeqId)
                    .HasColumnName("case_seq_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CaseStepType)
                    .HasColumnName("case_step_type")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ClDeadline)
                    .HasColumnName("cl_deadline")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Confirm)
                    .HasColumnName("confirm")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CreasNoteCatId)
                    .HasColumnName("creas_note_cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreasReq)
                    .HasColumnName("creas_req")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurOnCld)
                    .HasColumnName("cur_on_cld")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CurOnHld)
                    .HasColumnName("cur_on_hld")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CurStepShowNote)
                    .HasColumnName("cur_step_show_note")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CvShowNote)
                    .HasColumnName("cv_show_note")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DayOfWk)
                    .HasColumnName("day_of_wk")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DelayCaval)
                    .HasColumnName("delay_caval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DispPartyLnk)
                    .HasColumnName("disp_party_lnk")
                    .HasColumnType("int(1)");

                entity.Property(e => e.EntCatId)
                    .HasColumnName("ent_cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrpId)
                    .HasColumnName("grp_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrpIdCaval)
                    .HasColumnName("grp_id_caval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HolidayOk)
                    .HasColumnName("holiday_ok")
                    .HasColumnType("int(1)");

                entity.Property(e => e.MajorMilestone)
                    .HasColumnName("major_milestone")
                    .HasColumnType("int(1)");

                entity.Property(e => e.MaxRfcstCnt)
                    .HasColumnName("max_rfcst_cnt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxRfcstDays)
                    .HasColumnName("max_rfcst_days")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxRfcstSl)
                    .HasColumnName("max_rfcst_sl")
                    .HasColumnType("int(1)");

                entity.Property(e => e.MinDays)
                    .HasColumnName("min_days")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinDaysCaval)
                    .HasColumnName("min_days_caval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinDelay)
                    .HasColumnName("min_delay")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinDelayCaval)
                    .HasColumnName("min_delay_caval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MspCatId)
                    .HasColumnName("msp_cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MspTrkFailAttps)
                    .HasColumnName("msp_trk_fail_attps")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.NameExCaval)
                    .HasColumnName("name_ex_caval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("text");

                entity.Property(e => e.Req)
                    .HasColumnName("req")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ReqDt)
                    .HasColumnName("req_dt")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ReqNote)
                    .HasColumnName("req_note")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Responsible)
                    .IsRequired()
                    .HasColumnName("responsible")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SaleStep)
                    .HasColumnName("sale_step")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SecLvl)
                    .HasColumnName("sec_lvl")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Sord)
                    .HasColumnName("sord")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SstChkId)
                    .HasColumnName("sst_chk_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StDeadline)
                    .HasColumnName("st_deadline")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(1)");

                entity.Property(e => e.StatusColorOvr)
                    .HasColumnName("status_color_ovr")
                    .HasColumnType("int(1)");

                entity.Property(e => e.StepToAudId)
                    .HasColumnName("step_to_aud_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TgtDays)
                    .HasColumnName("tgt_days")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TgtDaysCaval)
                    .HasColumnName("tgt_days_caval")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeDef)
                    .HasColumnName("time_def")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Udf1)
                    .HasColumnName("udf_1")
                    .HasColumnType("text");

                entity.Property(e => e.Udf10)
                    .HasColumnName("udf_10")
                    .HasColumnType("text");

                entity.Property(e => e.Udf2)
                    .HasColumnName("udf_2")
                    .HasColumnType("text");

                entity.Property(e => e.Udf3)
                    .HasColumnName("udf_3")
                    .HasColumnType("text");

                entity.Property(e => e.Udf4)
                    .HasColumnName("udf_4")
                    .HasColumnType("text");

                entity.Property(e => e.Udf5)
                    .HasColumnName("udf_5")
                    .HasColumnType("text");

                entity.Property(e => e.Udf6)
                    .HasColumnName("udf_6")
                    .HasColumnType("text");

                entity.Property(e => e.Udf7)
                    .HasColumnName("udf_7")
                    .HasColumnType("text");

                entity.Property(e => e.Udf8)
                    .HasColumnName("udf_8")
                    .HasColumnType("text");

                entity.Property(e => e.Udf9)
                    .HasColumnName("udf_9")
                    .HasColumnType("text");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.VendCatId)
                    .HasColumnName("vend_cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WkDay)
                    .HasColumnName("wk_day")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<CaseTypeLst>(entity =>
            {
                entity.HasKey(e => e.CaseTypeId);

                entity.ToTable("case_type_lst");

                entity.HasIndex(e => e.CoId)
                    .HasName("i1_case_type_lst");

                entity.HasIndex(e => e.Name)
                    .HasName("u1_case_type_lst")
                    .IsUnique();

                entity.Property(e => e.CaseTypeId)
                    .HasColumnName("case_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoCd)
                    .HasColumnName("auto_cd")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CaModule)
                    .HasColumnName("ca_module")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CasePurch)
                    .HasColumnName("case_purch")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CaseSaleFlg)
                    .HasColumnName("case_sale_flg")
                    .HasColumnType("int(1)");

                entity.Property(e => e.CoId)
                    .HasColumnName("co_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FinInfoFlg)
                    .HasColumnName("fin_info_flg")
                    .HasColumnType("int(1)");

                entity.Property(e => e.LossMitFlg)
                    .HasColumnName("loss_mit_flg")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RateCdReq)
                    .HasColumnName("rate_cd_req")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ClientLst>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("client_lst");

                entity.HasIndex(e => e.CoId)
                    .HasName("i7_client_lst");

                entity.HasIndex(e => e.CoName)
                    .HasName("i1_client_lst");

                entity.HasIndex(e => e.CountyId)
                    .HasName("i5_client_lst");

                entity.HasIndex(e => e.Lname)
                    .HasName("i3_client_lst");

                entity.HasIndex(e => e.Name)
                    .HasName("i4_client_lst");

                entity.HasIndex(e => e.State)
                    .HasName("i6_client_lst");

                entity.HasIndex(e => e.Zip)
                    .HasName("i2_client_lst");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddAllCont)
                    .HasColumnName("add_all_cont")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Addr1)
                    .HasColumnName("addr1")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Addr2)
                    .HasColumnName("addr2")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Addr3)
                    .HasColumnName("addr3")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AutoCd)
                    .HasColumnName("auto_cd")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.BillFlag)
                    .HasColumnName("bill_flag")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ClientCatId)
                    .HasColumnName("client_cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientCompany)
                    .HasColumnName("client_company")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.CoId)
                    .HasColumnName("co_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoName)
                    .HasColumnName("co_name")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.ColApplyFlatFee)
                    .HasColumnName("col_apply_flat_fee")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ColFeeFlat).HasColumnName("col_fee_flat");

                entity.Property(e => e.ColFeePcnt).HasColumnName("col_fee_pcnt");

                entity.Property(e => e.ColReimburseCosts)
                    .HasColumnName("col_reimburse_costs")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ColRemitGrossNet)
                    .HasColumnName("col_remit_gross_net")
                    .HasColumnType("char(1)");

                entity.Property(e => e.CorpTypeId)
                    .HasColumnName("corp_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ElecCheckSig)
                    .HasColumnName("elec_check_sig")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.FedId)
                    .HasColumnName("fed_id")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.HomePh)
                    .HasColumnName("home_ph")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.HrFeeAuthReq)
                    .HasColumnName("hr_fee_auth_req")
                    .HasColumnType("int(1)");

                entity.Property(e => e.LegalName)
                    .HasColumnName("legal_name")
                    .HasColumnType("text");

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LossMitPh)
                    .HasColumnName("loss_mit_ph")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.MarketRep)
                    .HasColumnName("market_rep")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Middle)
                    .HasColumnName("middle")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ModSecLvl)
                    .HasColumnName("mod_sec_lvl")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text");

                entity.Property(e => e.Note2)
                    .HasColumnName("note2")
                    .HasColumnType("text");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("text");

                entity.Property(e => e.Originator)
                    .HasColumnName("originator")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.PeoplePrefixId)
                    .HasColumnName("people_prefix_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PeopleSuffixId)
                    .HasColumnName("people_suffix_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.PrefCloser)
                    .HasColumnName("pref_closer")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrtAddressAs)
                    .HasColumnName("prt_address_as")
                    .HasColumnType("text");

                entity.Property(e => e.PrtCheckAs)
                    .HasColumnName("prt_check_as")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.SignAs)
                    .HasColumnName("sign_as")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Ssn)
                    .HasColumnName("ssn")
                    .HasColumnType("text");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StateInc)
                    .HasColumnName("state_inc")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(1)");

                entity.Property(e => e.TermDays)
                    .HasColumnName("term_days")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Udf1)
                    .HasColumnName("udf_1")
                    .HasColumnType("text");

                entity.Property(e => e.Udf10)
                    .HasColumnName("udf_10")
                    .HasColumnType("text");

                entity.Property(e => e.Udf2)
                    .HasColumnName("udf_2")
                    .HasColumnType("text");

                entity.Property(e => e.Udf3)
                    .HasColumnName("udf_3")
                    .HasColumnType("text");

                entity.Property(e => e.Udf4)
                    .HasColumnName("udf_4")
                    .HasColumnType("text");

                entity.Property(e => e.Udf5)
                    .HasColumnName("udf_5")
                    .HasColumnType("text");

                entity.Property(e => e.Udf6)
                    .HasColumnName("udf_6")
                    .HasColumnType("text");

                entity.Property(e => e.Udf7)
                    .HasColumnName("udf_7")
                    .HasColumnType("text");

                entity.Property(e => e.Udf8)
                    .HasColumnName("udf_8")
                    .HasColumnType("text");

                entity.Property(e => e.Udf9)
                    .HasColumnName("udf_9")
                    .HasColumnType("text");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseRefAddrInv)
                    .HasColumnName("use_ref_addr_inv")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<FileCase>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.CaseId });

                entity.ToTable("file_case");

                entity.HasIndex(e => e.CaseId)
                    .HasName("i1_file_case");

                entity.HasIndex(e => e.FileId)
                    .HasName("i2_file_case");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FileDebtor>(entity =>
            {
                entity.ToTable("file_debtor");

                entity.HasIndex(e => e.DebtorClassId)
                    .HasName("i1_file_debtor");

                entity.HasIndex(e => e.DebtorId)
                    .HasName("i2_file_debtor");

                entity.HasIndex(e => new { e.DebtorId, e.FileId })
                    .HasName("i3_file_debtor");

                entity.HasIndex(e => new { e.FileId, e.DebtorId, e.DebtorClassId })
                    .HasName("u1_file_debtor")
                    .IsUnique();

                entity.Property(e => e.FileDebtorId)
                    .HasColumnName("file_debtor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DebtorClassId)
                    .HasColumnName("debtor_class_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DebtorId)
                    .HasColumnName("debtor_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NoToClosed)
                    .HasColumnName("no_to_closed")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ProSe)
                    .HasColumnName("pro_se")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Sord)
                    .HasColumnName("sord")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FileLst>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("file_lst");

                entity.HasIndex(e => e.ArchDt)
                    .HasName("i19_file_lst");

                entity.HasIndex(e => e.BenId)
                    .HasName("i6_file_lst");

                entity.HasIndex(e => e.City)
                    .HasName("i16_file_lst");

                entity.HasIndex(e => e.ClientCdId)
                    .HasName("i12_file_lst");

                entity.HasIndex(e => e.ClientId)
                    .HasName("i5_file_lst");

                entity.HasIndex(e => e.CountyId)
                    .HasName("i14_file_lst");

                entity.HasIndex(e => e.CurFileStatId)
                    .HasName("i2_file_lst");

                entity.HasIndex(e => e.DwellTypeId)
                    .HasName("i10_file_lst");

                entity.HasIndex(e => e.ExtId)
                    .HasName("i13_file_lst");

                entity.HasIndex(e => e.FhaLoanNum)
                    .HasName("i17_file_lst");

                entity.HasIndex(e => e.FileNum)
                    .HasName("u1_file_lst")
                    .IsUnique();

                entity.HasIndex(e => e.GrpId)
                    .HasName("i18_file_lst");

                entity.HasIndex(e => e.LoanNum)
                    .HasName("i8_file_lst");

                entity.HasIndex(e => e.LoanTypeId)
                    .HasName("i15_file_lst");

                entity.HasIndex(e => e.PropAddr1)
                    .HasName("i7_file_lst");

                entity.HasIndex(e => e.PropId)
                    .HasName("i11_file_lst");

                entity.HasIndex(e => e.SecLvl)
                    .HasName("i4_file_lst");

                entity.HasIndex(e => e.SiteId)
                    .HasName("i3_file_lst");

                entity.HasIndex(e => e.State)
                    .HasName("i9_file_lst");

                entity.HasIndex(e => e.Zip)
                    .HasName("i1_file_lst");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amt).HasColumnName("amt");

                entity.Property(e => e.ArchBy)
                    .HasColumnName("arch_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.ArchDt)
                    .HasColumnName("arch_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenId)
                    .HasColumnName("ben_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ClientCdId)
                    .HasColumnName("client_cd_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurFileStatDt)
                    .HasColumnName("cur_file_stat_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurFileStatId)
                    .HasColumnName("cur_file_stat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cust1)
                    .HasColumnName("cust_1")
                    .HasColumnType("text");

                entity.Property(e => e.Cust2)
                    .HasColumnName("cust_2")
                    .HasColumnType("text");

                entity.Property(e => e.Cust3)
                    .HasColumnName("cust_3")
                    .HasColumnType("text");

                entity.Property(e => e.Cust4)
                    .HasColumnName("cust_4")
                    .HasColumnType("text");

                entity.Property(e => e.Cust5)
                    .HasColumnName("cust_5")
                    .HasColumnType("text");

                entity.Property(e => e.DwellTypeId)
                    .HasColumnName("dwell_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExtId)
                    .HasColumnName("ext_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FhaLoanNum)
                    .HasColumnName("fha_loan_num")
                    .HasColumnType("text");

                entity.Property(e => e.FileNum)
                    .IsRequired()
                    .HasColumnName("file_num")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileStatAutoId)
                    .HasColumnName("file_stat_auto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.GrpId)
                    .HasColumnName("grp_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntRate).HasColumnName("int_rate");

                entity.Property(e => e.LoanAmt).HasColumnName("loan_amt");

                entity.Property(e => e.LoanClosingDt)
                    .HasColumnName("loan_closing_dt")
                    .HasColumnType("date");

                entity.Property(e => e.LoanCurBal).HasColumnName("loan_cur_bal");

                entity.Property(e => e.LoanDelinqDt)
                    .HasColumnName("loan_delinq_dt")
                    .HasColumnType("date");

                entity.Property(e => e.LoanNum)
                    .HasColumnName("loan_num")
                    .HasColumnType("text");

                entity.Property(e => e.LoanOrigAmt).HasColumnName("loan_orig_amt");

                entity.Property(e => e.LoanOrigDt)
                    .HasColumnName("loan_orig_dt")
                    .HasColumnType("date");

                entity.Property(e => e.LoanTypeId)
                    .HasColumnName("loan_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParcelId)
                    .HasColumnName("parcel_id")
                    .HasColumnType("text");

                entity.Property(e => e.PerDiem)
                    .HasColumnName("per_diem")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PropAddr1)
                    .HasColumnName("prop_addr1")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PropAddr2)
                    .HasColumnName("prop_addr2")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PropAddr3)
                    .HasColumnName("prop_addr3")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PropDesc)
                    .HasColumnName("prop_desc")
                    .HasColumnType("text");

                entity.Property(e => e.PropId)
                    .HasColumnName("prop_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoGrpId)
                    .HasColumnName("ro_grp_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SecLvl)
                    .HasColumnName("sec_lvl")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SiteId)
                    .HasColumnName("site_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TtlContrctDt)
                    .HasColumnName("ttl_contrct_dt")
                    .HasColumnType("date");

                entity.Property(e => e.TtlErnstAmt).HasColumnName("ttl_ernst_amt");

                entity.Property(e => e.TtlErnstRecvdDt)
                    .HasColumnName("ttl_ernst_recvd_dt")
                    .HasColumnType("date");

                entity.Property(e => e.UnpaidPrncpl).HasColumnName("unpaid_prncpl");

                entity.Property(e => e.UpdBy)
                    .HasColumnName("upd_by")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.UpdDt)
                    .HasColumnName("upd_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}
