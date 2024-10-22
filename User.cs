using ConsoleApp16.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    
    public  class Users:IAccount
    {
        private int _id;
        public string FullName { get; set; }

        public string Email { get; set; }
        private string _password;

        public int ID { get; set; }
        protected Users(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            this.Password = password;
            ++_id;
            ID = _id;
                   
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("sifre dogru deyil");
                }

            }
        }
        public bool PasswordChecker(string  password)
        {

            foreach (var simvol in Password)
            {


                if (Password.Length < 8)
                {
                    if (char.IsUpper(simvol))
                    {
                        if (char.IsLower(simvol))
                        {
                            if (char.IsDigit(simvol))
                            {
                                return true;
                            }
                        }
                    }
                }
            }  
            return false;
            
            

        }
        public  void ShowInfo()
        {
            Console.WriteLine($"ID:{ID},FullName:{FullName},Email{Email}");
        }

        
    }
}
