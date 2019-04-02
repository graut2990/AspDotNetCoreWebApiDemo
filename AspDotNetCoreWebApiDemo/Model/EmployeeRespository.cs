using System.Collections.Generic;
public class EmployeeRespository :IEmployeeRespository
{
     List<Employee> _employeeList {get;set;}
     readonly DBRepositoryContext _dBRepositoryContext;
     public EmployeeRespository(DBRepositoryContext dBRepositoryContext)
     {
         _dBRepositoryContext = dBRepositoryContext;

         _employeeList = new List<Employee>()
          {
            new Employee(){Id=1,Name="Mary",Email="mary@gmail.com",Department="IT"},
            new Employee(){Id=2,Name="Jhon",Email="Jhon@gmail.com",Department="Syncade"}
          };
     } 
    public Employee GetEmployee(int id)
    {
        return _employeeList.Find(x=>x.Id == id);       
    }

     public IEnumerable<Employee> GetEmployee()
    {
        return  _employeeList; 
          //var data = _dBRepositoryContext.Employees;
          //return data;
    }
}