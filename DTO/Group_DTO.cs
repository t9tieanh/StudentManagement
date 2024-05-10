using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Group_DTO
    {
        private string groupId;
        private string name; 
        private User_DTO user;

        public Group_DTO(string groupId, string name, User_DTO user)
        {
            GroupId = groupId;
            Name = name;
            User = user;
        }

        public string GroupId { get => groupId; set => groupId = value; }
        public string Name { get => name; set => name = value; }
        public User_DTO User { get => user; set => user = value; }
    }
}
