namespace RealtyWebApp.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class Customer : IdentityUser
    {

        [Required]
        [Display(Name = "Property Address")]
        public string PropertyAddress { get; set; }
        [Display(Name = "SSN")]
        public string SSN{ get; set; }

        public int Debt { get; set; }
        public string Pets { get; set; }
        [Display(Name = "Previous Address")]
        public string PreviousAdress { get; set; }
        public string LandLord { get; set; }
        public string LandLphone { get; set; }
        [Display(Name = "Monthly Payment")]
        public string MonthlyPayment { get; set; }
        [Display(Name = "Leased")]
        public bool IsLeased { get; set; }
        [Display(Name = "Owned")]
        public bool IsOwned { get; set; }
        public string Occupation { get; set; }
        [Display(Name = "Co-Applicant SSN")]
        public string   CoAppSSN { get; set; }
        [Display(Name = "Co-Applicant First Name")]
        public string CoApplicanFname { get; set; }
        [Display(Name = "Co-Applicant Lirst Name")]
        public string CoApplicanLname { get; set; }
        [Display(Name = "Other Occupants")]
        public string OtherOccupants { get; set; }
        public string Employer { get; set; }
        [Display(Name = "Supervisor Name")]
        public string SupervisorName { get; set; }
        public string  EmployerPhone { get; set; }
        public string HowLongEmployed { get; set; }
        public int AnnualIncome { get; set; }
        public string OtherIncome { get; set; }
        public string Reference2 { get; set; }
        public string RefPhone2 { get; set; }
        public string Reference1 { get; set; }
        public string RefPhone1 { get; set; }
        


    }

}