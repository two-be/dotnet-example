using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkEf.Models
{
    public class UserInfo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string Username { get; set; } = string.Empty;
    }
}
