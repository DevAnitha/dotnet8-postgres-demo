using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrApp.Infrastructure.Entities
{
    // ===========================
    // affix
    // ===========================
    [Table("affix", Schema = "public")]
    public class Affix
    {
        [Key]
        [Column("affixid")]
        public Guid AffixId { get; set; }

        [Column("affixtype")]
        [StringLength(100)]
        public string? AffixType { get; set; }

        [Column("affixvalue")]
        [StringLength(50)]
        public string? AffixValue { get; set; }

        [Column("status")]
        public int? Status { get; set; }

        [Column("sortorder")]
        public int? SortOrder { get; set; }

        [Column("createdby")]
        public int? CreatedBy { get; set; }

        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

        [Column("createdbymachine")]
        [StringLength(255)]
        public string? CreatedByMachine { get; set; }

        [Column("updateddby")]
        public int? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("updateddbymachine")]
        [StringLength(255)]
        public string? UpdatedByMachine { get; set; }

        [Column("deletedby")]
        public int? DeletedBy { get; set; }

        [Column("deleteddate")]
        public DateTime? DeletedDate { get; set; }

        [Column("deletedbymachine")]
        [StringLength(255)]
        public string? DeletedByMachine { get; set; }

        [Column("archivedby")]
        public int? ArchivedBy { get; set; }

        [Column("archiveddate")]
        public DateTime? ArchivedDate { get; set; }

        [Column("archivedbymachine")]
        [StringLength(255)]
        public string? ArchivedByMachine { get; set; }

        [Column("datestamp")]
        public DateTime? DateStamp { get; set; }
    }

    // ===========================
    // audit
    // ===========================
    [Table("audit", Schema = "public")]
    public class Audit
    {
        [Key]
        [Column("auditid")]
        public Guid AuditId { get; set; }

        [Column("table_name")]
        public string TableName { get; set; } = null!;

        [Column("column_name")]
        public string ColumnName { get; set; } = null!;

        [Column("action")]
        public string ActionName { get; set; } = null!;

        [Column("record_id")]
        public int RecordId { get; set; }

        [Column("ein")]
        public int? Ein { get; set; }

        [Column("actor_ein")]
        public int? ActorEin { get; set; }

        // stored as jsonb in DB – map as string or JsonDocument if you prefer
        [Column("before_data")]
        public string? BeforeData { get; set; }

        [Column("after_data")]
        public string? AfterData { get; set; }

        [Column("ip_address")]
        public string? IpAddress { get; set; }

        [Column("action_timestamp")]
        public DateTime? ActionTimestamp { get; set; }
    }

    // ===========================
    // auditallactivity
    // ===========================
    [Table("auditallactivity", Schema = "public")]
    public class AuditAllActivity
    {
        [Key]
        [Column("auditid")]
        public Guid AuditId { get; set; }

        [Column("table_name")]
        public string TableName { get; set; } = null!;

        [Column("column_name")]
        public string ColumnName { get; set; } = null!;

        [Column("action")]
        public string ActionName { get; set; } = null!;

        [Column("record_id")]
        public int RecordId { get; set; }

        [Column("ein")]
        public int? Ein { get; set; }

        [Column("actor_ein")]
        public int? ActorEin { get; set; }

        [Column("before_data")]
        public string? BeforeData { get; set; }

        [Column("after_data")]
        public string? AfterData { get; set; }

        [Column("ip_address")]
        public string? IpAddress { get; set; }

        [Column("action_timestamp")]
        public DateTime? ActionTimestamp { get; set; }
    }

    // ===========================
    // coreidentity
    // ===========================
    [Table("coreidentity", Schema = "public")]
    public class CoreIdentity
    {
        [Key]
        [Column("coreidentityid")]
        public Guid CoreIdentityId { get; set; }

        [Column("ein")]
        public int Ein { get; set; }

        [Column("prefixid")]
        public int? PrefixId { get; set; }

        [Column("firstname")]
        [StringLength(225)]
        public string? FirstName { get; set; }

        [Column("middlename")]
        [StringLength(225)]
        public string? MiddleName { get; set; }

        [Column("NMN")]
        public bool? Nmn { get; set; }

        [Column("lastname")]
        [StringLength(255)]
        public string? LastName { get; set; }

        [Column("preferredname")]
        [StringLength(225)]
        public string? PreferredName { get; set; }

        [Column("formerlastname")]
        [StringLength(225)]
        public string? FormerLastName { get; set; }

        [Column("suffixid")]
        public int? SuffixId { get; set; }

        [Column("dateofbirth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("ssn")]
        [StringLength(9)]
        public string Ssn { get; set; } = null!;

        [Column("countryofbirthid")]
        public int? CountryOfBirthId { get; set; }

        [Column("sex")]
        [StringLength(10)]
        public string? Sex { get; set; }

        [Column("status")]
        public int? Status { get; set; }

        [Column("createdby")]
        public int? CreatedBy { get; set; }

        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

        [Column("createdbymachine")]
        [StringLength(255)]
        public string? CreatedByMachine { get; set; }

        [Column("updateddby")]
        public int? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("updateddbymachine")]
        [StringLength(255)]
        public string? UpdatedByMachine { get; set; }

        [Column("deletedby")]
        public int? DeletedBy { get; set; }

        [Column("deleteddate")]
        public DateTime? DeletedDate { get; set; }

        [Column("deletedbymachine")]
        [StringLength(255)]
        public string? DeletedByMachine { get; set; }

        [Column("archivedby")]
        public int? ArchivedBy { get; set; }

        [Column("archiveddate")]
        public DateTime? ArchivedDate { get; set; }

        [Column("archivedbymachine")]
        [StringLength(255)]
        public string? ArchivedByMachine { get; set; }

        [Column("datestamp")]
        public DateTime? DateStamp { get; set; }

        [Column("flag")]
        [StringLength(50)]
        public string? Flag { get; set; }
    }

    // ===========================
    // phonetype
    // ===========================
    [Table("phonetype", Schema = "public")]
    public class PhoneType
    {
        [Key]
        [Column("phonetypeid")]
        public int PhoneTypeId { get; set; }

        [Column("phonetype")]
        [StringLength(50)]
        public string PhoneTypeName { get; set; } = null!;

        [Column("status")]
        public int? Status { get; set; }

        [Column("sortorder")]
        public int? SortOrder { get; set; }

        [Column("createdby")]
        public int? CreatedBy { get; set; }

        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

        [Column("createdbymachine")]
        [StringLength(255)]
        public string? CreatedByMachine { get; set; }

        [Column("updateddby")]
        public int? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("updateddbymachine")]
        [StringLength(255)]
        public string? UpdatedByMachine { get; set; }

        [Column("deletedby")]
        public int? DeletedBy { get; set; }

        [Column("deleteddate")]
        public DateTime? DeletedDate { get; set; }

        [Column("deletedbymachine")]
        [StringLength(255)]
        public string? DeletedByMachine { get; set; }

        [Column("archivedby")]
        public int? ArchivedBy { get; set; }

        [Column("archiveddate")]
        public DateTime? ArchivedDate { get; set; }

        [Column("archivedbymachine")]
        [StringLength(255)]
        public string? ArchivedByMachine { get; set; }

        [Column("datestamp")]
        public DateTime? DateStamp { get; set; }
    }

    // ===========================
    // address
    // ===========================
    [Table("address", Schema = "public")]
    public class Address
    {
        [Key]
        [Column("addressid")]
        public int AddressId { get; set; }

        [Column("coreidentityid")]
        public Guid CoreIdentityId { get; set; }

        [Column("addresstype")]
        [StringLength(50)]
        public string? AddressType { get; set; }

        [Column("address")]
        [StringLength(255)]
        public string AddressLine { get; set; } = null!;

        [Column("city")]
        [StringLength(255)]
        public string? City { get; set; }

        [Column("zip")]
        [StringLength(10)]
        public string? Zip { get; set; }

        [Column("state")]
        [StringLength(50)]
        public string? State { get; set; }

        [Column("public")]
        public bool? IsPublic { get; set; }

        [Column("is_primary")]
        public bool? IsPrimary { get; set; }

        [Column("status")]
        public int? Status { get; set; }

        [Column("sortorder")]
        public int? SortOrder { get; set; }

        [Column("createdby")]
        public int? CreatedBy { get; set; }

        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

        [Column("createdbymachine")]
        [StringLength(255)]
        public string? CreatedByMachine { get; set; }

        [Column("updateddby")]
        public int? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("updateddbymachine")]
        [StringLength(255)]
        public string? UpdatedByMachine { get; set; }

        [Column("deletedby")]
        public int? DeletedBy { get; set; }

        [Column("deleteddate")]
        public DateTime? DeletedDate { get; set; }

        [Column("deletedbymachine")]
        [StringLength(255)]
        public string? DeletedByMachine { get; set; }

        [Column("archivedby")]
        public int? ArchivedBy { get; set; }

        [Column("archiveddate")]
        public DateTime? ArchivedDate { get; set; }

        [Column("archivedbymachine")]
        [StringLength(255)]
        public string? ArchivedByMachine { get; set; }

        [Column("datestamp")]
        public DateTime? DateStamp { get; set; }
    }

    // ===========================
    // assignment
    // ===========================
    [Table("assignment", Schema = "public")]
    public class Assignment
    {
        [Key]
        [Column("assignmentid")]
        public Guid AssignmentId { get; set; }

        [Column("coreidentityid")]
        public Guid CoreIdentityId { get; set; }

        [Column("positionid")]
        public Guid PositionId { get; set; }

        [Column("locationid")]
        public Guid LocationId { get; set; }

        [Column("hiredate")]
        public DateTime HireDate { get; set; }

        [Column("enddate")]
        public DateTime? EndDate { get; set; }

        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; } = null!;

        [Column("createdby")]
        public Guid CreatedBy { get; set; }

        [Column("createddate")]
        public DateTime CreatedDate { get; set; }

        [Column("createdbymachine")]
        [StringLength(255)]
        public string CreatedByMachine { get; set; } = null!;

        [Column("updateddby")]
        public Guid? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("updateddbymachine")]
        [StringLength(255)]
        public string? UpdatedByMachine { get; set; }

        [Column("deletedby")]
        public Guid? DeletedBy { get; set; }

        [Column("deleteddate")]
        public DateTime? DeletedDate { get; set; }

        [Column("deletedbymachine")]
        [StringLength(255)]
        public string? DeletedByMachine { get; set; }

        [Column("archivedby")]
        public Guid? ArchivedBy { get; set; }

        [Column("archiveddate")]
        public DateTime? ArchivedDate { get; set; }

        [Column("archivedbymachine")]
        [StringLength(255)]
        public string? ArchivedByMachine { get; set; }

        [Column("datestamp")]
        public DateTime DateStamp { get; set; }
    }

    // ===========================
    // assignmentcontractor
    // ===========================
    [Table("assignmentcontractor", Schema = "public")]
    public class AssignmentContractor
    {
        [Key]
        [Column("assignmentcontractorid")]
        public Guid AssignmentContractorId { get; set; }

        [Column("coreidentityid")]
        public Guid CoreIdentityId { get; set; }

        [Column("contractid")]
        [StringLength(50)]
        public string ContractId { get; set; } = null!;

        [Column("vendorid")]
        public Guid VendorId { get; set; }

        [Column("cor")]
        public int Cor { get; set; }

        [Column("acor")]
        public Guid? Acor { get; set; }

        [Column("contractoronsitefrequency")]
        [StringLength(50)]
        public string? ContractorOnsiteFrequency { get; set; }

        [Column("createdby")]
        public int CreatedBy { get; set; }

        [Column("createddate")]
        public DateTime CreatedDate { get; set; }

        [Column("createdbymachine")]
        [StringLength(255)]
        public string CreatedByMachine { get; set; } = null!;

        [Column("updateddby")]
        public int? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("u]()
////////////////////////////////////////
/// 


namespace YourNamespace.Entities;

[Table("separation_initiation")]
public class SeparationInitiation : FullAuditEntity
{
    [Key]
    [Column("separation_initiation_id")]
    public int SeparationInitiationId { get; set; }

    [Column("core_identity_id")]
    public int CoreIdentityId { get; set; }

    // supervisor_id is also a CoreIdentity person
    [Column("supervisor_id")]
    public int? SupervisorId { get; set; }

    [Column("last_day")]
    public DateTime? LastDay { get; set; }

    [Column("separation_date")]
    public DateTime? SeparationDate { get; set; }

    // Lookup FK (was shown as "separation_type text fk lookup" in the sheet)
    [Column("separation_type_id")]
    public int? SeparationTypeId { get; set; }

    [Column("reason_for_separation")]
    public string? ReasonForSeparation { get; set; }

    [Column("notify_employee")]
    public bool NotifyEmployee { get; set; }

    [Column("instant_separation")]
    public bool InstantSeparation { get; set; }

    [Column("additional_notes")]
    public string? AdditionalNotes { get; set; }

    // Lookup FK (was shown as "separation_status text fk lookup" in the sheet)
    [Column("separation_status_id")]
    public int? SeparationStatusId { get; set; }

    [Column("record_status_id")]
    public int? RecordStatusId { get; set; }

    // Navigation properties
    public CoreIdentity CoreIdentity { get; set; } = null!;
    public CoreIdentity? Supervisor { get; set; }

    public SeparationType? SeparationType { get; set; }
    public SeparationStatus? SeparationStatus { get; set; }
    public RecordStatus? RecordStatus { get; set; }
}