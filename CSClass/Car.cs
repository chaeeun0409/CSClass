﻿using System;

namespace CSClass
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;
        private int i;

        public Car()
        {
        }

        public void SetInTime()
        {

            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}