﻿using System.ComponentModel.DataAnnotations;

namespace MachineTracker
{
    /// <summary>
    /// An employee of the company
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The employee id
        /// </summary>
        [Key, Required]
        public string EmployeeID { get; set; }

        /// <summary>
        /// Name of the employee
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Where the employee is based
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Employees email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Employee contact number
        /// </summary>
        public int ContactNo { get; set; }

        /// <summary>
        /// True if the employee is active.
        /// False if not. Allows records to stay in database
        /// without showing up in normal results.
        /// </summary>
        public bool Active { get; set; } = true;
    }
}
