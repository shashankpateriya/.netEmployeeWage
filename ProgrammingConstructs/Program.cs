using System;

namespace ProgrammingConstructs
{
class Program
{
    static void Main(string[] args)
    {
            UC1_EmployeeAttendance.empAttendanceCheck();
            // UC2_EmployeeDailyWage.DailyEmployeeWage();
            // UC_3PartTimeEmployeeWage.PartTimeEmp();
            // UC_4PartTimeEmpWageUsingSwitch.PartTimeEmployeeWage();
            // UC6_NumberOfWorkingDays.NumberOFWorking();
            // UC5_CalWagesForMonth.EmployeeWageMonth();
            // UC_7EmployeeWageUsingMethod.computeEmpWage();
            // UC_8AbillityToComputeEmpwageForMultipleCompany.computeEmpWage("DMart", 20, 2, 10);
            // UC_8AbillityToComputeEmpwageForMultipleCompany.("Reliance", 20, 4, 20);

            //#region UC_9_Implementatiion
            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());
            //#endregion

            //#region UC_10
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            //empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            //empWageBuilder.computeEmpWage();
            //#endregion
            Console.ReadKey();
    }
}
}
