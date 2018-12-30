using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH16Code:THCode {
        MemoryTool mt;
        private int bossNumAddress = 0;
        private int logoEnemyAddress = 0;
        public TH16Code(MemoryTool m) => mt=m;
        public override void setStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) {
            bossNumAddress=0;
            logoEnemyAddress=0;
            bossBox.Items.Clear();
            chapterBox.Items.Clear();
            chapterBox.Items.AddRange(g4EclCode.chapter);
            switch(stageBox.Text) {
                case "Stage1": bossBox.Items.AddRange(g4EclCode.TH16.stage1BossList); break;
                case "Stage2": bossBox.Items.AddRange(g4EclCode.TH16.stage2BossList); chapterBox.Items.Clear(); chapterBox.Items.AddRange(new object[] { "前半","道中Boss","关底Boss" }); break;
                case "Stage3": bossBox.Items.AddRange(g4EclCode.TH16.stage3BossList); break;
                case "Stage4": bossBox.Items.AddRange(g4EclCode.TH16.stage4BossList); chapterBox.Items.Clear(); chapterBox.Items.AddRange(new object[] { "前半","道中Boss","后半","太田飞行阵","关底Boss" }); break;
                case "Stage5": bossBox.Items.AddRange(g4EclCode.TH16.stage5BossList); break;
                case "Stage6": bossBox.Items.AddRange(g4EclCode.TH16.stage6BossList); chapterBox.Items.Clear(); chapterBox.Items.AddRange(new object[] { "关底Boss" }); break;
                case "Extra": bossBox.Items.AddRange(g4EclCode.TH16.stage7BossList); break;
            }
        }
        public override void setChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) {
            byte[] memory = new byte[0x1000];
            byte[] eclLogoEnemy = g4EclCode.eclLogoEnemy;
            byte[] eclMainFront = g4EclCode.stageEcl[0];
            byte[] eclMBoss = stageBox.Text.Equals("Extra") ? g4EclCode.TH16.eclExtraMBoss : g4EclCode.stageEcl[1];
            byte[] eclMainLatter = stageBox.Text.Equals("Stage2") ? new byte[] { } : g4EclCode.stageEcl[2];
            byte[] eclMainBoss = stageBox.Text.Equals("Stage5") ? g4EclCode.TH16.eclStage5CreateMainBoss : g4EclCode.stageEcl[3];
            int index = 0;
            if(logoEnemyAddress!=0) {
                byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
                switch(chapterBox.Text) {
                    case "前半": break;
                    case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
                    case "后半": eclByte=new byte[][] { eclMainLatter,eclMainBoss }; break;
                    case "太田飞行阵": eclByte=new byte[][] { g4EclCode.TH16.eclTaiTianFeiXingZhen,eclMainBoss }; break;
                    case "关底Boss": eclByte=new byte[][] { eclMainBoss }; break;
                }
                mt.WriteBytes(logoEnemyAddress,g4EclCode.createEcl(eclByte));
            } else {
                for(int i = 0x00500000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=g4EclCode.getIndexOf(memory,eclLogoEnemy))!=-1) {
                        //mt.WriteBytes(i+index,eclAfter);
                        byte[][] eclByte = new byte[][] { eclMainFront,eclMBoss,eclMainLatter,eclMainBoss };
                        switch(chapterBox.Text) {
                            case "前半": break;
                            case "道中Boss": eclByte=new byte[][] { eclMBoss,eclMainLatter,eclMainBoss }; break;
                            case "后半": eclByte=new byte[][] { eclMainLatter,eclMainBoss }; break;
                            case "太田飞行阵": eclByte=new byte[][] { g4EclCode.TH16.eclTaiTianFeiXingZhen,eclMainBoss }; break;
                            case "关底Boss": eclByte=new byte[][] { eclMainBoss }; break;
                        }
                        mt.WriteBytes(i+index,g4EclCode.createEcl(eclByte));
                        logoEnemyAddress=i+index;
                        break;
                    }
                }
            }
        }
        public override void setMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) {

        }
        public override void setBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) {
            byte[] memory = new byte[0x1000];
            byte[] bossEcl = g4EclCode.eclMainBossNum;
            int index = 0;
            byte[] b = g4EclCode.getBossNumArray(bossBox.Text);
            if(bossNumAddress!=0) {
                mt.WriteBytes(bossNumAddress,b);
            } else {
                for(int i = 0x00500000;i<0x30000000;i+=0x1000) {
                    memory=mt.ReadBytes(i,0x1000);
                    if((index=g4EclCode.getIndexOf(memory,bossEcl))!=-1) {
                        mt.WriteBytes(i+index+20,b);
                        bossNumAddress=i+index+20;
                        break;
                    }
                }
            }
        }

        public override string getTitle() => new Random().Next()%2==0 ? "东方Bug璋" : "东方CBC";
        public override string getAboutBug() => "太多了，我就不写了……";
        public override string getAboutSpecial() => "季节槽范围为0-1140";
        public override string[] getSpecialTip() => new string[] { "季节槽","","" };
        public override string[] getDefaultValue() => new string[] { "0","0","0" };
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
        public override int getMissCount() => mt.ReadInteger(0x004A594C);
        public override int getBombCount() => mt.ReadInteger(0x004A5950);
        public override int getBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004A6DAC)+0x40);
        public override int getBossLife() => mt.ReadInteger(mt.ReadInteger(0x004A6DCC)+0x1E4);
        public override void killSelf() => write(mt.ReadInteger(0x004A6EF8)+0x165A8,4);
        public override bool[] getEnable() => new bool[29] { true,false,true,true,true,true,true,true,false,false,
                                                             true,false,true,true,true,true,true,true,false,false,
                                                             true,true,true,
                                                             true,true,true,true,true,true };
        public override void setLockPlayer(bool b) => write(0x00443CC5,g4EclCode.getValueArray(new byte[] { 0xA3,0xF4,0x57,0x4A,0x00 },b));//mov [004A57F4],eax
        public override void setLockBomb(bool b) => write(0x0040DA86,g4EclCode.getValueArray(new byte[] { 0xA3,0x00,0x58,0x4A,0x00 },b));//mov [004A5800],eax
        public override void setUnbeatable(bool b) => write(0x00443FDB,g4EclCode.getValueArray(new byte[] { 0xC7,0x87,0xA8,0x65,0x01,0x00,0x04,0x00,0x00,0x00 },b));// mov[edi+165A8],4
        public override void setFPS(int i) {
            mt.WriteBytes(0x0045AC45,BitConverter.GetBytes((double)1/i));
            mt.WriteBytes(0x0045ACBD,new byte[] { 0xF2,0x0F,0x10,0x15,0x45,0xAC,0x45,0x00 });
        }
        public override void setPlayer(int i) => write(0x004A57F4,i);
        public override void setPlayerFragment(int i) { }
        public override void setBomb(int i) => write(0x004A5800,i);
        public override void setBombFragment(int i) => write(0x004A5804,i);
        public override void setPower(int i) => write(0x004A57E4,i);
        public override void setScore(int i) => write(0x004A57B0,i/10);
        public override void setMaxPoint(int i) => write(0x004A57D8,i*100);
        public override void setSpecial1(int i) => write(0x004A5808,i);
        public override void setSpecial2(int i) { }
        public override void setSpecial3(int i) { }
        public override int getSpecial1() => mt.ReadInteger(0x004A5808);
        public override int getSpecial2() { return 0; }
        public override int getSpecial3() { return 0; }
        public override void setIPlayer(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            byte[] by = new byte[] { 0xC7,0x05,0xF4,0x57,0x4A,0x00,b }; // mov [004A57F4],b
                                                                        //story
            write(0x0042CDEE,by);
            //practice
            write(0x0042CE03,by);
            //spell practice no need
        }
        public override void setIPlayerFragment(int i) { }
        public override void setIBomb(int i) => write(0x0042E5AE,new byte[] { 0xC7,0x46,0x70,BitConverter.GetBytes(i)[0] });                    //mov [esi+70],b
        public override void setIBombFragment(int i) => write(0x0042E5CC,new byte[] { 0xC7,0x46,0x74,BitConverter.GetBytes(i)[0] });                    //mov [esi+74],00000003
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042E5A0,new byte[] { 0xC7,0x46,0x54,b[0],b[1],b[2],b[3] });  //mov [esi+54],b[]
                                                                                  //Stop to set default values
            write(0x0042CE91,g4EclCode.getNop(6));            //story
            write(0x0042CEEC,g4EclCode.getNop(5));            //practice
            write(0x0042CEBC,g4EclCode.getNop(5));            //extra
            write(0x0042CE51,g4EclCode.getNop(5));            //spell practice
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            int gettedPlayer = 0;
            if(i<5000000) { gettedPlayer=0; } else
            if(i>=5000000&&i<10000000) { gettedPlayer=1; } else
            if(i>=10000000&&i<20000000) { gettedPlayer=2; } else
            if(i>=20000000&&i<40000000) { gettedPlayer=3; } else
            if(i>=40000000&&i<70000000) { gettedPlayer=4; } else
            if(i>=70000000&&i<100000000) { gettedPlayer=5; } else
            if(i>=100000000&&i<150000000) { gettedPlayer=6; } else
            if(i>=150000000&&i<250000000) { gettedPlayer=7; } else
            if(i>=250000000&&i<500000000) { gettedPlayer=8; } else
            if(i>=500000000&&i<1000000000) { gettedPlayer=9; } else { gettedPlayer=10; }
            write(0x0042CD38,new byte[] { 0xC7,0x05,0xB0,0x57,0x4A,0x00,b[0],b[1],b[2],b[3],//mov [004A57B0],b[]
                                          0xB8,0x00,0x00,0x00,0x00,
                                          0xA3,0xC0,0x57,0x4A,0x00 });  //mov [004A57C0],ecx
            write(0x0042CD4C,g4EclCode.getNop(5));
            write(0x0042E5DD,gettedPlayer);
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x0042CD66,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90,0x90 });       //mov ecx,b[]
        }
        public override void setISpecial1(int i) {
            byte[] b = BitConverter.GetBytes(i);
            byte[] by = new byte[] { 0xC7,0x05,0x08,0x58,0x4A,0x00,b[0],b[1],b[2],b[3] };
            //story
            write(0x0042CEC6,by);     //mov[004A5808],b[]
                                      //practice          
            write(0x0042CEF8,by);
            write(0x0042CF02,g4EclCode.getNop(1));
            //spell practice
            write(0x0042CE5B,by);
        }
        public override void setISpecial2(int i) { }
        public override void setISpecial3(int i) { }
        private void write(int addr,int value) => mt.WriteInteger(addr,value);
        private void write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
