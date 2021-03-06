﻿using System;
using System.Text;

namespace Exercicio_Pedidos.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime  BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name)
        {
            Name = name;
        }

        public Client(string name, string email) : this(name)
        {
            Email = email;
        }

        public Client(string name, string email, DateTime birthDate) : this(name, email)
        {
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            if (BirthDate != null)
            {
                sb.Append(" (" + BirthDate.ToString("dd/MM/yyyy") + ")");
            }
            if (Email != null)
            {
                sb.Append(" - " + Email);
            }
            return sb.ToString();
        }
    }
}
