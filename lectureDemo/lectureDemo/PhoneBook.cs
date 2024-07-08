using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectureDemo
{
    internal class PhoneBook
    {
        Contact[] contacts;
        int capacity;
        private int size;

        public int Size
        {
            get {
                return size; 
            }
        }


        public Contact this[int index]
        {
            get {
                if(index >=0 && index < contacts.Length) { return contacts[index]; }
                throw new IndexOutOfRangeException();
            }
        }

        public PhoneBook(int Size)
        {
            this.size = 0;
            capacity = Size;
            this.contacts = new Contact[capacity];
        }
        public PhoneBook()
        {
            this.size =this.capacity= 0;
            this.contacts = new Contact[capacity];
        }
        public void AddNewContact(string Name , string phone)
        {
            Contact newone = new Contact(Name , phone);
            size++;
            if(size > capacity)
            {
                contacts[size] = newone;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        } 
        public void Clear()
        {
            contacts = null; size = 0;
            capacity = 0;
        }
    }
}
