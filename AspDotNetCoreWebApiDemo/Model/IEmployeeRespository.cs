using System.Collections.Generic;
public interface IEmployeeRespository
{
    Employee GetEmployee(int id);

    IEnumerable<Employee> GetEmployee();
}

