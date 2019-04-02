using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Employee
{
    public int Id { get; set; } 
    public string Name { get; set; }    
    public string Email { get; set; }
    public string Department { get; set; }
    // public Employee()
    // {
    // }

    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //  public long EmployeeId { get; set; }
    //  public string FirstName { get; set; }
    //  public string LastName { get; set; }
    //  public DateTime DateOfBirth { get; set; }
    //  public string PhoneNumber { get; set; }
    //  public string Email { get; set; }
}
