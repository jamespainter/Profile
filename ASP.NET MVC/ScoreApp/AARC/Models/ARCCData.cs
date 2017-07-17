namespace AARC.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class ARCCData : DbContext
    {
        
    }

    [Table("SECURITY")]
    public class SECURITY
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email")]
        public string Email { get; set; }

        [Required, Display(Name = "Password")]
        public string Password { get; set;}
        
    }
    [Table("SCORE")]
    public class SCORE
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SecurityID { get; set; }

        [Required, Display(Name = "Proposal Name")]
        public string Proposal_Name { get; set; }

        [Required, Display(Name = "Education Experience")]
        public int Education_Exp { get; set; }

        [Required, Display(Name = "Innovation")]
        public int Innovation { get; set; }

        [Required, Display(Name = "Dissemination")]
        public int Dissemination { get; set; }

        [Required, Display(Name = "Evaluation")]
        public int Evaluation { get; set; }

        [Required, Display(Name = "Support")]
        public int Support { get; set; }
        
    }

    public class ARCCDbContext : DbContext
    {
        public DbSet<SECURITY> securityDB { get; set; }

        public DbSet<SCORE> scoreDB { get; set; }

    }



    
}