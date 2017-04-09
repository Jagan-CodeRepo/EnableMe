﻿using Cognizant.DE.EnableMe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.DE.EnableMe.DAL
{
    public interface IBasicFilterRepository
    {
        IEnumerable<BasicFilter> Get(string associateID, int roleID);
    }
}