using System;

namespace api.metalitec.project.Models.Catalogue
{
    public class CatRoleDto
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}