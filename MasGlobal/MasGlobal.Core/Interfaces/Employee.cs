namespace MasGlobal.Core.Interfaces
{
    /// <summary>
    /// An employee with any kind of contract type
    /// </summary>
    public abstract class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal monthlySalary { get; set; }
        public decimal hourlySalary { get; set; }
        
        /// <summary>
        /// Constructor of an employee from a dynamic object
        /// </summary>
        /// <param name="objEmployee">Dynamic object representing an employee</param>
        public Employee(dynamic objEmployee)
        {
            id = objEmployee.id;
            name = objEmployee.name;
            contractTypeName = objEmployee.contractTypeName;
            roleId = objEmployee.roleId;
            roleName = objEmployee.roleName;
            roleDescription = objEmployee.roleDescription;
            monthlySalary = objEmployee.monthlySalary;
            hourlySalary = objEmployee.hourlySalary;
        }

        /// <summary>
        /// Annual salary calculation, depends on the type of contract the employee has
        /// </summary>
        /// <returns></returns>
        public abstract decimal CalculateAnnualSalary();        
    }
}
