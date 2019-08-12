using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH14Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        public override void CheckNeedBomb() {
            thisStatu=mt.ReadInteger(mt.ReadInteger(0x004DB67C)+0x684);
            if(lastStatu!=4&&thisStatu==4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),0,0);
            } else if(lastStatu==4&&thisStatu!=4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),2,0);
            }
            lastStatu=thisStatu;
        }
        private int logoEnemyAddress = 0;
        private int bossEclAddress = 0;
        public TH14Code(MemoryTool m) => mt=m;

        private string getText(MaterialListView l) {
            if(l.SelectedItems.Count>0) {
                return l.SelectedItems[0].Text;
            }
            return "";
        }
        public override void SetStage(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {
            bossEclAddress=0;
            logoEnemyAddress=0;
            boss.Items.Clear();
            chapter.Items.Clear();
            chapter.AddRange(EclHelper.chapter);
            switch(getText(stage)) {
                case "Stage1": boss.AddRange(EclHelper.TH14.stage1BossList); break;
                case "Stage2": boss.AddRange(EclHelper.TH14.stage2BossList); break;
                case "Stage3": boss.AddRange(EclHelper.TH14.stage3BossList); break;
                case "Stage4": boss.AddRange(EclHelper.TH14.stage4BossList); break;
                case "Stage5": boss.AddRange(EclHelper.TH14.stage5BossList); break;
                case "Stage6": boss.AddRange(EclHelper.TH14.stage6BossList); chapter.Items.Clear(); chapter.AddRange(new string[] { "前半","道中Boss","关底Boss" }); break;
                case "Extra": boss.AddRange(EclHelper.TH14.stage7BossList); break;
            }
        }
        public override void SetChapter(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {
            byte[] memory = new byte[0x1000];
            byte[] eclLogoEnemy = EclHelper.eclLogoEnemy;
            byte[] eclMainFront = EclHelper.stageEcl[0];
            byte[] eclMBoss = EclHelper.stageEcl[1];
            byte[] eclMainLatter = EclHelper.stageEcl[2];
            byte[] eclMainBoss = EclHelper.stageEcl[3];
            if(getText(stage).Equals("Stage6")) {
                eclMBoss=EclHelper.TH14.eclStage6MBoss;
                eclMainLatter=new byte[] { };
            } else if(getText(stage).Equals("Stage4")) {
                eclMBoss=EclHelper.TH14.eclStage4MBoss;
            } else if(getText(stage).Equals("Extra")) {
                eclMBoss=EclHelper.TH14.eclExtraMBoss;
            }
            int index = 0;
            byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
            if(logoEnemyAddress!=0) {
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
        public override void SetMBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) { }
        public override void SetBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {
            byte[] memory = new byte[0x1000];
            byte[] bossEcl = EclHelper.eclMainBossNum;
            int index = 0;
            byte[] b = EclHelper.getBossNumArray(getText(boss));
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
        public override string GetTitle() => new Random().Next()%2==0 ? "东方掉帧城" : "东方1.6";
        public override string GetAboutBug() => "有时候播放replay出错，如果replay文件没问题，可重启游戏再播放此处\n\n魔理沙激光可能会歪，其中一部分会导致播放录像时出错而另一部分不会(录像中的激光也是歪的)";
        public override string GetAboutSpecial() => "非2.0为收点系统中获得的非Bonus2.0奖励的次数，已得奖残在辉针城似乎用处不大，2un仅仅设置了可获得的上限";
        public override string[] GetSpecialTip() => new string[] { "非2.0数","已得奖残","" };
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() {
            //miss
            write(0x0044F618,new byte[] { 0xEB,0xB7,0x90,0x90,0x90 });    //jmp 0044F5D1
            write(0x0044F5D1,new byte[] { 0xA3,0x64,0x58,0x4F,0x00,       //mov [004F5864],eax
                                          0xFF,0x05,0xC0,0x59,0x4F,0x00,  //inc [004F59C0]
                                          0xEB,0x3F });                   //jmp 0044F61D
            write(0x004F59C0,0);
            //bomb
            write(0x0041218A,new byte[] { 0xE9,0x76,0xFF,0xFF,0xFF });    //jmp 00412105
            write(0x00412105,new byte[] { 0xFF,0x05,0xC4,0x59,0x4F,0x00,  //inc [004F59C4]
                                          0xEB,0xE8,0x00,0x00,0x00 });    //jmp 004120F5
            write(0x004120F5,new byte[] { 0xA3,0x70,0x58,0x4F,0x00,       //mov [004F5870],eax
                                          0xE9,0x90,0x00,0x00,0x00 });    //jmp 0041218F
            write(0x004F59C4,0);
        }
        public override int GetMissCount() => mt.ReadInteger(0x004F59C0);
        public override int GetBombCount() => mt.ReadInteger(0x004F59C4);
        public override int GetBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004DB530)+0x5C);
        public override int GetBossLife() => mt.ReadInteger(mt.ReadInteger(0x004DB550)+0x1B0);
        public override void KillSelf() => write(mt.ReadInteger(0x004DB67C)+0x684,4);
        public override bool[] GetEnable() => new bool[24] { true,true,true,true,true,true,true,
                                                             true,true,true,true,true,true,true,
                                                             true,true,true,true,true,true,true,true,true,true };
        public override void SetLockPlayer(bool b) => write(0x0044F5D1,HexCodeHelper.getValueArray(new byte[] { 0xA3,0x64,0x58,0x4F,0x00 },b));//mov [004F5864],eax
        public override void SetLockBomb(bool b) => write(0x004120F5,HexCodeHelper.getValueArray(new byte[] { 0xA3,0x70,0x58,0x4F,0x00 },b));//mov [004F5870],eax
        public override void SetUnbeatable(bool b) => write(0x0044F871,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x87,0x84,0x06,0x00,0x00,0x04,0x00,0x00,0x00 },b));//mov [edi+00000684],00000004
        public override void SetFPS(int i) {
            mt.WriteBytes(0x0046A715,BitConverter.GetBytes((double)1/i));
            mt.WriteBytes(0x0046A78E,new byte[] { 0xF2,0x0F,0x10,0x15,0x15,0xA7,0x46,0x00 });//movsd xmm2,[0046A715]
        }
        public override void SetPlayer(int i) => write(0x004F5864,i);
        public override void SetPlayerFragment(int i) => write(0x004F5868,i);
        public override void SetBomb(int i) => write(0x004F5870,i);
        public override void SetBombFragment(int i) => write(0x004F5874,i);
        public override void SetPower(int i) => write(0x004F5858,i);
        public override void SetScore(int i) => write(0x004F5830,i);
        public override void SetMaxPoint(int i) => write(0x004F584C,i*100);
        public override void SetSpecial1(int i) => write(0x004F5894,i);
        public override void SetSpecial2(int i) => write(0x004F586C,i);
        public override void SetSpecial3(int i) { }
        public override void SetSpecial4(int i) { }
        public override int GetSpecial1() => mt.ReadInteger(0x004F5894);
        public override int GetSpecial2() => mt.ReadInteger(0x004F586C);
        public override int GetSpecial3() { return 0; }
        public override int GetSpecial4() { return 0; }
        public override void SetIPlayer(int i) {
            write(0x00435D42,i);
            write(0x00435D57,i);
        }
        public override void SetIPlayerFragment(int i) => write(0x004375E4,i);
        public override void SetIBomb(int i) => write(0x004375C1,i);
        public override void SetIBombFragment(int i) => write(0x004375DD,i);
        public override void SetIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00435DBA,HexCodeHelper.getNop(5));
            write(0x00435E12,HexCodeHelper.getNop(5));
            write(0x00435DE2,HexCodeHelper.getNop(6));
            write(0x00435D86,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90 });            //mov ecx,b[]
            write(0x004375B3,i);
        }
        public override void SetIScore(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00435C95,new byte[] { 0xE9,0xC9,0x10,0x00,0x00,0x90 });                 //jmp 00436D63
            write(0x00436D63,new byte[] { 0xC7,0x05,0x30,0x58,0x4F,0x00,b[0],b[1],b[2],b[3],//mov [004F5830],b[]
                                          0xEB,0x06 });                                     //jmp 00436D75
            write(0x00436D75,new byte[] { 0xE9,0x21,0xEF,0xFF,0xFF });                      //jmp 00435C9B
        }
        public override void SetIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00435CB0,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90 });            //mov ecx,b[]
        }
        public override void SetISpecial1(int i) => write(0x0043760E,i);
        public override void SetISpecial2(int i) => write(0x004375EB,i);
        public override void SetISpecial3(int i) { }
        public override void SetISpecial4(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
