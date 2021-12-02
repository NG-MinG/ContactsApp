﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClientContactsApp
{
    public class Requests
    {
        public string action;
        public string message;

        public Requests(string _action, string _message)
        {
            action = _action;
            message = _message;
        }

        public byte[] toBytes()
        {
            string json = JsonConvert.SerializeObject(this);
            return Encoding.UTF8.GetBytes(json);
        }
    }
}
