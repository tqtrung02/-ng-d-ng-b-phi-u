﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_app.share.CustomAttribute
{
    public class ForeignKeyAttribute
    {
        public string MasterTableName { get; set; }

        public string MasterKeyName { get; set; }

        public ForeignKeyAttribute(string masterTableName, string masterKeyName) : base()
        {
            MasterKeyName = masterKeyName;
            masterTableName = masterTableName;
        }
    }
}
