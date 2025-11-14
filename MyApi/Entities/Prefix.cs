using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact.Domain.Entities
{
    [Table("prefix", Schema = "person")]
    public class Prefix
    {
        [Key]
        [Column("prefix_id")]
        public int PrefixId { get; set; }

        [Column("code")]
        public string Code { get; set; } = null!;

        [Column("description")]
        public string? Description { get; set; }

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

        // Navigation
        public ICollection<CoreIdentity> CoreIdentities { get; set; } = new List<CoreIdentity>();
    }
}
