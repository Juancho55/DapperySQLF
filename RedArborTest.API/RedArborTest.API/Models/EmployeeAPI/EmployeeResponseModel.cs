namespace RedArborTest.API.Models.EmployeeAPI
{
    public class EmployeeResponseModel
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime? DeleteOn { get; set; }
        public string Email { get; set; }
        public string FAX { get; set; }
        public string Name { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Passwrod { get; set; }
        public int PortalId { get; set; }
        public int RoleId { get; set; }
        public int StatusId { get; set; }
        public string Telephone { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string UserName { get; set; }
    }
}
