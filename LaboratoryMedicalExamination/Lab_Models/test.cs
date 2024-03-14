using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Entity Framework DbContext
public class LaboratoryDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Test> Tests { get; set; }
    public DbSet<TestResult> TestResults { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Sample> Samples { get; set; }
    public DbSet<Methodology> Methodologies { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<SystemSetting> SystemSettings { get; set; }

    // Override the OnModelCreating method if necessary to include further configuration
}

// Models
public class Patient
{
    [Key]
    public int PatientID { get; set; }

    [Required, StringLength(100)]
    public string FullName { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [Required, StringLength(1)]
    public string Gender { get; set; }

    [StringLength(100)]
    public string ContactInformation { get; set; }

    public string Address { get; set; }

    public virtual ICollection<TestResult> TestResults { get; set; }
}

public class Test
{
    [Key]
    public int TestID { get; set; }

    [Required, StringLength(100)]
    public string TestName { get; set; }

    public string TestDescription { get; set; }

    public int? MethodologyID { get; set; }
    public virtual Methodology Methodology { get; set; }

    public string NormalRanges { get; set; }

    [StringLength(20)]
    public string Units { get; set; }

    public virtual ICollection<TestResult> TestResults { get; set; }
}

public class TestResult
{
    [Key]
    public int ResultID { get; set; }

    [ForeignKey("Patient")]
    public int PatientID { get; set; }
    public virtual Patient Patient { get; set; }

    [ForeignKey("Test")]
    public int TestID { get; set; }
    public virtual Test Test { get; set; }

    public int SampleID { get; set; } // SampleID can be a foreign key if Sample is a model

    [Required]
    public string ResultValue { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime TestDate { get; set; }

    [StringLength(1)]
    public string Flag { get; set; } // e.g., 'N' for normal, 'A' for abnormal

    [ForeignKey("Verifier")]
    public int VerifiedBy { get; set; }
    public virtual User Verifier { get; set; }
}

public class User
{
    [Key]
    public int UserID { get; set; }

    [Required, StringLength(50)]
    public string UserName { get; set; }

    [Required, StringLength(100)]
    public string Password { get; set; } // Should be hashed

    [Required, StringLength(20)]
    public string Role { get; set; } // e.g., 'Admin', 'Technician'

    [StringLength(100)]
    public string ContactInformation { get; set; }

    public virtual ICollection<TestResult> TestResults { get; set; }
}

public class Sample
{
    [Key]
    public int SampleID { get; set; }

    [ForeignKey("Patient")]
    public int PatientID { get; set; }
    public virtual Patient Patient { get; set; }

    [ForeignKey("Collector")]
    public int CollectedBy { get; set; }
    public virtual User Collector { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime CollectionDate { get; set; }

    [Required, StringLength(50)]
    public string SampleType { get; set; }

    [Required, StringLength(20)]
    public string Status { get; set; } // e.g., 'Received', 'Processing', 'Completed'
}

public class Methodology
{
    [Key]
    public int MethodologyID { get; set; }

    [Required, StringLength(100)]
    public string MethodologyName { get; set; }

    public string Description { get; set; }

    [StringLength(255)]
    public string EquipmentUsed { get; set; }

    public virtual ICollection<Test> Tests { get; set; }
}

public class Comment
{
    [Key]
    public int CommentID { get; set; }

    [ForeignKey("TestResult")]
    public int ResultID { get; set; }
    public virtual TestResult TestResult { get; set; }

    [Required]
    public string CommentText { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime CommentDate { get; set; }

    [ForeignKey("User")]
    public int MadeBy { get; set; }
    public virtual User User { get; set; }
}

public class AuditLog
{
    [Key]
    public int LogID { get; set; }

    [ForeignKey("User")]
    public int UserID { get; set; }
    public virtual User User { get; set; }

    [Required]
    public string ActionPerformed { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime ActionDate { get; set; }

    public string AffectedTable { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }
}

public class SystemSetting
{
    [Key]
    public int SettingID { get; set; }

    [Required, StringLength(50)]
    public string SettingName { get; set; }

    [Required]
    public string Value { get; set; }

    public string Description { get; set; }
}
