﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_基础总体复习
{
   public  class Wav:Person
    {
        public override void Test()
        {
            ProcessStartInfo pri = new ProcessStartInfo(this.Name);
            Process test = new Process();
            test.StartInfo = pri;
            test.Start();
        }
        public Wav(string name) : base(name)
        { }
    }
}
