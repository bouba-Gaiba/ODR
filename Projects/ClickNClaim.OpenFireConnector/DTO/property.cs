﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClickNClaim.OpenFireConnector
{
    public class property
    {
        [XmlAttribute("key")]
        public string key { get; set; }
        [XmlAttribute("value")]
        public string value { get; set; }
    }
}
