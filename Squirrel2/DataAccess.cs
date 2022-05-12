using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Squirrel2
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SQLTutorial")))
            {
                var output = connection.Query<Person>("People_GetByLastName @LastName", new {LastName = lastName }).ToList();
                return output;
            }
        }

        public void InsertPerson(int id,string firstName, string lastName, int age)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SQLTutorial")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person { EmployeeID = id,FirstName = firstName, LastName = lastName, Age = age });
                connection.Execute("dbo.People_Insert @EmployeeID, @FirstName, @LastName, @Age", people);
            }
        }
    }
}
