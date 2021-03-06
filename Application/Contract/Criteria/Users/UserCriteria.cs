using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contract.Criteria.Users
{
    public class UserCriteria : BaseCriteria
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
