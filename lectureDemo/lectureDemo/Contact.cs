using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectureDemo
{
    internal class Contact
    {
		private string name;
		private string phoneNumber;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        public Contact(string _name , string _phone)
        {
            this.Name = _name;
			this.PhoneNumber = _phone;
        }
    }
}
