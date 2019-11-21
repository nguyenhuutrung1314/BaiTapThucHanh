﻿using System;
using System.Collections.Generic;
using System.Text;

namespace chapter7
{
    public class Global
    {
        private Global()
        {
        }

        private static Global _instance;

        public static Global Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }

        public String myData { get; set; }
    }

}
