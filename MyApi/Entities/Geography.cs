using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact.Domain.Entities
{
    [Table("geography", Schema = "person")]
    public class Geography
    {
        [Key]
        [Column("geography_id")]
        public int GeographyId { get; set; }

        [Column("geographytype_id")]
        public int GeographyTypeId { get; set; }   // e.g. Country, State, City

        [Column("name")]
        public string Name { get; set; } = null!;  // e.g. "Texas", "Chennai"

        [Column("abbreviation")]
        public string? Abbreviation { get; set; }  // e.g. "TX"

        // Self-referencing parent
        [Column("parent_geography_id")]
        public int? ParentGeographyId { get; set; }
        public Geography? ParentGeography { get; set; }

        public ICollection<Geography> Children { get; set; } = new List<Geography>();

        [Column("status_id")]
        public int StatusId { get; set; }          // e.g. Active / Inactive

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

        // Navigation from CoreIdentity side
        public ICollection<CoreIdentity> CoreIdentities { get; set; } = new List<CoreIdentity>();
    }
}
