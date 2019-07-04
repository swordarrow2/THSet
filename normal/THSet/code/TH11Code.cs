using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH11Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        public override void CheckNeedBomb() {
            thisStatu=mt.ReadInteger(mt.ReadInteger(0x004A8EB4)+0x928);
            if(lastStatu!=4&&thisStatu==4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),0,0);
                write(0x004A5E88,5);
                write(0x004A573C,5);
            } else if(lastStatu==4&&thisStatu!=4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),2,0);
            }
            lastStatu=thisStatu;
        }
        public TH11Code(MemoryTool m) => mt=m;
        public override void SetStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override string GetTitle() => new Random().Next()%2==0 ? "多睡觉，少操心" : "东方弟灵殿";
        public override string GetAboutBug() => "魔A使用ctrl跳过对话会导致存录像时游戏爆炸(金发孩子真可怜.jpg)，使用z即可\n\nreplay从5面结束到6面第一波乌鸦飞走前若使用了快进，则大鸟战录像爆炸\n\n梦A下避easy难度「波与粒的境界」可能导致录像爆炸";
        public override string GetAboutSpecial() => "对于魔理沙A火力初始值修改请开始游戏(修改器确认机体)后再修改，然后使用ESC+R重新开始游戏";
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override string[] GetSpecialTip() => new string[] { "信仰","倍率","" };
        public override void StartCount() {
            //miss
            write(0x004327ED,new byte[] { 0x57,                            //push edi
                                          0xE9,0x1F,0xF5,0xFF,0xFF,        //jmp 00431D12
                                          0xA3,0xF0,0x56,0x4A,0x00,        //mov [004A56F0],eax
                                          0x39,0xC8,0x90 });               //cmp eax,ecx
            write(0x00431D12,new byte[] { 0x89,0x15,0x18,0x57,0x4A,0x00,   //mov [004A5718],edx
                                          0xEB,0x6B });                    //jmp 00431D85
            write(0x00431D85,new byte[] { 0xFF,0x05,0x80,0x5E,0x4A,0x00,   //inc [004A5E80]
                                          0xE9,0x63,0x0A,0x00,0x00 });     //jmp 004327F3
            write(0x004A5E80,0);
            //主动
            write(0x004311F1,new byte[] { 0xE9,0x52,0xF0,0xFF,0xFF,0x90 });//jmp 00430248
            write(0x00430248,new byte[] { 0x29,0x15,0xE8,0x56,0x4A,0x00,   //sub [004A56E8],edx
                                          0xEB,0x12 });                    //jmp 00430262
            write(0x00430262,new byte[] { 0xFF,0x05,0x84,0x5E,0x4A,0x00,   //inc [004A5E84]
                                          0xE9,0x8A,0x0F,0x00,0x00 });     //jmp 004311F7
            //决死
            write(0x0043129D,new byte[] { 0xE9,0xA0,0x09,0x00,0x00,0x90 });//jmp 00431C42
            write(0x00431C42,new byte[] { 0x29,0x05,0xE8,0x56,0x4A,0x00,   //sub [004A56E8],eax
                                          0xFF,0x05,0x84,0x5E,0x4A,0x00,   //inc [004A5E84]
                                          0xEB,0x07 });                    //jmp 00431C57
            write(0x00431C57,new byte[] { 0xE9,0x47,0xF6,0xFF,0xFF });     //jmp 004312A3
            write(0x004A5E84,0);
        }
        public override int GetMissCount() => mt.ReadInteger(0x004A5E80);
        public override int GetBombCount() => mt.ReadInteger(0x004A5E84);
        public override int GetBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004A8D68)+0x5C);
        public override int GetBossLife() => mt.ReadInteger(mt.ReadInteger(0x004A8D84)+0x43F8);
        public override void KillSelf() => write(mt.ReadInteger(0x004A8EB4)+0x928,4);
        public override bool[] GetEnable() => new bool[30] { true,true,false,false,true,false,false,true,true,false,
                                                             true,true,false,false,true,false,false,false,false,false,
                                                             true,true,true,
                                                             true,true,true,true,true,false,true };
        public override void SetLockPlayer(bool b) => write(0x00431D12,HexCodeHelper.getValueArray(new byte[] { 0x89,0x15,0x18,0x57,0x4A,0x00 },b));//mov [004A5718],edx
        public override void SetLockBomb(bool b) {
            byte[] by = new byte[] { 0x29,0x15,0xE8,0x56,0x4A,0x00 };
            write(0x00430248,HexCodeHelper.getValueArray(by,b));//sub [004A56E8],edx
            write(0x00431C42,HexCodeHelper.getValueArray(by,b));//sub [004A56E8],eax
        }
        public override void SetUnbeatable(bool b) => write(0x00432A9E,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x87,0x28,0x09,0x00,0x00,0x04,0x00,0x00,0x00 },b));//mov [edi+00000928],00000004
        public override void SetFPS(int i) {
            if(write(0x71CD8ABC,i)==0) {
                write(0x004461E6,BitConverter.GetBytes((double)1/i));
                write(0x0044647C,new byte[] { 0xDD,0x05,0xE6,0x61,0x44,0x00 });//fld qword ptr [004461E6]
            }
        }
        public override void SetPlayer(int i) => write(0x004A5718,i);
        public override void SetPlayerFragment(int i) => write(0x004A571C,i);
        public override void SetBomb(int i){ }
        public override void SetBombFragment(int i){ }
        public override void SetPower(int i) => write(0x004A56E8,isMarisaA() ? (int)(i/8.333333333333f) : i/5);
        public override void SetScore(int i) => write(0x004A56E4,i);
        public override void SetMaxPoint(int i){ }
        public override void SetSpecial1(int i) => write(0x004A56F0,i*100);
        public override void SetSpecial2(int i) => write(0x004A56F4,i*100);
        public override void SetSpecial3(int i){ }
        public override int GetSpecial1() => mt.ReadInteger(0x004A56F0)/100;
        public override int GetSpecial2() => mt.ReadInteger(0x004A56F4)/100;
        public override int GetSpecial3(){ return 0; }
        public override void SetIPlayer(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0041FA38,new byte[] { 0xE9,0x84,0xFE,0xFF,0xFF,0x90 });                 //jmp 0041F8C1
            write(0x0041F8C1,new byte[] { 0xC7,0x05,0x18,0x57,0x4A,0x00,b[0],b[1],b[2],b[3],//mov [004A5718],b[]
                                          0xE9,0x6E,0x01,0x00,0x00 });                      //jmp 0041FA3E
            write(0x0041FA4F,i);
        }
        public override void SetIPlayerFragment(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0041FA30,new byte[] { 0xE9,0x1F,0xFE,0xFF,0xFF,0x90 });                 //jmp 0041F854
            write(0x0041F854,new byte[] { 0xC7,0x05,0x1C,0x57,0x4A,0x00,b[0],b[1],b[2],b[3],//mov [004A571C],b[]
                                          0xEB,0x17 });                                     //jmp 0041F877
            write(0x0041F877,new byte[] { 0xE9,0xBA,0x01,0x00,0x00 });                      //jmp 0041FA36
            write(0x0041F85A,i);

        }
        public override void SetIBomb(int i){ }
        public override void SetIBombFragment(int i){ }
        public override void SetIPower(int i) {
            byte[] b = BitConverter.GetBytes(isMarisaA() ? (int)(i/8.3333333333f) : i/5);
            write(0x0041FA8C,new byte[] { 0xE9,0x12,0xFD,0xFF,0xFF,0x90 });                 //jmp 0041F7A3
            write(0x0041F7A3,new byte[] { 0xC7,0x05,0xE8,0x56,0x4A,0x00,b[0],b[1],b[2],b[3],//mov [004A56E8],b[]
                                          0xEB,0x18 });                                     //jmp 0041F7C7
            write(0x0041F7C7,new byte[] { 0xE9,0xC6,0x02,0x00,0x00 });                      //jmp 0041FA92
            write(0x0041FA7D,new byte[] { 0xE9,0xE0,0xFC,0xFF,0xFF,0x90 });                 //jmp 0041F762
            write(0x0041F762,new byte[] { 0xC7,0x05,0xE8,0x56,0x4A,0x00,b[0],b[1],b[2],b[3],//mov [004A56E8],b[]
                                          0xEB,0xDA });                                     //jmp 0041F748
            write(0x0041F748,new byte[] { 0xE9,0x36,0x03,0x00,0x00 });                      //jmp 0041FA83

        }
        public override void SetIScore(int i){ }
        public override void SetIMaxPoint(int i){ }
        public override void SetISpecial1(int i){ }
        public override void SetISpecial2(int i){ }
        public override void SetISpecial3(int i){ }
        private bool isMarisaA() => ((mt.ReadInteger(0x004A5710)==1)&&(mt.ReadInteger(0x004A5714)==0));
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
