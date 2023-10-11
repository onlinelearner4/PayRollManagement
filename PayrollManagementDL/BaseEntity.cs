using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollManagementDL
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
            IsActive = true;
        }
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}