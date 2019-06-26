using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class RepoManager
    {

        public static bool Validate(string name, string Password)
        {
            return Repo.Validate(name,Password);
        }

        public static List<Employee> getAllDetails()
        {
            return Repo.getAllDetails();
        }

        public static bool Insert(int id,string name,string address,string salary,string password)
        {
            return Repo.Insert(id,name,address,salary,password);
        }

        public static bool Update(int id,string password)
        {
            return Repo.update(id, password);
        }
    }
}
