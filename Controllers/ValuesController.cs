﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dockersampleconfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("getvalues")]
        public List<string> getvalues()
        {
            //comment added
            List<string> l = new List<string>();
            l.Add("value1");
            l.Add("value2");
            l.Add("value3");
            l.Add("Value4");
            l.Add("Value5");
            l.Add("Value6");
            l.Add("Value7");
            l.Add("Value8");
            l.Add("Value9");
            l.Add("Value 10");
            l.Add("Value 11");
            l.Add("Value 12");
            l.Add("CTS Trial 14566");
            l.Add("FIS Data Modified");
            l.Add("CTS ID12 Data Modified");
            l.Add("FIS Data Newly Modified");
            l.Add("Third Data Integration");
            l.Add("CDE12 data added");
            l.Add("Schneider Data Added");
            l.Add("RBC data added");
            l.Add("Kanini Data Added");
            l.Add("Kanini second Data Added");
            l.Add("Docker Image Added");
            l.Add("Tech M Added");
            l.Add("CTS CDE14 Added");
            l.Add("Kanini Batch I Data Added");
            l.Add("second modfication");
            l.Add("Final Modification");
            l.Add("CTS CDX0102 Data Added");
            l.Add("New CDX0102 modified");
            l.Add("R15Vishva,N200Vishnu");
            return l;
        }
    }
}
