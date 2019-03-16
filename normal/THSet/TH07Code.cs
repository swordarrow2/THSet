using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH07Code:THCode {
        MemoryTool mt;
        public override void checkNeedBomb() {
            throw new NotImplementedException();
        }
        public TH07Code(MemoryTool m) => mt=m;
        public override void setStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }

        public override string getTitle() => new Random().Next()%2==0 ? "东方妖妖梦" : "东方999";
        public override string[] getSpecialTip() => new string[] { "收卡数","结界","分母" };
        public override string getAboutBug() => "";
        public override string getAboutSpecial() => "";
        public override string[] getDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() {
        }
        public override int getMissCount() => (int)mt.ReadFloat(mt.ReadInteger(0x00626278)+0x50);
        public override int getBombCount() => (int)mt.ReadFloat(mt.ReadInteger(0x00626278)+0x6C);
        public override int getBulletCount() => mt.ReadInteger(0x009A9A80);
        public override int getBossLife() { return 0; }
        public override void killSelf() { }
        public override bool[] getEnable() => new bool[30] { false,true,false,false,true,false,true,true,true,true,
                                                             true,true,true,false,true,false,true,true,true,true,
                                                             true,true,false,true,true,false,true,false,false,false };
        public override void setLockPlayer(bool b) => write(0x0042D602,HexCodeHelper.getValueArray(new byte[] { 0xD9,0x58,0x5C },b));
        public override void setLockBomb(bool b) => write(0x0042D647,HexCodeHelper.getValueArray(new byte[] { 0xD9,0x58,0x68 },b));
        public override void setUnbeatable(bool b) { }
        public override void setFPS(int i) => write(0x60015A4C,i);
        public override void setPlayer(int i) { }
        public override void setPlayerFragment(int i) => write(mt.ReadInteger(0x00626278)+0x28,i);
        public override void setBomb(int i) { }
        public override void setBombFragment(int i) { }
        public override void setPower(int i) { }
        public override void setScore(int i) { }
        public override void setMaxPoint(int i) { }
        public override void setSpecial1(int i) => write(mt.ReadInteger(0x00626278)+0x1C,i);
        public override void setSpecial2(int i) => write(0x0062F890,i+mt.ReadInteger(0x00626278,0x88));
        public override void setSpecial3(int i) => write(0x0062F888,i+mt.ReadInteger(0x00626278,0x88));
        public override int getSpecial1() => mt.ReadInteger(0x00626278,0x1C);
        public override int getSpecial2() => mt.ReadInteger(0x0062F890)-mt.ReadInteger(0x00626278,0x88);
        public override int getSpecial3() => mt.ReadInteger(0x0062F888)-mt.ReadInteger(0x00626278,0x88);
        public override void setIPlayer(int i) {
            byte[] b = BitConverter.GetBytes((float)i);
            write(0x0042EA14,new byte[] { 0xA1,0x78,0x62,0x62,0x00,           //mov eax,[00626278]
                                          0xE9,0x33,0x10,0x00,0x00,0x90 });   //jmp 0042FA51
            write(0x0042FA51,new byte[] { 0XC7,0x40,0x5C,b[0],b[1],b[2],b[3], //mov [eax+5C],b[]
                                          0xE9,0xC2,0xEF,0xFF,0xFF });        //jmp 0042EA1F
        }
        public override void setIPlayerFragment(int i) {
            int gettedPlayer = 0;
            int needPoint = 0;
            if(i<50) { gettedPlayer=0; needPoint=50; } else
            if(i>50&&i<125) { gettedPlayer=1; needPoint=125; } else
            if(i>125&&i<200) { gettedPlayer=2; needPoint=200; } else
            if(i>200&&i<300) { gettedPlayer=3; needPoint=300; } else
            if(i>300&&i<450) { gettedPlayer=4; needPoint=450; } else
            if(i>450&&i<600) { gettedPlayer=5; needPoint=600; } else
            if(i>600&&i<800) { gettedPlayer=6; needPoint=800; } else
            if(i>800&&i<1000) { gettedPlayer=7; needPoint=1000; } else
            if(i>1000&&i<1200) { gettedPlayer=8; needPoint=1200; } else
            if(i>1200&&i<1400) { gettedPlayer=9; needPoint=1400; } else
            if(i>1400&&i<1600) { gettedPlayer=10; needPoint=1600; } else
            if(i>1600&&i<1800) { gettedPlayer=11; needPoint=1800; } else
            if(i>1800&&i<2000) { gettedPlayer=12; needPoint=2000; }
            byte[] b = BitConverter.GetBytes(i);
            byte[] c = BitConverter.GetBytes(gettedPlayer);
            byte[] d = BitConverter.GetBytes(needPoint);
            write(0x0042EAAA,new byte[] { 0xE9,0xB1,0xE2,0x05,0x00,0x90,0x90 });
            write(0x0042EAE3,HexCodeHelper.getNop(4));
            write(0x0042EABD,HexCodeHelper.getNop(7));
            write(0x0048CD60,new byte[] { 0xC7,0x40,0x28,b[0],b[1],b[2],b[3],//mov [eax+28],0
                                          0xC7,0x40,0x2C,c[0],c[1],c[2],c[3],//mov [eax+2C],c[]
                                          0xC7,0x40,0x30,d[0],d[1],d[2],d[3],//mov [eax+30],d[]
                                          0x8B,0x45,0xD4,                    //mov eax,[ebp-2C]
                                          0xE9,0x34,0x1D,0xFA,0xFF });       //jmp 0042EAB1
        }
        public override void setIBomb(int i) {
            byte[] b = BitConverter.GetBytes((float)i);
            write(0x0042EA41,new byte[] { 0xE9,0xF2,0xE2,0x05,0x00,0x90,0x90,0x90 });   //jmp 00401384
            write(0x0048CD38,new byte[] { 0x8B,0x4D,0xD4,                               //mov ecx,[ebp-2C]
                                          0xE8,0x17,0x09,0xFA,0xFF,                     //call 0042D657
                                          0xA1,0x78,0x62,0x62,0x00,                     //mov eax,[626278]
                                          0xC7,0x40,0x68,b[0],b[1],b[2],b[3],           //mov [eax+68],b[]
                                          0xE9,0xF8,0x1C,0xFA,0xFF });                  //jmp 0042EA49                    
        }
        public override void setIBombFragment(int i) { }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes((float)i);
            write(0x0042F04F,HexCodeHelper.getNop(3));
            write(0x0042EA51,new byte[] { 0xE9,0xFB,0xE2,0x05,0x00,0x90 });
            write(0x0048CD51,new byte[] { 0xC7,0x40,0x7C,b[0],b[1],b[2],b[3],//mov [eax+7C],b[]
                                          0x8B,0x4D,0xD4,                    //mov ecx,[ebp-2C]
                                          0xE9,0xF7,0x1C,0xFA,0xFF });       //jmp 0042EA57
        }
        public override void setIScore(int i) { }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042EC57,HexCodeHelper.getNop(6));
            write(0x0042ED33,HexCodeHelper.getNop(6));
            write(0x0042ED61,HexCodeHelper.getNop(6));
            write(0x0042EDE2,HexCodeHelper.getNop(6));
            write(0x0042EDB7,HexCodeHelper.getNop(6));
            write(0x0042ED8C,HexCodeHelper.getNop(6));
            write(0x0042EC21,HexCodeHelper.getNop(6));
            write(0x0042E990,new byte[] { 0xE9,0xE8,0xE3,0x05,0x00,0x90 }); //jmp 0048CD7D
            write(0x0048CD7D,new byte[] { 0x05,b[0],b[1],b[2],b[3],         //add eax,123456
                                          0x89,0x81,0x1C,0x96,0x00,0x00,    //mov dword ptr [ecx+961C],eax
                                          0xE9,0x09,0x1C,0xFA,0xFF });      //jmp 0042E996
        }

        public override void setISpecial1(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042EB29,new byte[] { 0xE9,0x6F,0xE2,0x05,0x00,0x90,0x90 });//jmp 0048CD9D
            write(0x0048CD9D,new byte[] { 0x8B,0x40,0x08,
                                          0xC7,0x40,0x1C,b[0],b[1],b[2],b[3],
                                          0xE9,0x84,0x1D,0xFA,0xFF
            });
        }

        public override void setISpecial2(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042E9A5,new byte[] { 0xE9,0xE3,0xE3,0x05,0x00,0x90 }); //jmp 0048CD8D
            write(0x0048CD8D,new byte[] { 0x05,b[0],b[1],b[2],b[3],         //add eax,b[]
                                          0x89,0x81,0x20,0x96,0x00,0x00,    //mov [ecx+00009620],eax
                                          0xE9,0x0E,0x1C,0xFA,0xFF });      //jmp 0042E9AB
        }
        public override void setISpecial3(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042EC00,i);//extra
            write(0x0042EC36,i);//phantasm
            write(0x0042EC92,i);//easy
            write(0x0042ECAE,i);//normal
            write(0x0042ECCA,i);//hard
            write(0x0042ECE6,i);//lunatic

            write(0x0042ED00,HexCodeHelper.stringToAsm("E9 E3 00 00 00 90"));
        }

        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);

    }
}
