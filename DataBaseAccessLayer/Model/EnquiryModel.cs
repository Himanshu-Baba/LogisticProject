using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccessLayer.Model
{
    public class EnquiryModel
    {
        public int Enquiry_Id { get; set; }
        public string Enquiry_Name { get; set; }
        public string Enquiry_Email { get; set; }
        public long? Enquiry_Phone { get; set; }
        public string Enquiry_Organization { get; set; }
        public string Enquiry_Type { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public long? Enquiry_Zip { get; set; }
        public string Enquiry_Address { get; set; }
        public string Enquiry_Quiery { get; set; }
        public List<string> EnquiryTypeList { get; set; }
    }
}
