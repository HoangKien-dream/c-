using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Entity
{
    class Account
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public string email { get; set; }
        public DateTime Birthday { get; set; }
        public string Introduct { get; set; }
        public int Gender { get; set; }

        public override string ToString()
        {
            return $"FirstName: {firstName} LastName:{lastName} Password:{password} Address:{address} Phone:{phone} Avatar:{avatar} Birthday:{Birthday} Introduction:{Introduct} Gender:{Gender}";
        }
    }
}
