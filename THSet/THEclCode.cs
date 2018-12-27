﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public class g4EclCode {

        public static readonly byte[] eclMainBossNum = new byte[] { 0x0B,0x00,0x1C,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73 };
        public static readonly byte[] eclLogoEnemy = new byte[] { 0x0F,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4C,0x6F,0x67,0x6F,0x45,0x6E,0x65,0x6D,0x79 };
        public static readonly byte[] celCreateMainBoss = new byte[] { 0x0B,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4D,0x61,0x69,0x6E,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0C,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x2C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x17,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x3C,0x00,0x00,0x00,0x2A,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0E,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0xD8,0xFF,0xFF,0xFF,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x01,0x00,0x10,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0x00,0x00 };

        public static class bossCount {
            public static readonly object[] count2 = new object[] { "Boss1","Boss2" };
            public static readonly object[] count3 = new object[] { "Boss1","Boss2","Boss3" };
            public static readonly object[] count4 = new object[] { "Boss1","Boss2","Boss3","Boss4" };
            public static readonly object[] count5 = new object[] { "Boss1","Boss2","Boss3","Boss4","Boss5" };
            public static readonly object[] count6 = new object[] { "Boss1","Boss2","Boss3","Boss4","Boss5","Boss6" };
            public static readonly object[] count7 = new object[] { "Boss1","Boss2","Boss3","Boss4","Boss5","Boss6","Boss7" };
            public static readonly object[] count10 = new object[] { "Boss1","Boss2","Boss3","Boss4","Boss5","Boss6","Boss7","Boss8","Boss9","Boss10" };
        }
        public static class TH13 {
            public static readonly object[] stage1 = bossCount.count4;
            public static readonly object[] stage2 = bossCount.count3;
            public static readonly object[] stage3 = bossCount.count3;
            public static readonly object[] stage4 = bossCount.count3;
            public static readonly object[] stage5 = bossCount.count4;
            public static readonly object[] stage6 = bossCount.count7;
            public static readonly object[] stage7 = bossCount.count10;
        }

        public static class TH14 {
            public static readonly object[] stage1 = bossCount.count2;
            public static readonly object[] stage2 = bossCount.count3;
            public static readonly object[] stage3 = bossCount.count3;
            public static readonly object[] stage4 = bossCount.count3;
            public static readonly object[] stage5 = bossCount.count3;
            public static readonly object[] stage6 = bossCount.count6;
            public static readonly object[] stage7 = bossCount.count10;
        }

        public static class TH15 {
            public static readonly byte[] eclTH15ExtraMainBossNum = new byte[] { 0x16,0x00,0x20,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x03,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x37,0x00,0x00,0x00,0x05,0x00,0x00,0x00,0x0B,0x00,0x1C,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x31 };
            public static readonly object[] stage1 = bossCount.count2;
            public static readonly object[] stage2 = bossCount.count3;
            public static readonly object[] stage3 = bossCount.count4;
            public static readonly object[] stage4 = bossCount.count4;
            public static readonly object[] stage5 = bossCount.count5;
            public static readonly object[] stage6 = bossCount.count7;
            public static readonly object[] stage7 = bossCount.count10;
        }

        public static class TH16 {
            public static readonly byte[] eclTH16Stage5CreateMainBoss = new byte[] { 0x2D,0x01,0x30,0x00,0x00,0x00,0xFF,0x06,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0x43,0x00,0x00,0x80,0xC1,0x28,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x06,0x02,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0B,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4D,0x61,0x69,0x6E,0x42,0x6F,0x73,0x73,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0C,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x2C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x17,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0xE8,0x03,0x00,0x00,0x3C,0x00,0x00,0x00,0x2A,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0E,0x00,0x18,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0xD8,0xFF,0xFF,0xFF,0x3C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x01,0x00,0x10,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0x00,0x00 };
            public static readonly object[] stage1 = bossCount.count2;
            public static readonly object[] stage2 = bossCount.count3;
            public static readonly object[] stage3 = bossCount.count3;
            public static readonly object[] stage4 = bossCount.count3;
            public static readonly object[] stage5 = bossCount.count4;
            public static readonly object[] stage6 = bossCount.count6;
            public static readonly object[] stage7 = bossCount.count10;
        }

        public static byte[] getBossNumArray(string boss) {
            switch(boss) {
                case "Boss1": return new byte[] { 0x31,0x00 };
                case "Boss2": return new byte[] { 0x32,0x00 };
                case "Boss3": return new byte[] { 0x33,0x00 };
                case "Boss4": return new byte[] { 0x34,0x00 };
                case "Boss5": return new byte[] { 0x35,0x00 };
                case "Boss6": return new byte[] { 0x36,0x00 };
                case "Boss7": return new byte[] { 0x37,0x00 };
                case "Boss8": return new byte[] { 0x38,0x00 };
                case "Boss9": return new byte[] { 0x39,0x00 };
                case "Boss10": return new byte[] { 0x31,0x30 };
                default: return new byte[] { 0x31,0x00 };
            }
        }

        public static int getIndexOf(byte[] bigArray,byte[] smallArray) {
            try {
                if(bigArray==null||bigArray==null||bigArray.Length==0||smallArray.Length==0) return -1;
                int i, j;
                for(i=0;i<bigArray.Length;i++) {
                    if(bigArray[i]==smallArray[0]) {
                        for(j=1;j<smallArray.Length;j++) {
                            if(bigArray[i+j]!=smallArray[j]) break;
                        }
                        if(j==smallArray.Length) return i;
                    }
                }
                return -1;
            } catch(Exception e) {
                return -1;
            }
        }
    }
}
