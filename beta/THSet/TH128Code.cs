using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH128Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        public override void checkNeedBomb() {
            thisStatu=mt.ReadInteger(mt.ReadInteger(0x004B8A80)+0xF78);
            if(lastStatu!=4&&thisStatu==4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),0,0);
                write(0x004B51B4,5);
            } else if(lastStatu==4&&thisStatu!=4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),2,0);
            }
            lastStatu=thisStatu;
        }
        public TH128Code(MemoryTool m) => mt=m;
        public override void setStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override string getTitle() => new Random().Next()%2==0 ? "1+1=9" : "妖精大战争";
        public override string[] getSpecialTip() => new string[] { "蓄力","","" };
        public override string getAboutBug() => "终符若同时击破了两只妖精，则卡关……无解\n“满身疮痍”界面直接重新开始会导致录像爆炸，应返回主界面重新开始，若没有疮痍，则可以放心使用ESC+R\n难度\\路线选择界面如果按键频率过高可能会出现选择不正确的情况";
        public override string getAboutSpecial() => "";
        public override string[] getDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() {
            //miss
            write(0x0043D0CF,new byte[] { 0xEB,0xE0 });                                       //jmp 0043D0B1
            write(0x0043D0B1,new byte[] { 0xC7,0x80,0x78,0x0F,0x00,0x00,0x04,0x00,0x00,0x00,  //mov [eax+00000F78],00000004
                                          0xEB,0x14 });                                       //jmp 0043D0D1
            write(0x0043D0D1,new byte[] { 0xFF,0x05,0xAC,0x51,0x4B,0x00,0x90,0x90 });         //inc [004B51AC]
            write(0x004B51AC,0);
            //bomb
            write(0x0043B7DB,new byte[] { 0xE9,0x32,0xFE,0xFF,0xFF });      //jmp 0043B612
            write(0x0043B612,new byte[] { 0xE8,0xE9,0xBC,0xFE,0xFF,         //call 00427300
                                          0xFF,0x05,0xB0,0x51,0x4B,0x00,    //inc [004B51B0]
                                          0xEB,0x17 });                     //jmp 0043B636
            write(0x0043B636,new byte[] { 0xE9,0xA5,0x01,0x00,0x00 });      //jmp 0043B7E0
            write(0x004B51B0,0);
        }
        public override int getMissCount() => mt.ReadInteger(0x004B51AC);
        public override int getBombCount() => mt.ReadInteger(0x004B51B0);
        public override int getBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004B8930)+0x5C);
        public override int getBossLife() => mt.ReadInteger(mt.ReadInteger(0x004B8950)+0x5910);
        public override void killSelf() => write(mt.ReadInteger(0x004B8A80)+0xF78,4);
        public override bool[] getEnable() => new bool[30] { true,false,true,false,true,true,false,true,false,false,
                                                             true,false,true,false,true,false,false,true,false,false,
                                                             true,true,true,true,true,true,true,true,false,true };
        public override void setLockPlayer(bool b) => write(0x0042729C,HexCodeHelper.getValueArray(new byte[] { 0x89,0x0D,0x64,0x4D,0x4B,0x00 },b));//mov [004B4D64],ecx
        public override void setLockBomb(bool b) => write(0x0043B7C1,HexCodeHelper.getValueArray(new byte[] { 0x7C,0x30 },b)); //jl 0043B7F3
        public override void setUnbeatable(bool b) => write(0x0043D0CF,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x80,0x78,0x0F,0x00,0x00,0x04,0x00,0x00,0x00 },b));//mov [eax+00000F78],00000004
        public override void setFPS(int i) {
            write(0x00455158,BitConverter.GetBytes((double)1/i));
            write(0x00454C48,new byte[] { 0xDD,0x05,0x58,0x51,0x45,0x00 });//fld qword ptr [00455158]
        }
        public override void setPlayer(int i) => write(0x004B4D64,i*100);
        public override void setPlayerFragment(int i) { }
        public override void setBomb(int i) => write(0x004B4D70,i*100);
        public override void setBombFragment(int i) { }
        public override void setPower(int i) => write(0x004B4D60,BitConverter.GetBytes((float)i));
        public override void setScore(int i) { }
        public override void setMaxPoint(int i) { }
        public override void setSpecial1(int i) => write(0x004B4D6C,i*100);
        public override void setSpecial2(int i) { }
        public override void setSpecial3(int i) { }
        public override int getSpecial1() => mt.ReadInteger(0x004B4D6C)/100;
        public override int getSpecial2() { return 0; }
        public override int getSpecial3() { return 0; }
        public override void setIPlayer(int i) => write(0x00425FFF,i*100);
        public override void setIPlayerFragment(int i) { }
        public override void setIBomb(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x00426009,new byte[] { 0xE9,0x24,0xFE,0xFF,0xFF,0x90 });                 //jmp 00425E32
            write(0x00425E32,new byte[] { 0xC7,0x05,0x70,0x4D,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004B4D70],b[]
                                          0xEB,0x89 });                                     //jmp 00425DC7
            write(0x00425DC7,new byte[] { 0xE9,0x43,0x02,0x00,0x00 });                      //jmp 0042600F
        }
        public override void setIBombFragment(int i) { }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes((float)i);
            write(0x00425FEE,new byte[] { 0xE9,0x0E,0x09,0x00,0x00,0x90 });                     //jmp 00426901
            write(0x00426901,new byte[] { 0xC7,0x05,0x60,0x4D,0x4B,0x00,b[0],b[1],b[2],b[3] }); //jmp 0042600F
        }
        public override void setIScore(int i) { }
        public override void setIMaxPoint(int i) { }
        public override void setISpecial1(int i) => write(0x00425F08,i*100);
        public override void setISpecial2(int i) { }
        public override void setISpecial3(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
