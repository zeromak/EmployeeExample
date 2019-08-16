using MasGlobal.Core.Interfaces;

namespace MasGlobal.Core.DTO
{
    /// <summary>
    /// Employee with a monthly salary contract
    /// </summary>
    public class MonthlySalaryEmployeeDTO : Employee
    {
        public MonthlySalaryEmployeeDTO(dynamic objEmployee) : base((object)objEmployee)
        {
        }
        /// <summary>
        /// Calculation of the annual salary for a monthly salary employee
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateAnnualSalary()
        {
            return monthlySalary * 12;
        }
    }
}
