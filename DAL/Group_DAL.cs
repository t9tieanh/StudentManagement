using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Group_DAL
    {
        private static List<Group_DTO> GetGroup(DataTable dt)
        {
            List<Group_DTO> myGroup = new List<Group_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string groupId = dt.Rows[i][0].ToString();
                string Name = dt.Rows[i][1].ToString(); 
                string userId = dt.Rows[i][2].ToString();
                // lấy user 
                var user = User_DAL.GetUser(userId);
                myGroup.Add(new Group_DTO(groupId, Name, user));
            }
            return myGroup;
        }
        public static Group_DTO GetGroup(string groupId)
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM [GROUP] WHERE GROUPID = '{groupId}'");
            return GetGroup(dt)[0];
        }
        public static List<Group_DTO> GetGroup(User_DTO myUser)
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM [GROUP] WHERE USERID = '{myUser.UserId}'");
            return GetGroup(dt);
        }
        public static List<Group_DTO> GetGroup()
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM [GROUP]");
            return GetGroup(dt);
        }
        public static bool InsertGroup (Group_DTO newGroup) 
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO [GROUP] VALUES (@GROUPID, @NAME, @USERID)";
            sqlCommand.Parameters.AddWithValue("@USERID", newGroup.User.UserId);
            sqlCommand.Parameters.AddWithValue("@NAME", newGroup.Name);
            sqlCommand.Parameters.AddWithValue("@GROUPID", newGroup.GroupId);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool UpdateGroup (Group_DTO myGroup)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE [GROUP] SET NAME = @NAME WHERE GROUPID = @GROUPID";
            sqlCommand.Parameters.AddWithValue("@NAME", myGroup.Name);
            sqlCommand.Parameters.AddWithValue("@GROUPID", myGroup.GroupId);
            return MyDB.ExecuteNonQuery(sqlCommand); 
        }
        public static bool DeleteGroup (Group_DTO myGroup) 
        {
            Teacher_DAL.SetNullGroupTeacher(myGroup);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM [GROUP] WHERE GROUPID = @GROUPID";
            sqlCommand.Parameters.AddWithValue("@GROUPID", myGroup.GroupId);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
    }
}
