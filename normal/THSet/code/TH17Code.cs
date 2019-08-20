using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH17Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        private int bossNumAddress = 0;
        private int logoEnemyAddress = 0;
        public TH17Code(MemoryTool m) {
            mt=m;
            write(0x00499EBA,HexCodeHelper.stringToAsm("C7 05 60 5A 4B 00 00 00 00 00 C7 05 64 5A 4B 00 00 00 00 00 C7 05 68 5A 4B 00 00 00 00 00 C7 05 6C 5A 4B 00 00 00 00 00 C7 05 70 5A 4B 00 00 00 00 00 E9 B2 46 F7 FF"));
            write(0x0040E592,HexCodeHelper.stringToAsm("E9 23 B9 08 00 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90"));
        }

        public override void CheckNeedBomb() {
            thisStatu=mt.ReadInteger(0x004B77D0,0x18DB0);
            if(lastStatu!=4&&thisStatu==4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),0,0);
            } else if(lastStatu==4&&thisStatu!=4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),2,0);
            }
            lastStatu=thisStatu;
        }
        private string getText(MaterialListView l) {
            if(l.SelectedItems.Count>0) {
                return l.SelectedItems[0].Text;
            }
            return "";
        }
        public override void SetStage(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {
            bossNumAddress=0;
            logoEnemyAddress=0;
            boss.Items.Clear();
            chapter.Items.Clear();
            chapter.AddRange(EclHelper.chapter);
            switch(getText(stage)) {
                case "Stage1": boss.AddRange(EclHelper.TH16.stage1BossList); break;
                case "Stage2": boss.AddRange(EclHelper.TH16.stage2BossList); break;
                case "Stage3": boss.AddRange(EclHelper.TH16.stage3BossList); break;
                case "Stage4": boss.AddRange(EclHelper.TH16.stage4BossList); break;
                case "Stage5": boss.AddRange(EclHelper.TH16.stage5BossList); break;
                case "Stage6": boss.AddRange(EclHelper.TH16.stage6BossList); break;
                case "Extra": boss.AddRange(EclHelper.TH16.stage7BossList); break;
            }
        }
        public override void SetChapter(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {
            byte[] memory = new byte[0x1000];
            byte[] eclLogoEnemy = EclHelper.eclLogoEnemy;
            byte[] eclMainFront = EclHelper.stageEcl[0];
            byte[] eclMBoss = EclHelper.stageEcl[1];
            byte[] eclMainLatter = EclHelper.stageEcl[2];
            byte[] eclMainBoss = EclHelper.stageEcl[3];
            int index = 0;
            if(logoEnemyAddress!=0) {
                byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
                switch(getText(chapter)) {
                    case "前半": break;
                    case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
                    case "后半": eclByte=new byte[][] { eclMainLatter,eclMainBoss }; break;
                    case "关底Boss": eclByte=new byte[][] { eclMainBoss }; break;
                }
                mt.WriteBytes(logoEnemyAddress,EclHelper.createEcl(eclByte));
            } else {
                for(int i = 0x00500000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=EclHelper.getIndexOf(memory,eclLogoEnemy))!=-1) {
                        byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
                        switch(getText(chapter)) {
                            case "前半": break;
                            case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
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
        public override void SetMBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {

        }
        public override void SetBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {
            byte[] memory = new byte[0x1000];
            byte[] bossEcl = EclHelper.eclMainBossNum;
            int index = 0;
            byte[] b = EclHelper.getBossNumArray(getText(boss));
            if(bossNumAddress!=0) {
                mt.WriteBytes(bossNumAddress,b);
            } else {
                for(int i = 0x00500000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=EclHelper.getIndexOf(memory,bossEcl))!=-1) {
                        mt.WriteBytes(i+index+20,b);
                        bossNumAddress=i+index+20;
                        break;
                    }
                }
            }
        }
        public override string GetTitle() => new Random().Next()%2==0 ? "鸡你太美" : " 东 方 星 莲 船 ";
        public override string[] GetSpecialTip() => new string[] { "灵1","灵2","灵3" };
        public override string GetAboutBug() => "";
        public override string GetAboutSpecial() => "";
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() { }

        public override int GetMissCount() { return 0; }
        public override int GetBombCount() { return 0; }
        public override int GetBulletCount() { return 0; }
        public override int GetBossLife() { return 0; }
        public override void KillSelf() => write(mt.ReadInteger(0x004B77D0)+0x18DB0,4);
        public override bool[] GetEnable() => new bool[24] { true,true,true,true,true,false,true,
                                                             true,true,true,true,true,false,true,
                                                             true,true,true,true,false,false,false,true,true,true };
        public override void SetLockPlayer(bool b) {
            write(0x0044921B,HexCodeHelper.getValueArray("89 0D 40 5A 4B 00",b));
        }
        public override void SetLockBomb(bool b) {
            write(0x00411CAB,HexCodeHelper.getValueArray("89 0D 4C 5A 4B 00",b));
        }

        public override void SetUnbeatable(bool b) => write(0x00449564,HexCodeHelper.getValueArray("C7 87 B0 8D 01 00 04 00 00 00",b));
        public override void SetFPS(int i) {
            write(0x00462184,BitConverter.GetBytes((double)1/i));
            write(0x00462211,"F2 0F 10 0D 84 21 46 00");
        }
        public override void SetPlayer(int i) {
            write(0x004B5A40,i);
        }
        public override void SetPlayerFragment(int i) {
            write(0x004B5A44,i);
        }
        public override void SetBomb(int i) {
            write(0x004B5A4C,i);
        }
        public override void SetBombFragment(int i) {
            write(0x004B5A50,i);
        }
        public override void SetPower(int i) {
            write(0x004B5A30,i*100);
        }
        public override void SetScore(int i) { }
        public override void SetMaxPoint(int i) {
            write(0x004B5A24,i);
        }
        public override void SetSpecial1(int i) {
            write(0x004B5A64,i);
        }

        public override void SetSpecial2(int i) {
            write(0x004B5A68,i);
        }
        public override void SetSpecial3(int i) {
            write(0x004B5A6C,i);
        }
        public override void SetSpecial4(int i) {
            write(0x004B5A70,i);
        }
        public override int GetSpecial1() {
            return mt.ReadInteger(0x004B5A64);
        }
        public override int GetSpecial2() {
            return mt.ReadInteger(0x004B5A68);
        }
        public override int GetSpecial3() {
            return mt.ReadInteger(0x004B5A6C);
        }
        public override int GetSpecial4() {
            return mt.ReadInteger(0x004B5A70);
        }
        public override void SetIPlayer(int i) {
            write(0x00430463,i);
            write(0x0043044E,i);
        }
        public override void SetIPlayerFragment(int i) {
            //     write(0x00430315,i);
            write(0x0043031F,i);
        }
        public override void SetIBomb(int i) {
            write(0x004302E6,HexCodeHelper.stringToAsm("E9 A6 FC FF FF 90"));
            write(0x0042FF91,HexCodeHelper.stringToAsm("C7 05 4C 5A 4B 00 00 00 00 00 E9 4C 03 00 00"));
            write(0x0042FF97,i);
        }
        public override void SetIBombFragment(int i) {
            write(0x00430315,i);
        }
        public override void SetIPower(int i) {
            write(0x004304C6,HexCodeHelper.stringToAsm("E8 28 13 00 00"));
            write(0x004304EE,HexCodeHelper.stringToAsm("E8 00 13 00 00"));
            write(0x0043051E,HexCodeHelper.stringToAsm("E8 D0 12 00 00"));
            write(0x004317F3,HexCodeHelper.stringToAsm("C7 05 30 5A 4B 00 00 00 00 00 C3"));
            write(0x004317F9,i);

        }
        public override void SetIScore(int i) { }
        public override void SetIMaxPoint(int i) {
            write(0x004303F0,HexCodeHelper.stringToAsm("90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 C7 05 24 5A 4B 00 00 00 00 00"));
            write(0x00430405,i*100);
        }
        public override void SetISpecial1(int i) {
            write(0x00499ECA,i);
            write(0x00499EC0,checkCount());
        }
        public override void SetISpecial2(int i) {
            write(0x00499ED4,i);
            write(0x00499EC0,checkCount());
        }
        public override void SetISpecial3(int i) {
            write(0x00499EDE,i);
            write(0x00499EC0,checkCount());
        }
        public override void SetISpecial4(int i) {
            write(0x00499EE8,i);
            write(0x00499EC0,checkCount());
        }

        private int checkCount() {
            if(mt.ReadInteger(0x00499EE8)!=0) {
                return 4;
            }
            if(mt.ReadInteger(0x00499EDE)!=0) {
                return 3;
            }
            if(mt.ReadInteger(0x00499ED4)!=0) {
                return 2;
            }
            if(mt.ReadInteger(0x00499ECA)!=0) {
                return 1;
            }
            return 0;
        }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
        private int write(int addr,string value) => mt.WriteBytes(addr,HexCodeHelper.stringToAsm(value));
    }
}
