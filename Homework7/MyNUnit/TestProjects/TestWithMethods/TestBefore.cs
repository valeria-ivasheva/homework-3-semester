﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNUnit.Attributes;

namespace TestWithMethods
{
    public class TestBefore
    {
        private int count = 0;

        [BeforeTest]
        public void BeforeClass()
        {
            count = count + 2;
        }

        [Test]
        public int Test()
        {
            return 1 / count;
        }

        [Test]
        public void Test1()
        {
            return;
        }
    }
}
