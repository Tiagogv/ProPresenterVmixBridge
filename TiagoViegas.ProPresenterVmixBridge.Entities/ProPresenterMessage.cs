﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiagoViegas.ProPresenterVmixBridge.Entities
{
    public class ProPresenterMessage
    {
        [JsonProperty("acn")]
        public string Action { get; set; }
    }
}
