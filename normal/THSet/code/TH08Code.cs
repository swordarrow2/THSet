using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH08Code:THCode {
        MemoryTool mt;
        public override void CheckNeedBomb() {
            throw new NotImplementedException();
        }
        public TH08Code(MemoryTool m) => mt=m;
        public override void SetStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void SetBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override string GetTitle() => new Random().Next()%2==0 ? "东方永夜抄" : "TH08";
        public override string[] GetSpecialTip() => new string[] { "","","" };
        public override string GetAboutBug() => "不知道（";
        public override string GetAboutSpecial() => "没摸到，告辞（";
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() { }

        public override int GetMissCount() => mt.ReadInteger(0x0164CFA4);
        public override int GetBombCount() => mt.ReadInteger(0x0164CFA8);
        public override int GetBulletCount() => mt.ReadInteger(0x0160F3C8);
        public override int GetBossLife() { return 0; }
        public override void KillSelf() { }
        public override bool[] GetEnable() => new bool[24] {
                                                             true,true,true,false,true,false,false,
                                                             false,true,false,false,false,false,false,
                                                             true,true,false,true,true,false,true,false,false,false };
        public override void SetLockPlayer(bool b) => write(0x0043C676,HexCodeHelper.getValueArray(new byte[] { 0xD9,0x58,0x74 },b));//fstp dword ptr [eax+74]
        public override void SetLockBomb(bool b) => write(0x004398BB,HexCodeHelper.getValueArray(new byte[] { 0xD9,0x98,0x80,0x00,0x00,0x00 },b)); //fstp dword ptr [eax+00000080]

        public override void SetUnbeatable(bool b) { }
        public override void SetFPS(int i) => write(0x00460F46,write(0x60015A4C,i));
        public override void SetPlayer(int i) { }
        public override void SetPlayerFragment(int i) { }
        public override void SetBomb(int i) { }
        public override void SetBombFragment(int i) { }
        public override void SetPower(int i) { }
        public override void SetScore(int i) { }
        public override void SetMaxPoint(int i) { }
        public override void SetSpecial1(int i) { }
        public override void SetSpecial2(int i) { }
        public override void SetSpecial3(int i) { }
        public override int GetSpecial1() { return 0; }
        public override int GetSpecial2() { return 0; }
        public override int GetSpecial3() { return 0; }
        public override void SetIPlayer(int i) {
            byte[] b = BitConverter.GetBytes((float)i);
            write(0x0043AE42,new byte[] { 0xE9,0x8B,0x78,0xFF,0xFF,0x90,0x90,0x90 });//jmp 004326D2
            write(0x004326D2,new byte[] { 0xC7,0x40,0x74,b[0],b[1],b[2],b[3],        //mov [eax+74],b[]
                                          0xE9,0x06,0x03,0x00,0x00 });               //jmp 004329E4
            write(0x004329E4,new byte[] { 0xB9,0x08,0xF5,0x60,0x01,                  //mov ecx,0160F508
                                          0xE9,0x5C,0x84,0x00,0x00                   //jmp 0043AE4A
            });
        }
        public override void SetIPlayerFragment(int i) {
            byte[] b = BitConverter.GetBytes(i);
            int gettedPlayer = 0;
            if(i<100) { gettedPlayer=0; } else
            if(i>=100&&i<250) { gettedPlayer=1; } else
            if(i>=250&&i<500) { gettedPlayer=2; } else
            if(i>=500&&i<800) { gettedPlayer=3; } else
            if(i>=800&&i<1100) { gettedPlayer=4; } else
            if(i>=1100&&i<9999) { gettedPlayer=5; }
            //蓝点数
            write(0x0043AEE1,new byte[] { 0xE9,0x51,0x81,0x07,0x00,0x90,0x90 });//jmp 004B3037
            write(0x004B3037,new byte[] { 0xC7,0x40,0x30,b[0],b[1],b[2],b[3],   //mov [eax+30],b[]
                                          0xEB,0xC8  });                        //jmp 004B3008            
            write(0x004B3008,new byte[] { 0x8B,0x45,0xFC,                       //mov eax,[ebp-04] 
                                          0xE9,0xD8,0x7E,0xF8,0xFF});           //jmp 0043AEE8

            b=BitConverter.GetBytes(gettedPlayer);
            //奖残数
            write(0x0043AF92,new byte[] { 0xE9,0x3B,0x80,0x07,0x00,0x90,0x90,0x90,0x90 });//jmp 004B2FD2
            write(0x004B2FD2,new byte[] { 0xC7,0x40,0x34,b[0],b[1],b[2],b[3],        //mov [eax+34],b[]
                                          0xE8,0x92,0xD4,0xF8,0xFF,                  //call 00440470
                                          0xEB,0xD9 });                              //jmp 004B2FB9
            write(0x004B2FB9,new byte[] { 0xE9,0xDD,0x7F,0xF8,0xFF });               //jmp 0043AF9B



        }

        public override void SetIBomb(int i) {
            byte[] b = BitConverter.GetBytes((float)i);
            write(0x0043AE67,new byte[] { 0xE9,0xAA,0xBF,0xFC,0xFF,0x90,0x90,0x90 });         //jmp 00406E16
            write(0x00406E16,new byte[] { 0x8B,0x4D,0xFC,                                     //mov ecx,[ebp-04]
                                          0xEB,0x26 });                                       //jmp 00406E41
            write(0x00406E41,new byte[] { 0xC7,0x80,0x80,0x00,0x00,0x00,b[0],b[1],b[2],b[3],  //mov [eax+00000080],b[]
                                          0xE9,0xD1,0x00,0x00,0x00 });                        //jmp 00406F21

            write(0x00406F21,new byte[] { 0xE8,0x60,0x57,0x03,0x00,                           //call 0043C686
                                          0xE9,0x44,0x3F,0x03,0x00 });                        //jmp 0043AE6F
        }

        public override void SetIBombFragment(int i) { }
        public override void SetIPower(int i) {
            byte[] b = BitConverter.GetBytes((float)i);

            write(0x0043B2D0,HexCodeHelper.getNop(6));
            write(0x0043B2EC,HexCodeHelper.getNop(6));
            write(0x0043B308,HexCodeHelper.getNop(6));

            write(0x0043AE77,new byte[] { 0xE9,0x47,0x19,0x00,0x00,0x90 });//jmp 0043C7C3
            write(0x0043C7C3,new byte[] { 0xC7,0x80,0x98,0x00,0x00,0x00,b[0],b[1],b[2],b[3],//mov [eax+00000098],b[]
                                          0xEB,0x8C });//jmp 0043C75B
            write(0x0043C75B,new byte[] { 0xE9,0x1D,0xE7,0xFF,0xFF });//jmp 0043AE7D
        }

        public override void SetIScore(int i) { }
        public override void SetIMaxPoint(int i) { }
        public override void SetISpecial1(int i) { }
        public override void SetISpecial2(int i) { }
        public override void SetISpecial3(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
