using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH13Code:THCode {
        MemoryTool mt;
        private int bossEclAddress = 0;
        public override void setBoss(ComboBox boss) {
            byte[] memory = new byte[0x1000];
            byte[] bossEcl = g4EclCode.g4MainBossEcl;
            int index = 0;
            byte b = (byte)'1';
            switch(boss.Text) {
                case "Boss1": b=(byte)'1'; break;
                case "Boss2": b=(byte)'2'; break;
                case "Boss3": b=(byte)'3'; break;
                case "Boss4": b=(byte)'4'; break;
                case "Boss5": b=(byte)'5'; break;
                case "Boss6": b=(byte)'6'; break;
                case "Boss7": b=(byte)'7'; break;
            }
            if(bossEclAddress!=0) {
                mt.WriteBytes(bossEclAddress,new byte[] { b });
            } else {
                for(int i = 0x00400000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=getIndexOf(memory,bossEcl))!=-1) {
                        mt.WriteBytes(i+index+20,new byte[] { b });
                        bossEclAddress=i+index+20;
                        break;
                    }
                }
            }
        }
        public override void setStageAndBossList(ComboBox stageBox,ComboBox bossBox) {
            bossEclAddress=0;
            bossBox.Items.Clear();
            switch(stageBox.Text) {
                case "Stage1": bossBox.Items.AddRange(new object[] { "Boss1","Boss2","Boss3","Boss4" }); break;
                case "Stage2": bossBox.Items.AddRange(new object[] { "Boss1","Boss2","Boss3" }); break;
                case "Stage3": bossBox.Items.AddRange(new object[] { "Boss1","Boss2","Boss3" }); break;
                case "Stage4": bossBox.Items.AddRange(new object[] { "Boss1","Boss2","Boss3" }); break;
                case "Stage5": bossBox.Items.AddRange(new object[] { "Boss1","Boss2","Boss3","Boss4" }); break;
                case "Stage6": bossBox.Items.AddRange(new object[] { "Boss1","Boss2","Boss3","Boss4","Boss5","Boss6","Boss7" }); break;
            }
            setStEcl(stageBox.Text);
        }
        public override string getTitle() => new Random().Next()%2==0 ? "东方崩盘庙" : "东方神灵庙";
        public override string getAboutBug() => "符卡练习模式有些boss的位置与实际游戏中不同\n\n魔理沙的replay(汉化版)如果从1面以外播放可能录像爆炸(金发孩子真可怜.jpg)\n\n妖梦\"低速状态判定极小\"无效";
        public override string getAboutSpecial() => "灵界槽初始为200，最大值为600\n已得奖残会影响获得下一残机时需要的残碎片(红灵)数量";
        public override string[] getSpecialTip() => new string[] { "灵界槽","已得奖残","" };
        public override string[] getDefaultValue() => new string[] { "200","0","0" };
        public TH13Code(MemoryTool m) {
            mt=m;
            write(0x0042D3FB,new byte[] { 0xE9,0xD1,0x01,0x00,0x00,0x90,0x90,0x90,0x90 });  //jmp 0042D5D1
            write(0x0042D5D1,new byte[] { 0xC7,0x05,0x04,0xE8,0x4B,0x00,0x00,0x00,0x00,0x00,//mov [004BE804],0
                                          0xE9,0xDC,0xFE,0xFF,0xFF });                      //jmp 0042D4BC
            write(0x0042D4BC,new byte[] { 0xC7,0x46,0x44,0x00,0x00,0x00,0x00,0x90,          //mov [esi+44],0
                                          0xC7,0x46,0x40,0x00,0x00,0x00,0x00,               //mov [esi+40],0
                                          0xE9,0x34,0xFF,0xFF,0xFF });                      //jmp 0042D404
        }
        public override void StartCount() {
            //miss
            write(0x00444A52,new byte[] { 0xE9,0xEA,0xFC,0xFF,0xFF,0x90 });  //jmp 00444741
            write(0x00444741,new byte[] { 0xFF,0x0D,0xF4,0xE7,0x4B,0x00,     //dec [004BE7F4]
                                          0xE9,0xA7,0xFD,0xFF,0xFF });       //jmp 004444F3
            write(0x004444F3,new byte[] { 0xFF,0x05,0x80,0xEC,0x4B,0x00,0xE9,//inc [004BEC80]
                                          0x5A,0x05,0x00,0x00 });            //jmp 00444A58
            write(0x004BEC80,0);
            //bomb
            write(0x0040A404,new byte[] { 0xEB,0x7B,0x90,0x90,0x90 });   //jmp 0040A481
            write(0x0040A481,new byte[] { 0xA3,0x00,0xE8,0x4B,0x00,      //mov [004BE800],eax
                                          0xFF,0x05,0x84,0xEC,0x4B,0x00, //inc [004BEC84]
                                          0xEB,0x35 });                  //jmp 0040A4C3
            write(0x0040A4C3,new byte[] { 0xE9,0x41,0xFF,0xFF,0xFF });   //jmp 0040A409
            write(0x004BEC84,0);
        }
        public override int getMissCount() => mt.ReadInteger(0x004BEC80);
        public override int getBombCount() => mt.ReadInteger(0x004BEC84);
        public override int getBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004C2174)+0x5C);
        public override int getBossLife() => mt.ReadInteger(mt.ReadInteger(0x004C2190)+0x1B4);
        public override void killSelf() => write(mt.ReadInteger(0x004C22C4)+0x65C,4);
        public override bool[] getEnable() => new bool[29] { true,true,true,true,true,true,true,true,true,false,
                                                             true,true,true,true,true,true,true,true,true,false,
                                                             true,true,true,
                                                             true,true,true,true,true,true };
        public override void setLockPlayer(bool b) => write(0x00444741,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xFF,0x0D,0xF4,0xE7,0x4B,0x00 });//dec [004BE7F4]
        public override void setLockBomb(bool b) => write(0x0040A481,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xA3,0x00,0xE8,0x4B,0x00 });//mov [004BE800],eax
        public override void setUnbeatable(bool b) => write(0x00444D75,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xC7,0x87,0x5C,0x06,0x00,0x00,0x04,0x00,0x00,0x00 });//mov [edi+0000065C],00000004
        public override void setFPS(int i) {
            if(write(0x60016A8C,i)==0) {
                write(0x0045CE87,BitConverter.GetBytes((double)1/i));
                write(0x0045D368,new byte[] { 0xDD,0x05,0x87,0xCE,0x45,0x00 });//fld qword ptr [0045CE87]
            }
        }
        public override void setPlayer(int i) => write(0x004BE7F4,i);
        public override void setPlayerFragment(int i) => write(0x004BE7F8,i);
        public override void setBomb(int i) => write(0x004BE800,i);
        public override void setBombFragment(int i) => write(0x004BE804,i);
        public override void setPower(int i) => write(0x004BE7E8,i);
        public override void setScore(int i) => write(0x004BE7C0,i/10);
        public override void setMaxPoint(int i) => write(0x004BE7DC,i*100);
        public override void setSpecial1(int i) => write(0x004BE808,i);
        public override void setSpecial2(int i) => write(0x004BE7FC,i);
        public override void setSpecial3(int i) => throw new NotImplementedException();
        public override int getSpecial1() => mt.ReadInteger(0x004BE808);
        public override int getSpecial2() => mt.ReadInteger(0x004BE7FC);
        public override int getSpecial3() => throw new NotImplementedException();
        public override void setIPlayer(int i) {
            write(0x0042BC18,i);
            write(0x0042BC2D,i);
        }
        public override void setIPlayerFragment(int i) => write(0x0042D4C7,i);
        public override void setIBomb(int i) => write(0x0042D3DA,i);
        public override void setIBombFragment(int i) => write(0x0042D5D7,i);
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042BC69,new byte[] { 0x90,0x90,0x90,0x90,0x90 });       //nop
            write(0x0042BC87,new byte[] { 0x90,0x90,0x90,0x90,0x90 });       //nop
            write(0x0042D3CD,new byte[] { 0xEB,0xB5,0x90 });                 //jmp 0042D384
            write(0x0042D384,new byte[] { 0xC7,0x46,0x30,b[0],b[1],b[2],b[3],//mov [esi+30],b[]
                                          0xEB,0x43 });                      //jmp 0042D3D0
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x0042BB65,new byte[] { 0xE9,0x98,0xFC,0xFF,0xFF,0x90 });                 //jmp 0042B802
            write(0x0042B802,new byte[] { 0xC7,0x05,0xC0,0xE7,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004BE7C0],b[]
                                          0xEB,0x14 });                                     //jmp 0042B822
            write(0x0042B822,new byte[] { 0xE9,0x44,0x03,0x00,0x00 });                      //jmp 0042BB6B
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x0042BB76,new byte[] { 0xB8,b[0],b[1],b[2],b[3] });//mov eax,b[]
            write(0x0042BB7B,new byte[] { 0xEB,0x03,0x90,0x90,0x90 });//jmp 0042BB80
        }
        public override void setISpecial1(int i) => write(0x0042D407,i);
        public override void setISpecial2(int i) => write(0x0042D4BF,i);
        public override void setISpecial3(int i) => throw new NotImplementedException();
        private int getIndexOf(byte[] b,byte[] bb) {
            try {
                if(b==null||b==null||b.Length==0||bb.Length==0) return -1;
                int i, j;
                for(i=0;i<b.Length;i++) {
                    if(b[i]==bb[0]) {
                        for(j=1;j<bb.Length;j++) {
                            if(b[i+j]!=bb[j]) break;
                        }
                        if(j==bb.Length) return i;
                    }
                }
                return -1;
            } catch(Exception e) {
                return -1;
            }
        }
        private void setStEcl(string stage) {
            byte[] memory = new byte[0x1000];
            byte[] eclBefore = eclBefore=g4EclCode.g4EclBefore;
            byte[] eclAfter = eclAfter=g4EclCode.g4EclAfter;
            int index = 0;
            for(int i = 0x00400000;i<0x30000000;i+=0x1000) {
                memory=mt.ReadBytes(i,0x1000);
                if((index=getIndexOf(memory,eclBefore))!=-1) {
                    mt.WriteBytes(i+index,eclAfter);
                    break;
                }
            }
        }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
