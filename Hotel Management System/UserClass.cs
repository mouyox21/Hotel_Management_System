using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    internal class UserClass
    {
        DBConnect connect = new DBConnect();

        public bool insertUser(string id,string user,string pass )
        {
            string insertQuerry = "INSERT INTO `users`(`id`, `username`, `password`) VALUES (@id,@user,@pass)";
            MySqlCommand command= new MySqlCommand(insertQuerry, connect.GetConnection());
            command.Parameters.Add("@id",MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        public DataTable getaddUser()
        {
            string selectQuery = "SELECT * FROM `users`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool removeUser(string id)
        {
            string insertQuerry = "DELETE FROM `users` WHERE `id`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        public bool editUser(string id, string username, string pass)
        {
            string editQuerry = "UPDATE `users` SET `username`=@username,`password`=@pass WHERE `id`=id";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@id,@fname,@lname,@ph,@ct
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }



    }
}
