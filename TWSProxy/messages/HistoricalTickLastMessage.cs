﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TWSProxy.messages
{
    public class HistoricalTickLastMessage
    {
        public int ReqId { get; private set; }
        public long Time { get; private set; }
        public int Mask { get; private set; }
        public double Price { get; private set; }
        public long Size { get; private set; }
        public string Exchange { get; private set; }
        public string SpecialConditions { get; private set; }

        public HistoricalTickLastMessage(int reqId, long time, int mask, double price, long size, string exchange, string specialConditions)
        {
            ReqId = reqId;
            Time = time;
            Mask = mask;
            Price = price;
            Size = size;
            Exchange = exchange;
            SpecialConditions = specialConditions;
        }
    }
}
