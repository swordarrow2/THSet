﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class g4EclCode {
        //无对话
        // public static byte[] TH16St5After = new byte[] { 0x2D,0x01,0x30,0x00,0x00,0x00,0xFF,0x06,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0x43,0x00,0x00,0x80,0xC1,0x28,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0B,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4D,0x61,0x69,0x6E,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0C,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x2C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x17,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x3C,0x00,0x00,0x00,0x2A,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0E,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0xD8,0xFF,0xFF,0xFF,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x01,0x00,0x10,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0x00,0x00 };
        //有对话
        public static byte[] TH16St5Before = new byte[] { 0x2D,0x01,0x30,0x00,0x00,0x00,0xFF,0x06,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0x43,0x00,0x00,0x80,0xC1,0x28,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x06,0x02,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0B,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4D,0x61,0x69,0x6E,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0C,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x2C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x17,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x3C,0x00,0x00,0x00,0x2A,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0E,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0xD8,0xFF,0xFF,0xFF,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x01,0x00,0x10,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0x00,0x00 };

        public static byte[] TH15Extra = new byte[] { 0x16,0x00,0x20,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x03,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x37,0x00,0x00,0x00,0x05,0x00,0x00,0x00,0x0B,0x00,0x1C,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x31 };
        public static byte[] mainBossEcl = new byte[] { 0x0B,0x00,0x1C,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73 };
        public static byte[] eclBefore = new byte[] { 0x0F,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4C,0x6F,0x67,0x6F,0x45,0x6E,0x65,0x6D,0x79 };
        public static byte[] eclAfter = new byte[] { 0x0B,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4D,0x61,0x69,0x6E,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0C,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x2C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x17,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x3C,0x00,0x00,0x00,0x2A,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0E,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0xD8,0xFF,0xFF,0xFF,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x01,0x00,0x10,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0x00,0x00 };
    }
}
