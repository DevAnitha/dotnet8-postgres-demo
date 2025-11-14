using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact.Domain.Entities
{
    [Table("coreidentity", Schema = "person")]
    public class CoreIdentity
    {
        [Key]
        [Column("core_identity_id")]
        public int CoreIdentityId { get; set; }

        [Column("firstname")]
        public string? FirstName { get; set; }

        [Column("middlename")]
        public string? MiddleName { get; set; }

        [Column("lastname")]
        public string? LastName { get; set; }

        public int? PrefixId { get; set; }
        public Prefix? Prefix { get; set; }

        public int? SuffixId { get; set; }
        public Suffix? Suffix { get; set; }

        [Column("dob")]
        public DateTime? DateOfBirth { get; set; }

        [Column("ssn")]
        public string? Ssn { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        public int? GeographyId { get; set; }
        public Geography? GeographyOfBirth { get; set; }

        // --- Created ---
        [Column("createdby")]
        public string? CreatedBy { get; set; }

        [Column("createddate")]
        public DateTime CreatedDate { get; set; }

        [Column("createdip")]
        public string? CreatedIp { get; set; }

        // --- Updated ---
        [Column("updatedby")]
        public string? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("updatedip")]
        public string? UpdatedIp { get; set; }

        // --- Deleted ---
        [Column("deletedby")]
        public string? DeletedBy { get; set; }

        [Column("deleteddate")]
        public DateTime? DeletedDate { get; set; }

        [Column("deletedip")]
        public string? DeletedIp { get; set; }

        // --- Archived ---
        [Column("archivedby")]
        public string? ArchivedBy { get; set; }

        [Column("archiveddate")]
        public DateTime? ArchivedDate { get; set; }

        [Column("archivedip")]
        public string? ArchivedIp { get; set; }
    }
}
