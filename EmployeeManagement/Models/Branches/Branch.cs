namespace EmployeeManagement.Models.Branches
{
    public class Branch
    {

        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public string AddressLine { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string PostCode { get; set; }
        public string CreatedBy { get; set; }
    }
}
