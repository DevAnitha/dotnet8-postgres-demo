using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contact.Domain.Entities
{
    [Table("geographytype", Schema = "person")]
    public class GeographyType
    {
        [Key]
        [Column("geographytype_id")]
        public int GeographyTypeId { get; set; }   // e.g. 1 = Country, 2 = State, 3 = City

        [Column("code")]
        public string Code { get; set; } = null!;  // "COUNTRY", "STATE", "CITY"

        [Column("name")]
        public string Name { get; set; } = null!;  // "Country", "State", "City"

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

        // Navigation: one GeographyType -> many Geographies
        public ICollection<Geography> Geographies { get; set; } = new List<Geography>();
    }
}
