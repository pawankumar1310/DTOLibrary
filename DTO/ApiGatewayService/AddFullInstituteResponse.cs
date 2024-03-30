namespace DTO.ApiGatewayService
{
    public class AddFullInstituteResponse
    {
        public string Name { get; set; }
        public string YearOfEstablishment { get; set; }
        public string AffiliationID { get; set; }
        public string CreatedBy { get; set; }
        public string url { get; set; }
        public List<string> institutionFacilities { get; set; }
        public List<string> institutionGovernance { get; set; }
        public string AdditionalAddress { get; set; }
        public string Landmark { get; set; }
        public string ZipCodeID { get; set; }
        public string StatusReferenceID { get; set; }
        public string UserID{get;set;}
        // public string institutionID { get; set; }
        public string ownerShipID { get; set; }
        public string createdBy { get; set; }
        //institute head name, gender, joining date, phone number, email, institution id
        public string Names { get; set; }
        public string Gender { get; set; }
        public DateTime JoiningDate { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        // public string InstitutionId { get; set; }
        //temp data for institute
        public string InstitutionNumberorID { get; set; }
        public string InstitutionCategory { get; set; }
        public string InstitutionLevel { get; set; }
        public string InstitutionCourse { get; set; }
        public string InstitutionManagement { get; set; }
        public string InstitutionAssosication { get; set; }
        // public string InstitutionID { get; set; }
    }
}