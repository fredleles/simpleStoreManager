using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDataAccess.Library.Models
{
    public class UserModel
    {
        public string Id { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string EmailAddress { get; set; } = String.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
