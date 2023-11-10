using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccessLayer.Model
{
    public class ContactUsModel
    {
        public int Contact_Id { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Email { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_Message { get; set; }
    }
}
