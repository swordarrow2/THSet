using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH16Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        int autoBombCount = 0;
        private int bossNumAddress = 0;
        private int logoEnemyAddress = 0;
        public TH16Code(MemoryTool m) => mt=m;
        public override void CheckNeedBomb() {
            thisStatu=mt.ReadInteger(mt.ReadInteger(0x004A6EF8)+0x165A8);
            if(lastStatu!=4&&thisStatu==4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),0,0);
                write(0x004A5954,autoBombCount++);
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
                case "Stage2": boss.AddRange(EclHelper.TH16.stage2BossList); chapter.Items.Clear(); chapter.AddRange(new string[] { "前半","道中Boss","关底Boss" }); break;
                case "Stage3": boss.AddRange(EclHelper.TH16.stage3BossList); break;
                case "Stage4": boss.AddRange(EclHelper.TH16.stage4BossList); chapter.Items.Clear(); chapter.AddRange(new string[] { "前半","道中Boss","后半","太田飞行阵","关底Boss" }); break;
                case "Stage5": boss.AddRange(EclHelper.TH16.stage5BossList); break;
                case "Stage6": boss.AddRange(EclHelper.TH16.stage6BossList); chapter.Items.Clear(); chapter.AddRange(new string[] { "关底Boss" }); break;
                case "Extra": boss.AddRange(EclHelper.TH16.stage7BossList); break;
            }
        }
        public override void SetChapter(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) {
            byte[] memory = new byte[0x1000];
            byte[] eclLogoEnemy = EclHelper.eclLogoEnemy;
            byte[] eclMainFront = EclHelper.stageEcl[0];
            byte[] eclMBoss = getText(stage).Equals("Extra") ? EclHelper.TH16.eclExtraMBoss : EclHelper.stageEcl[1];
            byte[] eclMainLatter = getText(stage).Equals("Stage2") ? new byte[] { } : EclHelper.stageEcl[2];
            byte[] eclMainBoss = getText(stage).Equals("Stage5") ? EclHelper.TH16.eclStage5CreateMainBoss : EclHelper.stageEcl[3];
            int index = 0;
            if(logoEnemyAddress!=0) {
                byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
                switch(getText(chapter)) {
                    case "前半": break;
                    case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
                    case "后半": eclByte=new byte[][] { eclMainLatter,eclMainBoss }; break;
                    case "太田飞行阵": eclByte=new byte[][] { EclHelper.TH16.eclTaiTianFeiXingZhen,eclMainBoss }; break;
                    case "关底Boss": eclByte=new byte[][] { eclMainBoss }; break;
                }
                mt.WriteBytes(logoEnemyAddress,EclHelper.createEcl(eclByte));
            } else {
                for(int i = 0x00500000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=EclHelper.getIndexOf(memory,eclLogoEnemy))!=-1) {
                        //mt.WriteBytes(i+index,eclAfter);
                        byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
                        switch(getText(chapter)) {
                            case "前半": break;
                            case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
                            case "后半": eclByte=new byte[][] { eclMainLatter,eclMainBoss }; break;
                            case "太田飞行阵": eclByte=new byte[][] { EclHelper.TH16.eclTaiTianFeiXingZhen,eclMainBoss }; break;
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

        public override string GetTitle() => new Random().Next()%2==0 ? "东方Bug璋" : "东方CBC";
        public override string GetAboutBug() => "太多了，我就不写了……";
        public override string GetAboutSpecial() => "季节槽范围为0-1140";
        public override string[] GetSpecialTip() => new string[] { "季节槽","","" };
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() {
            //miss
            write(0x00443D3A,new byte[] { 0xEB,0x89,0x90,0x90,0x90 });  //jmp 00443CC5
            write(0x00443CC5,new byte[] { 0xA3,0xF4,0x57,0x4A,0x00,     //mov [004A57F4],eax
                                          0xE9,0x13,0xFE,0xFF,0xFF });  //jmp 00443AE2
            write(0x00443AE2,new byte[] { 0xFF,0x05,0x4C,0x59,0x4A,0x00,//inc [004A594C]
                                          0xE9,0x52,0x02,0x00,0x00 });  //jmp 00443D3F
            write(0x004A594C,0);
            //bomb
            write(0x0040DB9C,new byte[] { 0xE9,0xE5,0xFE,0xFF,0xFF });  //jmp 0040DA86
            write(0x0040DA86,new byte[] { 0xA3,0x00,0x58,0x4A,0x00,     //mov [004A5800],eax
                                          0xEB,0xD8 });                 //jmp 0040DA65
            write(0x0040DA65,new byte[] { 0xFF,0x05,0x50,0x59,0x4A,0x00,//inc [004A5950]
                                          0xE9,0x31,0x01,0x00,0x00 });  //jmp 0040DBA1
            write(0x004A5950,0);
        }
        public override int GetMissCount() => mt.ReadInteger(0x004A594C);
        public override int GetBombCount() => mt.ReadInteger(0x004A5950);
        public override int GetBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004A6DAC)+0x40);
        public override int GetBossLife() => mt.ReadInteger(mt.ReadInteger(0x004A6DCC)+0x1E4);
        public override void KillSelf() => write(mt.ReadInteger(0x004A6EF8)+0x165A8,4);
        public override bool[] GetEnable() => new bool[24] { true,false,true,true,true,true,true,
                                                             true,false,true,true,true,true,true,
                                                             true,true,true,
                                                             true,true,true,true,true,true,true};
        public override void SetLockPlayer(bool b) => write(0x00443CC5,HexCodeHelper.getValueArray(new byte[] { 0xA3,0xF4,0x57,0x4A,0x00 },b));//mov [004A57F4],eax
        public override void SetLockBomb(bool b) => write(0x0040DA86,HexCodeHelper.getValueArray(new byte[] { 0xA3,0x00,0x58,0x4A,0x00 },b));//mov [004A5800],eax
        public override void SetUnbeatable(bool b) => write(0x00443FDB,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x87,0xA8,0x65,0x01,0x00,0x04,0x00,0x00,0x00 },b));// mov[edi+165A8],4
        public override void SetFPS(int i) {
            mt.WriteBytes(0x0045AC45,BitConverter.GetBytes((double)1/i));
            mt.WriteBytes(0x0045ACBD,new byte[] { 0xF2,0x0F,0x10,0x15,0x45,0xAC,0x45,0x00 });
        }
        public override void SetPlayer(int i) => write(0x004A57F4,i);
        public override void SetPlayerFragment(int i) { }
        public override void SetBomb(int i) => write(0x004A5800,i);
        public override void SetBombFragment(int i) => write(0x004A5804,i);
        public override void SetPower(int i) => write(0x004A57E4,i);
        public override void SetScore(int i) => write(0x004A57B0,i);
        public override void SetMaxPoint(int i) => write(0x004A57D8,i*100);
        public override void SetSpecial1(int i) => write(0x004A5808,i);
        public override void SetSpecial2(int i) { }
        public override void SetSpecial3(int i) { }
        public override void SetSpecial4(int i) { }
        public override int GetSpecial1() => mt.ReadInteger(0x004A5808);
        public override int GetSpecial2() { return 0; }
        public override int GetSpecial3() { return 0; }
        public override int GetSpecial4() { return 0; }
        public override void SetIPlayer(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            byte[] by = new byte[] { 0xC7,0x05,0xF4,0x57,0x4A,0x00,b }; // mov [004A57F4],b
                                                                        //story
            write(0x0042CDEE,by);
            //practice
            write(0x0042CE03,by);
            //spell practice no need
        }
        public override void SetIPlayerFragment(int i) { }
        public override void SetIBomb(int i) => write(0x0042E5AE,new byte[] { 0xC7,0x46,0x70,BitConverter.GetBytes(i)[0] });                    //mov [esi+70],b
        public override void SetIBombFragment(int i) => write(0x0042E5CC,new byte[] { 0xC7,0x46,0x74,BitConverter.GetBytes(i)[0] });                    //mov [esi+74],00000003
        public override void SetIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042E5A0,new byte[] { 0xC7,0x46,0x54,b[0],b[1],b[2],b[3] });  //mov [esi+54],b[]
                                                                                  //Stop to set default values
            write(0x0042CE91,HexCodeHelper.getNop(6));            //story
            write(0x0042CEEC,HexCodeHelper.getNop(5));            //practice
            write(0x0042CEBC,HexCodeHelper.getNop(5));            //extra
            write(0x0042CE51,HexCodeHelper.getNop(5));            //spell practice
        }
        public override void SetIScore(int i) {
            byte[] b = BitConverter.GetBytes(i);
            int gettedPlayer = 0;
            if(i<500000) { gettedPlayer=0; } else
            if(i<1000000) { gettedPlayer=1; } else
            if(i<2000000) { gettedPlayer=2; } else
            if(i<4000000) { gettedPlayer=3; } else
            if(i<7000000) { gettedPlayer=4; } else
            if(i<10000000) { gettedPlayer=5; } else
            if(i<15000000) { gettedPlayer=6; } else
            if(i<25000000) { gettedPlayer=7; } else
            if(i<50000000) { gettedPlayer=8; } else
            if(i<100000000) { gettedPlayer=9; } else { gettedPlayer=10; }
            write(0x0042CD38,new byte[] { 0xC7,0x05,0xB0,0x57,0x4A,0x00,b[0],b[1],b[2],b[3],//mov [004A57B0],b[]
                                          0xB8,0x00,0x00,0x00,0x00,  //mov eax,0
                                          0xA3,0xC0,0x57,0x4A,0x00 });  //mov [004A57C0],ecx
            write(0x0042CD4C,HexCodeHelper.getNop(5));
            write(0x0042E5DD,gettedPlayer);
        }
        public override void SetIMaxPoint(int i) {
            write(0x0042CD66,HexCodeHelper.stringToAsm("b9 "+HexCodeHelper.toHex(i*100)+" 90 90 90"));//mov ecx,i
        }
        public override void SetISpecial1(int i) {
            byte[] by = HexCodeHelper.stringToAsm("C7 05 08 58 4A 00 "+HexCodeHelper.toHex(i));  //mov[004A5808],by[]
            //story
            write(0x0042CEC6,by);
            //practice          
            write(0x0042CEF8,by);
            write(0x0042CF02,HexCodeHelper.getNop(1));
            //spell practice
            write(0x0042CE5B,by);
        }
        public override void SetISpecial2(int i) { }
        public override void SetISpecial3(int i) { }
        public override void SetISpecial4(int i) { }
        private void write(int addr,int value) => mt.WriteInteger(addr,value);
        private void write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
