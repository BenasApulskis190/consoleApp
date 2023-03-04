using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleProject.HR
{
  public class Employee : IEmployee
  {
    private string firstName;
    private string lastName;
    private string email;
    private int numberOfHoursWorked;
    private double wage;
    private double? hourlyRate;
    private DateTime birthDay;
    private const int minimalHoursWorkedUnit = 1;
    private Address address;
    private static double taxRate = 0.15;

    public string FirstName
    {
      get { return firstName; }
      set
      {
        firstName = value;
      }
    }

    public string LastName
    {
      get { return lastName; }
      set
      {
        lastName = value;
      }
    }
    public string Email
    {
      get { return email; }
      set
      {
        email = value;
      }
    }
    public int NumberOfHoursWorked
    {
      get { return numberOfHoursWorked; }
      set
      {
        numberOfHoursWorked = value;
      }
    }
    public double Wage
    {
      get { return wage; }
      set { wage = value; }
    }
    public double? HourlyRate
    {
      get { return hourlyRate; }
      set
      {
        if (hourlyRate < 0)
        {
          hourlyRate = 0;
        }
        else
        {
          hourlyRate = value;
        }
      }
    }
    public DateTime Birthday
    {
      get { return birthDay; }
      set { birthDay = value; }
    }
    public Address Address
    {
      get { return address; }
      set {address = value;}
    }

    public Employee(string firstName, string lastName, DateTime bir) {}

    public void GiveBonus()
    {
      throw new NotImplementedException();
    }

    public void GiveCompliment()
    {
      throw new NotImplementedException();
    }

    public void PerformWork()
    {
      throw new NotImplementedException();
    }

    public void PerformWork(int numberOfHours)
    {
      throw new NotImplementedException();
    }

    public double ReceiveWage(bool resetHours = true)
    {
      throw new NotImplementedException();
    }
  }
}