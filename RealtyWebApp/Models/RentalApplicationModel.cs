using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace RealtyWebApp.Models
{
    public class RentalApplicationModel
    {


        
        [Required]
        [Display(Name = "Property Address")]
        public string PropertyAddress { get; set; }

        [Display(Name = "Phone Number")]
        public  string PhoneNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "SSN")]
        public string SSN { get; set; }

        public int Debt { get; set; }

        public string Pets { get; set; }

        [Display(Name = "Previous Address")]
        public string PreviousAdress { get; set; }

        [Display(Name = "Land Lord")]
        public string LandLord { get; set; }

        [Display(Name = "Land Lord Phone Number")]
        public string LandLphone { get; set; }

        [Display(Name = "Monthly Payment")]
        public string MonthlyPayment { get; set; }

        [Display(Name = "Leased")]
        public bool IsLeased { get; set; }

        [Display(Name = "Owned")]
        public bool IsOwned { get; set; }
        public string Occupation { get; set; }

        [Display(Name = "Co-Applicant SSN")]
        public string CoAppSSN { get; set; }

        [Display(Name = "Co-Applicant First Name")]
        public string CoApplicanFname { get; set; }

        [Display(Name = "Co-Applicant Lirst Name")]
        public string CoApplicanLname { get; set; }

        [Display(Name = "Other Occupants")]
        public string OtherOccupants { get; set; }

        public string Employer { get; set; }

        [Display(Name = "Supervisor Name")]
        public string SupervisorName { get; set; }

        public string EmployerPhone { get; set; }

        [Display(Name = "How Long Employed")]
        public string HowLongEmployed { get; set; }

        [Display(Name = "Annual Income")]
        public int AnnualIncome { get; set; }

        [Display(Name = "Other Income")]
        public string OtherIncome { get; set; }

        [Display(Name = "Reference")]
        public string Reference2 { get; set; }

        [Display(Name = "Reference Phone")]
        public string RefPhone2 { get; set; }

        [Display(Name = "Reference")]
        public string Reference1 { get; set; }

        [Display(Name = "Reference Phone")]
        public string RefPhone1 { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        public  bool IsActive { get; set; }

        public RentalApplicationModel()
        {
            IsActive = true;
        }


    }
}