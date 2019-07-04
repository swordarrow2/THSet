using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH13Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        public override void CheckNeedBomb() {
            thisStatu=mt.ReadInteger(mt.ReadInteger(0x004C22C4)+0x65C);
            if(lastStatu!=4&&thisStatu==4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),0,0);
                write(0x004BEC88,5);
                write(0x004BE7C8,5);
            } else if(lastStatu==4&&thisStatu!=4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),2,0);
            }
            lastStatu=thisStatu;
        }
        private int logoEnemyAddress = 0;
        private int bossEclAddress = 0;
        public override void SetStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) {
            bossEclAddress=0;
            logoEnemyAddress=0;
            bossBox.Items.Clear();
            chapterBox.Items.Clear();
            chapterBox.Items.AddRange(EclHelper.chapter);
            switch(stageBox.Text) {
                case "Stage1": bossBox.Items.AddRange(EclHelper.TH13.stage1BossList); break;
                case "Stage2": bossBox.Items.AddRange(EclHelper.TH13.stage2BossList); break;
                case "Stage3": bossBox.Items.AddRange(EclHelper.TH13.stage3BossList); break;
                case "Stage4": bossBox.Items.AddRange(EclHelper.TH13.stage4BossList); chapterBox.Items.Clear(); chapterBox.Items.AddRange(new object[] { "前半","道中Boss","太田飞行阵","关底Boss" }); break;
                case "Stage5": bossBox.Items.AddRange(EclHelper.TH13.stage5BossList); break;
                case "Stage6": bossBox.Items.AddRange(EclHelper.TH13.stage6BossList); chapterBox.Items.Clear(); chapterBox.Items.AddRange(new object[] { "前半","关底Boss" }); break;
                case "Extra": bossBox.Items.AddRange(EclHelper.TH13.stage7BossList); break;
            }
        }
        public override void SetChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) {
            byte[] memory = new byte[0x1000];
            byte[] eclLogoEnemy = EclHelper.eclLogoEnemy;
            byte[] eclMainFront = EclHelper.stageEcl[0];
            byte[] eclMBoss =  EclHelper.stageEcl[1];
            switch(stageBox.Text) {
                case "Extra":
                    eclMBoss=EclHelper.TH13.eclExtraMBoss;
                    break;
                case "Stage5":
                    eclMBoss=EclHelper.TH13.eclStage5MBoss;
                    break;
            }
            byte[] eclMainLatter = stageBox.Text.Equals("Extra") ? EclHelper.TH13.eclExtraMainLatter : EclHelper.stageEcl[2];
            byte[] eclMainBoss = EclHelper.stageEcl[3];
            if(stageBox.Text.Equals("Stage6")) {
                eclMBoss=EclHelper.TH13.eclStage6MBoss;
                eclMainLatter=new byte[] { };
            }
            int index = 0;
            byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
            if(logoEnemyAddress!=0) {
                switch(chapterBox.Text) {
                    case "前半": break;
                    case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
                    case "太田飞行阵":
                    case "后半": eclByte=new byte[][] { eclMainLatter,eclMainBoss }; break;
                    case "关底Boss": eclByte=new byte[][] { eclMainBoss }; break;
                }
                mt.WriteBytes(logoEnemyAddress,EclHelper.createEcl(eclByte));
            } else {
                for(int i = 0x00500000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=EclHelper.getIndexOf(memory,eclLogoEnemy))!=-1) {
                        switch(chapterBox.Text) {
                            case "前半": break;
                            case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
                            case "太田飞行阵":
                            case "后半": eclByte=new byte[][] { eclMainLatter,eclMainBoss }; break;
                            case "关底Boss": eclByte=new byte[][] { eclMainBoss }; break;
                        }
                        mt.WriteBytes(i+index,EclHelper.createEcl(eclByte));
                        logoEnemyAddress=i+index;
                        break;
                    }
                }
            }
        }
        public override void SetMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) {
            byte[] memory = new byte[0x1000];
            byte[] bossEcl = EclHelper.eclMainBossNum;
            int index = 0;
            byte[] b = EclHelper.getBossNumArray(bossBox.Text);
            if(bossEclAddress!=0) {
                mt.WriteBytes(bossEclAddress,b);
            } else {
                for(int i = 0x00500000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=EclHelper.getIndexOf(memory,bossEcl))!=-1) {
                        mt.WriteBytes(i+index+20,b);
                        bossEclAddress=i+index+20;
                        break;
                    }
                }
            }
        }
        public override string GetTitle() => new Random().Next()%2==0 ? "东方崩盘庙" : "东方神灵庙";
        public override string GetAboutBug() => "符卡练习模式有些boss的位置与实际游戏中不同\n\n魔理沙的replay(汉化版)如果从1面以外播放可能录像爆炸(金发孩子真可怜.jpg)\n\n妖梦\"低速状态判定极小\"无效";
        public override string GetAboutSpecial() => "灵界槽初始为200，最大值为600\n已得奖残会影响获得下一残机时需要的残碎片(红灵)数量";
        public override string[] GetSpecialTip() => new string[] { "灵界槽","已得奖残","" };
        public override string[] GetDefaultValue() => new string[] { "200","0","0" };
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
        public override int GetMissCount() => mt.ReadInteger(0x004BEC80);
        public override int GetBombCount() => mt.ReadInteger(0x004BEC84);
        public override int GetBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004C2174)+0x5C);
        public override int GetBossLife() => mt.ReadInteger(mt.ReadInteger(0x004C2190)+0x1B4);
        public override void KillSelf() => write(mt.ReadInteger(0x004C22C4)+0x65C,4);
        public override bool[] GetEnable() => new bool[30] { true,true,true,true,true,true,true,true,true,false,
                                                             true,true,true,true,true,true,true,true,true,false,
                                                             true,true,true,
                                                             true,true,true,true,true,true,true };
        public override void SetLockPlayer(bool b) => write(0x00444741,HexCodeHelper.getValueArray(new byte[] { 0xFF,0x0D,0xF4,0xE7,0x4B,0x00 },b));//dec [004BE7F4]
        public override void SetLockBomb(bool b) => write(0x0040A481,HexCodeHelper.getValueArray(new byte[] { 0xA3,0x00,0xE8,0x4B,0x00 },b));//mov [004BE800],eax
        public override void SetUnbeatable(bool b) => write(0x00444D75,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x87,0x5C,0x06,0x00,0x00,0x04,0x00,0x00,0x00 },b));//mov [edi+0000065C],00000004
        public override void SetFPS(int i) {
            if(write(0x60016A8C,i)==0) {
                write(0x0045CE87,BitConverter.GetBytes((double)1/i));
                write(0x0045D368,new byte[] { 0xDD,0x05,0x87,0xCE,0x45,0x00 });//fld qword ptr [0045CE87]
            }
        }
        public override void SetPlayer(int i) => write(0x004BE7F4,i);
        public override void SetPlayerFragment(int i) => write(0x004BE7F8,i);
        public override void SetBomb(int i) => write(0x004BE800,i);
        public override void SetBombFragment(int i) => write(0x004BE804,i);
        public override void SetPower(int i) => write(0x004BE7E8,i);
        public override void SetScore(int i) => write(0x004BE7C0,i);
        public override void SetMaxPoint(int i) => write(0x004BE7DC,i*100);
        public override void SetSpecial1(int i) => write(0x004BE808,i);
        public override void SetSpecial2(int i) => write(0x004BE7FC,i);
        public override void SetSpecial3(int i) { }
        public override int GetSpecial1() => mt.ReadInteger(0x004BE808);
        public override int GetSpecial2() => mt.ReadInteger(0x004BE7FC);
        public override int GetSpecial3() { return 0; }
        public override void SetIPlayer(int i) {
            write(0x0042BC18,i);
            write(0x0042BC2D,i);
        }
        public override void SetIPlayerFragment(int i) => write(0x0042D4C7,i);
        public override void SetIBomb(int i) => write(0x0042D3DA,i);
        public override void SetIBombFragment(int i) => write(0x0042D5D7,i);
        public override void SetIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042BC69,HexCodeHelper.getNop(5));
            write(0x0042BC87,HexCodeHelper.getNop(5));
            write(0x0042D3CD,new byte[] { 0xEB,0xB5,0x90 });                 //jmp 0042D384
            write(0x0042D384,new byte[] { 0xC7,0x46,0x30,b[0],b[1],b[2],b[3],//mov [esi+30],b[]
                                          0xEB,0x43 });                      //jmp 0042D3D0
        }
        public override void SetIScore(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042BB65,new byte[] { 0xE9,0x98,0xFC,0xFF,0xFF,0x90 });                 //jmp 0042B802
            write(0x0042B802,new byte[] { 0xC7,0x05,0xC0,0xE7,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004BE7C0],b[]
                                          0xEB,0x14 });                                     //jmp 0042B822
            write(0x0042B822,new byte[] { 0xE9,0x44,0x03,0x00,0x00 });                      //jmp 0042BB6B
        }
        public override void SetIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x0042BB76,new byte[] { 0xB8,b[0],b[1],b[2],b[3] });//mov eax,b[]
            write(0x0042BB7B,new byte[] { 0xEB,0x03,0x90,0x90,0x90 });//jmp 0042BB80
        }
        public override void SetISpecial1(int i) => write(0x0042D407,i);
        public override void SetISpecial2(int i) => write(0x0042D4BF,i);
        public override void SetISpecial3(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
