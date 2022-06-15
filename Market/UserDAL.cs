using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public static class UserDAL
    {
        public static List <UserDAL> GetAllUser()
            string Commandstring     = "Select * from Patients";
            OleDbCommand command = new OleDbCommand(commandString, connection);
          OleDbDataAdapter da = new OleDbDataAdapter(command);
        DataTable patientsTable = new DataTable();
        da.Fill(patientsTable);
return patientsTable
            return null;
        }


    public static User GetUser(int id)
    {
        return null;
    }
           public static void CreateUser(User User)
    {
        string commandString = string.Format("Insert into User (UserName) values(1{0}", User.UserName);
        OleDbCommand command = new OleDbCommand(commandString,connection);
        coonnection.Close();
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
         public static void UpdateUser(User User)
    {
        string commandstring = string.Format("update User Set UserName values('{0}')",
         User.UserName) ;
        OleDbCommand command = new OleDbCommand(commandString, connection);
        connection.Close();
        connection.Open();
        command.ExecuteNonQuery(0);
        connection.Close()
    }
       public static void DeleteUser(int id)
    {
        string commandString = string.Format("Delete from User where UserId {0}}", id);
            OleDbCommand command=  new OleDbCommand(commandString,connection)
        connection.Close();
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}

