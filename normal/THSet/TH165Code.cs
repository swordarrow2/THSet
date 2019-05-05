using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH165Code:THCode {
        MemoryTool mt;
        public TH165Code(MemoryTool m) => mt=m;
        public override void CheckNeedBomb() { }
        public override void SetStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override string GetTitle() => new Random().Next()%2==0 ? "bug日记" : "TH14.5";
        public override string[] GetSpecialTip() => new string[] { "拍照能量","","" };
        public override string GetAboutBug() => "ESC+R并不会让游戏重新开始，而且还会多一层菜单遮挡视线\n撞弹后进入游戏说明再回到游戏可以复活";
        public override string GetAboutSpecial() => "拍照能量为0-100";
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() { }

        public override int GetMissCount() { return 0; }
        public override int GetBombCount() { return 0; }
        public override int GetBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004B550C)+0x40);
        public override int GetBossLife() { return 0; }
        public override void KillSelf() => write(mt.ReadInteger(0x004B5654)+0x165A4,4);
        public override bool[] GetEnable() => new bool[30] { false,false,false,false,false,false,false,true,false,false,
                                                             false,false,false,false,false,false,false,false,false,false,
                                                             false,true,true,true,false,false,true,true,false,false };
        public override void SetLockPlayer(bool b) { }
        public override void SetLockBomb(bool b) {
            write(0x0044A1D7,HexCodeHelper.getValueArray(new byte[] { 0xF3,0x0F,0x11,0x47,0x7C },b));                    //movss [edi+7C],xmm0
            write(0x0044A1DE,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x47,0x7C,0x00,0x00,0x00,0x00 },b));//mov [edi+7C],00000000
            write(0x00447F88,HexCodeHelper.getValueArray(new byte[] { 0xF3,0x0F,0x11,0x47,0x7C },b));                    //movss [edi+7C],xmm0
        }

        public override void SetUnbeatable(bool b) => write(0x00446A7A,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x87,0xA4,0x65,0x01,0x00,0x04,0x00,0x00,0x00 },b));//mov [edi+000165A4],00000004
        public override void SetFPS(int i) {
            write(0x00460F46,BitConverter.GetBytes((double)1/i));
            write(0x00460FD3,new byte[] { 0xF2,0x0F,0x10,0x0D,0x46,0x0F,0x46,0x00 });//movsd xmm1,[00460F46]
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
        public override int GetSpecial1() => (int)(mt.ReadFloat(mt.ReadInteger(0x004B5654)+0x16838)*100);
        public override int GetSpecial2() { return 0; }
        public override int GetSpecial3() { return 0; }
        public override void SetIPlayer(int i) { }
        public override void SetIPlayerFragment(int i) { }
        public override void SetIBomb(int i) { }
        public override void SetIBombFragment(int i) { }
        public override void SetIPower(int i) { }
        public override void SetIScore(int i) { }
        public override void SetIMaxPoint(int i) { }
        public override void SetISpecial1(int i) { }
        public override void SetISpecial2(int i) { }
        public override void SetISpecial3(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
