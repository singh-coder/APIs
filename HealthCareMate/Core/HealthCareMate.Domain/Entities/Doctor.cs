namespace HealthCareMate.Domain.Entities
{
    public class Doctor
    {
        public int ID {get;set;}
        public string? FirstName {get;set;}
        public string? LastName {get;set;}
        public string? Qualifications {get;set;}
        public int Experience {get;set;}
        public string? Address {get;set;}
        public string? Email {get;set;}
        public string? Phone {get;set;}
        public Department? DepartmentId {get;set;}
    }
}