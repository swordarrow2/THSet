using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH165Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        public TH165Code(MemoryTool m) => mt=m;
        public override void checkNeedBomb() { }
        public override void setStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override string getTitle() => new Random().Next()%2==0 ? "bug日记" : "TH14.5";
        public override string[] getSpecialTip() => new string[] { "拍照能量","","" };
        public override string getAboutBug() => "ESC+R并不会让游戏重新开始，而且还会多一层菜单遮挡视线\n撞弹后进入游戏说明再回到游戏可以复活";
        public override string getAboutSpecial() => "拍照能量为0-100";
        public override string[] getDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() { }

        public override int getMissCount() { return 0; }
        public override int getBombCount() { return 0; }
        public override int getBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004B550C)+0x40);
        public override int getBossLife() { return 0; }
        public override void killSelf() => write(mt.ReadInteger(0x004B5654)+0x165A4,4);
        public override bool[] getEnable() => new bool[30] { false,false,false,false,false,false,false,true,false,false,
                                                             false,false,false,false,false,false,false,false,false,false,
                                                             false,true,true,true,false,false,true,true,false,false };
        public override void setLockPlayer(bool b) { }
        public override void setLockBomb(bool b) {
            write(0x0044A1D7,g4EclCode.getValueArray(new byte[] { 0xF3,0x0F,0x11,0x47,0x7C },b));                    //movss [edi+7C],xmm0
            write(0x0044A1DE,g4EclCode.getValueArray(new byte[] { 0xC7,0x47,0x7C,0x00,0x00,0x00,0x00 },b));//mov [edi+7C],00000000
            write(0x00447F88,g4EclCode.getValueArray(new byte[] { 0xF3,0x0F,0x11,0x47,0x7C },b));                    //movss [edi+7C],xmm0
        }

        public override void setUnbeatable(bool b) => write(0x00446A7A,g4EclCode.getValueArray(new byte[] { 0xC7,0x87,0xA4,0x65,0x01,0x00,0x04,0x00,0x00,0x00 },b));//mov [edi+000165A4],00000004
        public override void setFPS(int i) {
            write(0x00460F46,BitConverter.GetBytes((double)1/i));
            write(0x00460FD3,new byte[] { 0xF2,0x0F,0x10,0x0D,0x46,0x0F,0x46,0x00 });//movsd xmm1,[00460F46]
        }
        public override void setPlayer(int i) { }
        public override void setPlayerFragment(int i) { }
        public override void setBomb(int i) { }
        public override void setBombFragment(int i) { }
        public override void setPower(int i) { }
        public override void setScore(int i) { }
        public override void setMaxPoint(int i) { }
        public override void setSpecial1(int i) => write(mt.ReadInteger(0x004B5654)+0x16838,BitConverter.GetBytes(i/100f));
        public override void setSpecial2(int i) { }
        public override void setSpecial3(int i) { }
        public override int getSpecial1() => (int)(mt.ReadFloat(mt.ReadInteger(0x004B5654)+0x16838)*100);
        public override int getSpecial2() { return 0; }
        public override int getSpecial3() { return 0; }
        public override void setIPlayer(int i) { }
        public override void setIPlayerFragment(int i) { }
        public override void setIBomb(int i) { }
        public override void setIBombFragment(int i) { }
        public override void setIPower(int i) { }
        public override void setIScore(int i) { }
        public override void setIMaxPoint(int i) { }
        public override void setISpecial1(int i) { }
        public override void setISpecial2(int i) { }
        public override void setISpecial3(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
