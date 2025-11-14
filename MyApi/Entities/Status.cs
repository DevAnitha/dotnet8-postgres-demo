using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact.Domain.Entities
{
    [Table("status", Schema = "person")]
    public class Status
    {
        [Key]
        [Column("status_id")]
        public int StatusId { get; set; }          // e.g. 1 = Active, 2 = Inactive

        [Column("code")]
        public string Code { get; set; } = null!;  // "ACTIVE", "INACTIVE"

        [Column("name")]
        public string Name { get; set; } = null!;  // "Active", "Inactive"

        [Column("description")]
        public string? Description { get; set; }

        // Audit fields
        [Column("createdby")]
        public string? CreatedBy { get; set; }

        [Column("createddate")]
        public DateTime CreatedDate { get; set; }

        [Column("createdip")]
        public string? CreatedIp { get; set; }

        [Column("updatedby")]
        public string? UpdatedBy { get; set; }

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("updatedip")]
        public string? UpdatedIp { get; set; }

        [Column("deletedby")]
        public string? DeletedBy { get; set; }

        [Column("deleteddate")]
        public DateTime? DeletedDate { get; set; }

        [Column("deletedip")]
        public string? DeletedIp { get; set; }

        [Column("archivedby")]
        public string? ArchivedBy { get; set; }

        [Column("archiveddate")]
        public DateTime? ArchivedDate { get; set; }

        [Column("archivedip")]
        public string? ArchivedIp { get; set; }

        // Navigation: one Status -> many Geographies
        public ICollection<Geography> Geographies { get; set; } = new List<Geography>();
    }
}
