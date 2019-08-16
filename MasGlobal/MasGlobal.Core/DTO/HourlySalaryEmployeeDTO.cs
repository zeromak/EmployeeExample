using MasGlobal.Core.Interfaces;

namespace MasGlobal.Core.DTO
{
    /// <summary>
    /// Employee with an hourly salary contract
    /// </summary>
    public class HourlySalaryEmployeeDTO : Employee
    {
        public HourlySalaryEmployeeDTO(dynamic objEmployee) : base((object)objEmployee)
        {
        }
        /// <summary>
        /// Calculation of the annual salary for an hourly salary employee
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateAnnualSalary()
        {
            return 120 * hourlySalary * 12;
        }
    }
}
