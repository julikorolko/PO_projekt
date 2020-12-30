﻿using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjektPO 
{
    class Client : AClient
    {
        string adress;
        string postcode;
        string phone_num;
        string email;

        public string Adress { get => adress; set => adress = value; }
        public string Postcode { get => postcode; set => postcode = value; }
        public string Phone_num { get => phone_num; set => phone_num = value; }
        public string Email { get => email; set => email = value; }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public Client(string firstname, string surname, string adress, string postcode, 
            string phone_num, string email)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.Adress = adress;
            this.Postcode = postcode;
            Regex pattern = new Regex("^\\d{9}$");
            if (pattern.IsMatch(phone_num))
                this.Phone_num = phone_num;
            if (IsValid(email))
                this.Email = email;
        }
        public override string ToString()
        {
            return Firstname + " " + Surname + "\n" 
                + Adress + "\n" 
                + Postcode + "\n" 
                + Phone_num + "\n" 
                + Email + "\n";
        }
    }
}
