using System;
using System.Collections.Generic;

#nullable disable

namespace SNADHRMS.Repository.Models
{
    public partial class Employeedatum
    {
        public Employeedatum()
        {
            EmpexpenseApprovedbyNavigations = new HashSet<Empexpense>();
            EmpexpenseCreatedbyNavigations = new HashSet<Empexpense>();
            EmpexpenseUpdatedbyNavigations = new HashSet<Empexpense>();
            ImgexpenseApprovedbyNavigations = new HashSet<Imgexpense>();
            ImgexpenseCreatedbyNavigations = new HashSet<Imgexpense>();
            ImgexpenseUpdatedbyNavigations = new HashSet<Imgexpense>();
            MgmtexpenseApprovedbyNavigations = new HashSet<Mgmtexpense>();
            MgmtexpenseCreatedbyNavigations = new HashSet<Mgmtexpense>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaritalStatus { get; set; }
        public string Empstatus { get; set; }
        public string Emailaddress { get; set; }
        public string Jobtitle { get; set; }
        public string Internalstaff { get; set; }
        public int? Supervisor { get; set; }
        public string VisaStatus { get; set; }
        public string Gender { get; set; }
        public string Entity { get; set; }
        public DateTime? Dob { get; set; }
        public string ClientName { get; set; }
        public int? Clientcode { get; set; }
        public DateTime? Startdate { get; set; }
        public string Createdby { get; set; }
        public string Updatedby { get; set; }
        public string Immigrationstatus { get; set; }
        public string Highestdegree { get; set; }
        public string University { get; set; }
        public int? Contactnumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCodePostalCode { get; set; }
        public string Country { get; set; }
        public int? Ssn { get; set; }
        public int? TaxFileNumber { get; set; }
        public int? Emergencynumber { get; set; }
        public DateTime? Effectivedate { get; set; }
        public string Location { get; set; }
        public string ReportingTo { get; set; }
        public string Payschedule { get; set; }
        public string PayType { get; set; }
        public int? Payrate { get; set; }
        public string OvertimeEligibility { get; set; }
        public int? Overtimerate { get; set; }
        public string Reason { get; set; }
        public string Comments { get; set; }
        public string Specialization { get; set; }
        public int? Gpa { get; set; }
        public DateTime? Educationstartdate { get; set; }
        public DateTime? Educationenddate { get; set; }
        public string VisaTypeIssuingCountry { get; set; }
        public DateTime? IssuedDate { get; set; }
        public DateTime? Expirationdate { get; set; }
        public string Status { get; set; }
        public string Employementstatus { get; set; }
        public DateTime? JobEffectiveDate { get; set; }
        public DateTime? CompensationEffectiveDate { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public int NationalId { get; set; }
        public byte[] ProfilePic { get; set; }
        public string SecondaryLanguage { get; set; }
        public int AddressId { get; set; }
        public int WorkPhone { get; set; }
        public int MobilePhone { get; set; }
        public string WorkEmail { get; set; }
        public string HomeEmail { get; set; }
        public string Degree { get; set; }
        public string Notes { get; set; }
        public string BankName { get; set; }
        public byte[] AccountNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int IfscCode { get; set; }
        public string Proof { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime ProbationEndDate { get; set; }
        public string ProbationStatus { get; set; }
        public string NoticePeriod { get; set; }
        public string BackgroundCheckStatus { get; set; }
        public string Department { get; set; }
        public string BusinessArea { get; set; }
        public string CompensationComments { get; set; }
        public string Frequency { get; set; }
        public int Amount { get; set; }
        public string EmergencyName { get; set; }
        public byte[] RelationShip { get; set; }
        public string EmailId { get; set; }
        public int MobileNumber { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }

        public virtual ICollection<Empexpense> EmpexpenseApprovedbyNavigations { get; set; }
        public virtual ICollection<Empexpense> EmpexpenseCreatedbyNavigations { get; set; }
        public virtual ICollection<Empexpense> EmpexpenseUpdatedbyNavigations { get; set; }
        public virtual ICollection<Imgexpense> ImgexpenseApprovedbyNavigations { get; set; }
        public virtual ICollection<Imgexpense> ImgexpenseCreatedbyNavigations { get; set; }
        public virtual ICollection<Imgexpense> ImgexpenseUpdatedbyNavigations { get; set; }
        public virtual ICollection<Mgmtexpense> MgmtexpenseApprovedbyNavigations { get; set; }
        public virtual ICollection<Mgmtexpense> MgmtexpenseCreatedbyNavigations { get; set; }
    }
}
