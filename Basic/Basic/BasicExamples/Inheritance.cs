﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples
{



    public class Asset
    {
        public string Name;
        public virtual decimal Liability => 0; //virtual method
    }
    public class Stock : Asset // inherits from Asset
    {
        public long SharesOwned;
    }
    public class House : Asset // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage;

    }



}
