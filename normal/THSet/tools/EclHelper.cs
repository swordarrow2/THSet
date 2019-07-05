using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public class EclHelper {

        public static readonly byte[] eclMainBossNum = HexCodeHelper.stringToAsm("0B001C000000FF010000000008000000426F7373");
        public static readonly byte[] eclLogoEnemy = HexCodeHelper.stringToAsm("0F0020000000FF01000000000C0000004C6F676F456E656D79");

        public static readonly string[] chapter = new string[] { "前半","道中Boss","后半","关底Boss" };

        public static class bossCount {
            public static readonly string[] count2 = new string[] { "Boss1","Boss2" };
            public static readonly string[] count3 = new string[] { "Boss1","Boss2","Boss3" };
            public static readonly string[] count4 = new string[] { "Boss1","Boss2","Boss3","Boss4" };
            public static readonly string[] count5 = new string[] { "Boss1","Boss2","Boss3","Boss4","Boss5" };
            public static readonly string[] count6 = new string[] { "Boss1","Boss2","Boss3","Boss4","Boss5","Boss6" };
            public static readonly string[] count7 = new string[] { "Boss1","Boss2","Boss3","Boss4","Boss5","Boss6","Boss7" };
            public static readonly string[] count10 = new string[] { "Boss1","Boss2","Boss3","Boss4","Boss5","Boss6","Boss7","Boss8","Boss9","Boss10" };
        }
        public static readonly byte[][] stageEcl = new byte[][] {
                //MainFront
                HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E46726F6E740000003C0000000D0210000000FF00000000003C000000"),
                //Mboss
                HexCodeHelper.stringToAsm("2D0130000000FF0600000000080000004D426F737300000000004043000000C228000000E8030000010000003C000000170014000000FF0100000000A00000003C000000"),
                //MainLatter
                HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E4C617474657200003C000000170014000000FF0100000000900100003C0000000D0210000000FF00000000003C000000680214000000FF0100000000000020443C0000000C0214000000FF0100000000290000003C000000060214000000FF0100000000000000003C000000"),
                //MainBoss
                HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E426F7373000000003C0000000C0018000000FF02000000002C0000003C0000003C000000170014000000FF0100000000E80300003C0000002A0014000000FF0100000000010000003C0000000E0018000000FF0200000000 D8FFFFFF3C0000003C000000010010000000FF0000000000"),
            };
        public static class TH13 {
            public static readonly byte[] eclExtraMBoss = HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E4D426F73730000003C000000");
            public static readonly byte[] eclExtraMainLatter = HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E4C617474657200003C000000170014000000FF0100000000F40100003C0000000C0214000000FF0100000000050000003C000000060214000000FF0100000000000000003C0000000C0214000000FF0100000000060000003C000000");
            public static readonly byte[] eclStage5MBoss = HexCodeHelper.stringToAsm("0B 00 20 00 00 00 FF 01 00 00 00 00 0C 00 00 00 4D 61 69 6E 4D 42 6F 73 73 00 00 00 3C 00 00 00 0B");
            public static readonly byte[] eclStage6MBoss = HexCodeHelper.stringToAsm("170014000000FF0100000000900100003C0000000C0214000000FF0100000000050000003C000000060214000000FF0100000000000000003C0000000C0214000000FF0100000000060000003C000000");
            public static readonly string[] stage1BossList = bossCount.count4;
            public static readonly string[] stage2BossList = bossCount.count3;
            public static readonly string[] stage3BossList = bossCount.count3;
            public static readonly string[] stage4BossList = bossCount.count3;
            public static readonly string[] stage5BossList = bossCount.count4;
            public static readonly string[] stage6BossList = bossCount.count7;
            public static readonly string[] stage7BossList = bossCount.count10;
        }

        public static class TH14 {
            public static readonly byte[] eclStage4MBoss = HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E4D426F73730000003C000000170014000000FF0100000000A00000003C000000");
            public static readonly byte[] eclStage6MBoss = HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E4D426F73730000003C000000080210000000FF00000000003C000000170014000000FF0100000000B40000003C000000860310000000FF00000000003C0000000C0214000000FF0100000000050000003C000000060214000000FF0100000000000000003C0000000C0214000000FF0100000000060000003C000000");
            public static readonly byte[] eclExtraMBoss = HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E4D426F73730000003C000000170014000000FF0100000000B40000003C000000170014000000FF0100000000BC0200003C0000000B0020000000FF01000000000C0000004D61696E53756230340000003C000000");
            public static readonly string[] stage1BossList = bossCount.count2;
            public static readonly string[] stage2BossList = bossCount.count3;
            public static readonly string[] stage3BossList = bossCount.count3;
            public static readonly string[] stage4BossList = bossCount.count3;
            public static readonly string[] stage5BossList = bossCount.count3;
            public static readonly string[] stage6BossList = bossCount.count6;
            public static readonly string[] stage7BossList = bossCount.count10;
        }

        /*    public static class TH15 {
                public static readonly byte[] eclSuZhiSanHuDie = new byte[] { };
                public static readonly byte[] eclTaiTianFeiXingZhen = new byte[] { };
                public static readonly byte[] eclExtraMainLatter = new byte[] {0x0B,0x00,0x20,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x0C,0x00,0x00,0x00,0x4D,0x61,0x69,0x6E,0x4C,0x61,0x74,0x74,0x65,0x72,0x00,0x00,0x3C,0x00,0x00,0x00,0x17,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x78,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x68,0x02,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x00,0x00,0x20,0x44,0x3C,0x00,0x00,0x00,0x3B,0x02,0x10,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x0C,0x02,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x29,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x17,0x00,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0xA0,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x06,0x02,0x14,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x3C,0x00,0x00,0x00 };
                public static readonly byte[] eclTH15ExtraMainBossNum = new byte[] {0x16,0x00,0x20,0x00,0x00,0x00,0xFF,0x02,0x00,0x00,0x00,0x00,0x03,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x37,0x00,0x00,0x00,0x05,0x00,0x00,0x00,0x0B,0x00,0x1C,0x00,0x00,0x00,0xFF,0x01,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00,0x42,0x6F,0x73,0x73,0x31 };
                public static readonly string[] stage1BossList = bossCount.count2;
                public static readonly string[] stage2BossList = bossCount.count3;
                public static readonly string[] stage3BossList = bossCount.count4;
                public static readonly string[] stage4BossList = bossCount.count4;
                public static readonly string[] stage5BossList = bossCount.count5;
                public static readonly string[] stage6BossList = bossCount.count7;
                public static readonly string[] stage7BossList = bossCount.count10;
            }
            */
        public static class TH16 {
            public static readonly byte[] eclStage5CreateMainBoss = HexCodeHelper.stringToAsm("2D0130000000FF060000000008000000426F73730000000000001043000080C128000000E8030000010000003C000000060214000000FF0100000000000000003C0000000B0020000000FF01000000000C0000004D61696E426F7373000000003C0000000C0018000000FF02000000002C0000003C0000003C000000170014000000FF0100000000E80300003C0000002A0014000000FF0100000000010000003C0000000E0018000000FF0200000000D8FFFFFF3C0000003C000000010010000000FF0000000000");
            public static readonly byte[] eclTaiTianFeiXingZhen = HexCodeHelper.stringToAsm("0B0020000000FF01000000000C0000004D61696E537562303400000000000000170014000000FF0100000000 DC0000000000000016002C000000FF020000000006000000140000004465627567536B697053746F7046756E63000000000000000B0020000000FF01000000000C0000004D61696E537562303500000000000000060214000000FF0100000000000000003C000000");
            public static readonly byte[] eclExtraMBoss = HexCodeHelper.stringToAsm("2D0130000000FF0600000000080000004D426F73730000000000C042000000C228000000E8030000010000003C0000002D0130000000FF0600000000080000004D426F73734200000000C0C2000000C228000000E8030000010000003C000000170014000000FF0100000000140000003C000000080210000000FF00000000003C000000");
            public static readonly string[] stage1BossList = bossCount.count2;
            public static readonly string[] stage2BossList = bossCount.count3;
            public static readonly string[] stage3BossList = bossCount.count3;
            public static readonly string[] stage4BossList = bossCount.count3;
            public static readonly string[] stage5BossList = bossCount.count4;
            public static readonly string[] stage6BossList = bossCount.count6;
            public static readonly string[] stage7BossList = bossCount.count10;
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
            } catch {
                return -1;
            }
        }

        public static byte[] createEcl(byte[][] b) {
            List<byte> lb = new List<byte>();
            for(int i = 0;i<b.Length;i++) {
                for(int j = 0;j<b[i].Length;j++) {
                    lb.Add(b[i][j]);
                }
            }
            return lb.ToArray<byte>();
        }
    }
}
