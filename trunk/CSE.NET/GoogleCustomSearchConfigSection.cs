﻿namespace Google.CustomSearch
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;

    public class GoogleCustomSearchConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("countPerPage", DefaultValue = 10)]
        public int CountPerPage
        {
            get { return (int)this["countPerPage"]; }
            set { this["countPerPage"] = value; }
        }

        [ConfigurationProperty("cseId", IsRequired = true)]
        public string CseId
        {
            get { return (string)this["cseId"]; }
            set { this["cseId"] = value; }
        }
    }
}
