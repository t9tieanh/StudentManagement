using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class Group_BUL
    {
        public static Group_DTO GetGroup(string groupId)
        {
            return DAL.Group_DAL.GetGroup(groupId);
        }
        public static List<Group_DTO> GetGroup()
        {
            return Group_DAL.GetGroup();
        }
        public static List<Group_DTO> GetGroup(User_DTO myUser)
        {
            return Group_DAL.GetGroup(myUser);
        }
        public static bool InsertGroup(Group_DTO newGroup)
        {
            return Group_DAL.InsertGroup(newGroup);
        }
        public static bool UpdateGroup(Group_DTO myGroup)
        {
            return Group_DAL.UpdateGroup(myGroup);
        }
        public static bool DeleteGroup(Group_DTO myGroup)
        {
            return Group_DAL.DeleteGroup(myGroup);
        }
    }
}
