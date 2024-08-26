using System;
using System.ComponentModel;
using api.metalitec.project.Models.Catalogue;

namespace api.metalitec.project.Models.Users
{
    public class UserAddDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MotherLastName { get; set; }
        public string Avatar { get; set; }
        public int RoleId { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

    public class UserReturnDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MotherLastName { get; set; }
        public string Avatar { get; set; }
        public int RoleId { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        [DefaultValue(false)]
        public bool Status { get; set; }
        [DefaultValue(false)]
        public bool FirstLogin { get; set; }
        [DefaultValue(false)]
        public bool Reset { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Token { get; set; }

        public virtual CatRoleDto Role { get; set; }
    }
}