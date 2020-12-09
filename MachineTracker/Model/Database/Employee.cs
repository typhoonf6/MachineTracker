using System.ComponentModel.DataAnnotations;

namespace MachineTracker
{
    /// <summary>
    /// An employee of the company
    /// </summary>
    class Employee
    {
        /// <summary>
        /// The employee id
        /// </summary>
        [Key, Required]
        public string EmployeeID { get; set; }

        /// <summary>
        /// Name of the employee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Where the employee is based
        /// </summary>
        public string Location { get; set; }
    }
}
