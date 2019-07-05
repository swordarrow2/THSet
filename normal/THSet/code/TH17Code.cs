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
        public TH17Code(MemoryTool m) => mt=m;
        public override void CheckNeedBomb() {
            thisStatu=mt.ReadInteger(0x004B33EC,0x18DAC);
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
        public override string GetTitle() => new Random().Next()%2==0 ? "th17体验版" : " 东 方 星 莲 船 ";
        public override string[] GetSpecialTip() => new string[] { "","","" };
        public override string GetAboutBug() => "";
        public override string GetAboutSpecial() => "";
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() { }

        public override int GetMissCount() { return 0; }
        public override int GetBombCount() { return 0; }
        public override int GetBulletCount() { return 0; }
        public override int GetBossLife() { return 0; }
        public override void KillSelf() => write(mt.ReadInteger(0x004B33EC)+0x18DAC,4);
        public override bool[] GetEnable() => new bool[24] { false,false,false,false,false,false,false,
                                                             false,false,false,false,false,false,false,
                                                             true,true,true,true,false,false,false,true,false,true };
        public override void SetLockPlayer(bool b) {
            write(0x00448720,HexCodeHelper.getValueArray("89 0D 98 16 4B 00",b));                    //mov [004B1698],ecx
        }
        public override void SetLockBomb(bool b) {
            write(0x00411BC5,HexCodeHelper.getValueArray("89 0D A4 16 4B 00",b));                    //mov [004B16A4],ecx
        }

        public override void SetUnbeatable(bool b) => write(0x00448A64,HexCodeHelper.getValueArray("C7 87 AC 8D 01 00 04 00 00 00",b));//mov [edi+00018DAC],00000004
        public override void SetFPS(int i) {
            write(0x004622B3,BitConverter.GetBytes((double)1/i));
            write(0x004620B1,"F2 0F 10 0D B3 22 46 00");//movsd xmm1,[004622B3]
        }
        public override void SetPlayer(int i) { }
        public override void SetPlayerFragment(int i) { }
        public override void SetBomb(int i) { }
        public override void SetBombFragment(int i) { }
        public override void SetPower(int i) { }
        public override void SetScore(int i) { }
        public override void SetMaxPoint(int i) { }
        public override void SetSpecial1(int i) => write(mt.ReadInteger(0x004B5654)+0x16838,BitConverter.GetBytes(i/100f));
        public override void SetSpecial2(int i) { }
        public override void SetSpecial3(int i) { }
        public override void SetSpecial4(int i) { }
        public override int GetSpecial1() => (int)(mt.ReadFloat(mt.ReadInteger(0x004B5654)+0x16838)*100);
        public override int GetSpecial2() { return 0; }
        public override int GetSpecial3() { return 0; }
        public override int GetSpecial4() { return 0; }
        public override void SetIPlayer(int i) { MessageBox.Show("text:"+i); }
        public override void SetIPlayerFragment(int i) { }
        public override void SetIBomb(int i) { }
        public override void SetIBombFragment(int i) { }
        public override void SetIPower(int i) { }
        public override void SetIScore(int i) { }
        public override void SetIMaxPoint(int i) { }
        public override void SetISpecial1(int i) { }
        public override void SetISpecial2(int i) { }
        public override void SetISpecial3(int i) { }
        public override void SetISpecial4(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
        private int write(int addr,string value) => mt.WriteBytes(addr,HexCodeHelper.stringToAsm(value));
    }
}
