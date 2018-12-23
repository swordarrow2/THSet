using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace THSet {
    public partial class TH09Form:Form {
        private Process pro;
        private MemoryTool mt;
        private string[] titles = new string[] { "缩在板底左右晃，除了C2不按上",
                                                 "BOSS过来并不慌，绝不反推就是肛",
                                                 "不连爆，不开花，就是C3一顿抓",
                                                 "C2C3一起发，地雷还能爆菊花",

                                                 "一个C1秒开花，挂机就等你自杀",
                                                 "无限开花不落地，猥琐到你删游戏",
                                                 "没走位，没防守，就是C2肛暴走",
                                                 "除了C1不乱跑，绝不进攻龟到老",

                                                 "放个C，躲3秒，无限复活赖到老",
                                                 "不进攻，不游走，就是贴身爆莉狗",
                                                 "不消弹，不硬钻，就是一顿C1穿",
                                                 "不控分，不乱跑，就是迅雷陪你搞",

                                                 "除了铜钱不跑杀，固灵闪到你眼瞎",
                                                 "开花强断不出手，你C我就凹后手",
                                                 "没压制，不抢先，输出全靠下毛片",
                                                 "不返送，不抢先，就是无限拖时间"};
        public TH09Form() {
            InitializeComponent();
            if(getPID("th09")!=0||getPID("th09c")!=0) {
                mt=new MemoryTool(pro);
            }
            timer1.Enabled=true;
        }

        private void bplayer1HP_Click(object sender,EventArgs e) => write(mt.ReadInteger(p1Addr.playerBase)+p1Addr.offsetHP,Convert.ToInt32(tplayer1HP.Text));
        private void bplayer1Hit_Click(object sender,EventArgs e) => write(mt.ReadInteger(p1Addr.playerBase)+p1Addr.offsetHit,Convert.ToInt32(tplayer1Hit.Text));
        private void bplayer1QiCao_Click(object sender,EventArgs e) => write(mt.ReadInteger(p1Addr.playerBase)+p1Addr.offsetCapacity,BitConverter.GetBytes(Convert.ToSingle(tplayer1QiCao.Text)));

        private void bplayer1NoName_Click(object sender,EventArgs e) {
            write(mt.ReadInteger(p1Addr.playerBase)+p1Addr.offsetNoName1,Convert.ToInt32(tplayer1NoName.Text));
            write(mt.ReadInteger(p1Addr.playerBase)+p1Addr.offsetNoName2,Convert.ToInt32(tplayer1NoName.Text));
        }
        private void bplayer1Score_Click(object sender,EventArgs e) {
            write(mt.ReadInteger(p1Addr.playerScoreBase)+p1Addr.offsetScore1,Convert.ToInt32(tplayer1Score.Text)/10);
            write(mt.ReadInteger(p1Addr.playerScoreBase)+p1Addr.offsetScore2,Convert.ToInt32(tplayer1Score.Text)/10);
        }
        private void cplayer1HP_CheckedChanged(object sender,EventArgs e) {
            write(p1Addr.codeAddressHP1,getOriginOrHookedValue(p1Addr.codeLockHP1,cplayer1HP.Checked));
            write(p1Addr.codeAddressHP2,getOriginOrHookedValue(p1Addr.codeLockHP2,cplayer1HP.Checked));
        }
        private void cplayer1NoName_CheckedChanged(object sender,EventArgs e) {
            write(p1Addr.codeAddressNoName11,getOriginOrHookedValue(p1Addr.codeLockNoName11,cplayer1NoName.Checked));
            write(p1Addr.codeAddressNoName12,getOriginOrHookedValue(p1Addr.codeLockNoName12,cplayer1NoName.Checked));
            write(p1Addr.codeAddressNoName21,getOriginOrHookedValue(p1Addr.codeLockNoName21,cplayer1NoName.Checked));
            write(p1Addr.codeAddressNoName22,getOriginOrHookedValue(p1Addr.codeLockNoName22,cplayer1NoName.Checked));
        }
        private void cplayer1QiCao_CheckedChanged(object sender,EventArgs e) {
            write(p1Addr.codeAddressCapacity1,getOriginOrHookedValue(p1Addr.codeLockCapacity1,cplayer1QiCao.Checked));
            write(p1Addr.codeAddressCapacity2,getOriginOrHookedValue(p1Addr.codeLockCapacity2,cplayer1QiCao.Checked));
            write(p1Addr.codeAddressCapacity3,getOriginOrHookedValue(p1Addr.codeLockCapacity3,cplayer1QiCao.Checked));
            write(p1Addr.codeAddressCapacity4,getOriginOrHookedValue(p1Addr.codeLockCapacity4,cplayer1QiCao.Checked));
        }

        private void bplayer2HP_Click(object sender,EventArgs e) => write(mt.ReadInteger(p2Addr.playerBase)+p2Addr.offsetHP,Convert.ToInt32(tplayer2HP.Text));
        private void bplayer2Hit_Click(object sender,EventArgs e) => write(mt.ReadInteger(p2Addr.playerBase)+p2Addr.offsetHit,Convert.ToInt32(tplayer2Hit.Text));
        private void bplayer2QiCao_Click(object sender,EventArgs e) => write(mt.ReadInteger(p2Addr.playerBase)+p2Addr.offsetCapacity,BitConverter.GetBytes(Convert.ToSingle(tplayer2QiCao.Text)));
        private void bplayer2NoName_Click(object sender,EventArgs e) {
            write(mt.ReadInteger(p2Addr.playerBase)+p2Addr.offsetNoName1,Convert.ToInt32(tplayer2NoName.Text));
            write(mt.ReadInteger(p2Addr.playerBase)+p2Addr.offsetNoName2,Convert.ToInt32(tplayer2NoName.Text));
        }
        private void bplayer2Score_Click(object sender,EventArgs e) {
            write(mt.ReadInteger(p2Addr.playerScoreBase)+p2Addr.offsetScore2,Convert.ToInt32(tplayer2Score.Text)/10);
            write(mt.ReadInteger(p2Addr.playerScoreBase)+p2Addr.offsetScore2,Convert.ToInt32(tplayer2Score.Text)/10);
        }
        private void cplayer2HP_CheckedChanged(object sender,EventArgs e) {
            write(p2Addr.codeAddressHP1,getOriginOrHookedValue(p2Addr.codeLockHP1,cplayer2HP.Checked));
            write(p2Addr.codeAddressHP2,getOriginOrHookedValue(p2Addr.codeLockHP2,cplayer2HP.Checked));
        }
        private void cplayer2NoName_CheckedChanged(object sender,EventArgs e) {
            write(p2Addr.codeAddressNoName11,getOriginOrHookedValue(p2Addr.codeLockNoName11,cplayer2NoName.Checked));
            write(p2Addr.codeAddressNoName12,getOriginOrHookedValue(p2Addr.codeLockNoName12,cplayer2NoName.Checked));
            write(p2Addr.codeAddressNoName21,getOriginOrHookedValue(p2Addr.codeLockNoName21,cplayer2NoName.Checked));
            write(p2Addr.codeAddressNoName22,getOriginOrHookedValue(p2Addr.codeLockNoName22,cplayer2NoName.Checked));
        }
        private void cplayer2QiCao_CheckedChanged(object sender,EventArgs e) {
            write(p2Addr.codeAddressCapacity1,getOriginOrHookedValue(p2Addr.codeLockCapacity1,cplayer2QiCao.Checked));
            write(p2Addr.codeAddressCapacity2,getOriginOrHookedValue(p2Addr.codeLockCapacity2,cplayer2QiCao.Checked));
            write(p2Addr.codeAddressCapacity3,getOriginOrHookedValue(p2Addr.codeLockCapacity3,cplayer2QiCao.Checked));
            write(p2Addr.codeAddressCapacity4,getOriginOrHookedValue(p2Addr.codeLockCapacity4,cplayer2QiCao.Checked));
        }
        private int getPID(string exeName) {
            try {
                pro=Process.GetProcessesByName(exeName)[0];
                return pro.Id;
            } catch {
                return 0;
            }
        }
        private void write(int address,int value) => mt.WriteInteger(address,value);
        private void write(int address,byte[] value) => mt.WriteBytes(address,value);
        private byte[] getOriginOrHookedValue(byte[] array,bool isHooked) {
            if(isHooked) {
                int le = array.Length;
                byte[] tmp = new byte[le];
                for(int i = 0;i<le;i++) tmp[i]=0x90;
                return tmp;
            } else {
                return array;
            }
        }
        private void timer1_Tick(object sender,EventArgs e) {
            if(getPID("th09")==0&&getPID("th09c")==0) Environment.Exit(Environment.ExitCode);
            Text=titles[mt.ReadInteger(0x004A7DB0)];
        }
    }
    public class p1Addr {
        public const int playerBase = 0x004A7D94;
        public const int playerScoreBase = 0x004A7DAC;

        public const int offsetHP = 0xA8;
        public const int offsetNoName1 = 0x3041C;
        public const int offsetNoName2 = 0x30420;
        public const int offsetHit = 0x30414;
        public const int offsetScore1 = 0x4;
        public const int offsetScore2 = 0x8;
        public const int offsetCapacity = 0x30388;

        public const int codeAddressHP1 = 0x0041E5CE;
        public const int codeAddressHP2 = 0x0041E5FE;
        public const int codeAddressNoName11 = 0x0041D7D2;
        public const int codeAddressNoName12 = 0x0041D7FF;
        public const int codeAddressNoName21 = 0x0041D7CF;
        public const int codeAddressNoName22 = 0x0041D7FC;
        public const int codeAddressCapacity1 = 0x0041CA8C;
        public const int codeAddressCapacity2 = 0x0041CABF;
        public const int codeAddressCapacity3 = 0x0041CB00;
        public const int codeAddressCapacity4 = 0x0041F339;

        public static readonly byte[] codeLockHP1 = new byte[] { 0x89,0x9E,0xA8,0x00,0x00,0x00 };
        public static readonly byte[] codeLockHP2 = new byte[] { 0x89,0x86,0xA8,0x00,0x00,0x00 };
        public static readonly byte[] codeLockNoName11 = new byte[] { 0x89,0x5E,0x0C };
        public static readonly byte[] codeLockNoName12 = new byte[] { 0x89,0x46,0x0C };
        public static readonly byte[] codeLockNoName21 = new byte[] { 0x89,0x5E,0x10 };
        public static readonly byte[] codeLockNoName22 = new byte[] { 0x89,0x46,0x10 };
        public static readonly byte[] codeLockCapacity1 = new byte[] { 0x89,0xBE,0x88,0x03,0x03,0x00 };
        public static readonly byte[] codeLockCapacity2 = new byte[] { 0x89,0x86,0x88,0x03,0x03,0x00 };
        public static readonly byte[] codeLockCapacity3 = new byte[] { 0x89,0xBE,0x88,0x03,0x03,0x00 };
        public static readonly byte[] codeLockCapacity4 = new byte[] { 0xD9,0x99,0x88,0x03,0x03,0x00 };
    }
    public class p2Addr {
        public const int playerBase = 0x004A7DCC;
        public const int playerScoreBase = 0x004A7DE4;

        public const int offsetHP = 0xA8;
        public const int offsetNoName1 = 0x3041C;
        public const int offsetNoName2 = 0x30420;
        public const int offsetHit = 0x30414;
        public const int offsetScore1 = 0x4;
        public const int offsetScore2 = 0x8;
        public const int offsetCapacity = 0x30388;

        public const int codeAddressHP1 = 0x0041E5FE;
        public const int codeAddressHP2 = 0x0041E632;
        public const int codeAddressNoName11 = 0x0041D7CF;
        public const int codeAddressNoName12 = 0x0041D7FF;
        public const int codeAddressNoName21 = 0x0042D7D2;
        public const int codeAddressNoName22 = 0x0042D7FC;
        public const int codeAddressCapacity1 = 0x0041F339;
        public const int codeAddressCapacity2 = 0x0041CA8C;
        public const int codeAddressCapacity3 = 0x0041CB00;
        public const int codeAddressCapacity4 = 0x0041CABF;

        public static readonly byte[] codeLockHP1 = new byte[] { 0x89,0x86,0xA8,0x00,0x00,0x00 };
        public static readonly byte[] codeLockHP2 = new byte[] { 0xC7,0x86,0xA8,0x00,0x00,0x00,0x01,0x00,0x00,0x00 };
        public static readonly byte[] codeLockNoName11 = new byte[] { 0x89,0x5E,0x10 };
        public static readonly byte[] codeLockNoName12 = new byte[] { 0x89,0x46,0x0C };
        public static readonly byte[] codeLockNoName21 = new byte[] { 0x89,0x5E,0x0C };
        public static readonly byte[] codeLockNoName22 = new byte[] { 0x89,0x46,0x10 };
        public static readonly byte[] codeLockCapacity1 = new byte[] { 0xD9,0x99,0x88,0x03,0x03,0x00 };
        public static readonly byte[] codeLockCapacity2 = new byte[] { 0x89,0xBE,0x88,0x03,0x03,0x00 };
        public static readonly byte[] codeLockCapacity3 = new byte[] { 0x89,0xBE,0x88,0x03,0x03,0x00 };
        public static readonly byte[] codeLockCapacity4 = new byte[] { 0x89,0x86,0x88,0x03,0x03,0x00 };
    }
}
