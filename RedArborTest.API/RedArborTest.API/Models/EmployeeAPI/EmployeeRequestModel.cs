using System.ComponentModel.DataAnnotations;

namespace RedArborTest.API.Models.EmployeeAPI
{
    public class EmployeeRequestModel
    {
        [Required]
        public int CompanyId { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? DeleteOn { get; set; }
        [Required, MinLength(3), MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string FAX { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime? LastLogin { get; set; }
        [Required, MinLength(6), MaxLength(15)]
        public string Passwrod { get; set; }
        [Required]
        public int PortalId { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int StatusId { get; set; }
        [MaxLength(15)]
        public string Telephone { get; set; }
        public DateTime? UpdateOn { get; set; }
        [Required, MinLength(3), MaxLength(20)]
        public string UserName { get; set; }
    }
}
