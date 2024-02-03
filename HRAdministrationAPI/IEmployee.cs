using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationAPI
{
    public interface IEmployee
    {
        int Id { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        decimal Salary { get; set; }
    }
}
