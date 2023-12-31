﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Core
{
    public interface IMarketProduct
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string PhotoUri { get; set; }
        public int Price { get; set; }
    }
}
