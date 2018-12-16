using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH12Code:THCode {
        MemoryTool mt;
        public TH12Code(MemoryTool m) => mt=m;
        public override bool[] getEnable() => new bool[18] { true,true,true,true,true,true,true,true,true,true,true,true,false,true,true,true,true,true };
        public override string getTitle() => new Random().Next()%2==0 ? "春之岸边播放器" : "东方红红蓝";
        public override string getAboutBug() => "得分超过2,147,483,647时继续获得分数会使计数倒退";
        public override string getAboutSpecial() => "0-无 1-红 2-蓝 3-绿";
        public override string[] getDefaultValue() => new string[] { "0","0","0" };
        public override string[] getSpecialTip() => new string[] { "飞碟1","飞碟2","" };
        public override void StartCount() {
            //miss
            write(0x004381E7,new byte[] { 0xEB,0xE9,0x90,0x90,0x90,0x90 });//jmp 004381D2
            write(0x004381D2,new byte[] { 0x29,0x1D,0x98,0x0C,0x4B,0x00,   //sub [004B0C98],ebx
                                          0xFF,0x05,0xA0,0x10,0x4B,0x00,   //inc [004B10A0]
                                          0xEB,0x0D });                    //jmp 004381ED
            write(0x004B10A0,0);
            //bomb
            write(0x00422F28,new byte[] { 0xE9,0xA4,0xFD,0xFF,0xFF });     //jmp 00422CD1
            write(0x00422CD1,new byte[] { 0xA3,0xA0,0x0C,0x4B,0x00,        //sub [004B0CA0],ebx
                                          0xFF,0x05,0xA4,0x10,0x4B,0x00,   //inc [004B10A4]
                                          0xEB,0xA7 });                    //jmp 00422C85
            write(0x00422C85,new byte[] { 0xE9,0xA3,0x02,0x00,0x00 });     //jmp 00422F2D
            write(0x004B10A4,0);
        }
        public override int getMissCount() => mt.ReadInteger(0x004B10A0);
        public override int getBombCount() => mt.ReadInteger(0x004B10A4);
        public override int getBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004B43C8)+0x5C);
        public override int getBossLife() => mt.ReadInteger(mt.ReadInteger(0x004B43E4)+0x6CF0);
        public override void killSelf() => write(mt.ReadInteger(0x004B4514)+0xA28,4);
        public override void setLockPlayer(bool b) => write(0x004381D2,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0x29,0x1D,0x98,0x0C,0x4B,0x00 });//sub [004B0C98],ebx
        public override void setLockBomb(bool b) => write(0x00422CD1,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xA3,0xA0,0x0C,0x4B,0x00 });//mov [004B0CA0],eax
        public override void setUnbeatable(bool b) => write(0x00438379,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xC7,0x86,0x28,0x0A,0x00,0x00,0x04,0x00,0x00,0x00 });//mov [esi+00000A28],00000004
        public override void setFPS(int i) {
            if(write(0x60018ABC,i)==0) {
                write(0x00450014,BitConverter.GetBytes((double)1/i));
                write(0x0045044C,new byte[] { 0xDD,0x05,0x14,0x00,0x45,0x00 });//fld qword ptr [00450014]
            }
        }
        public override void setPlayer(int i) => write(0x004B0C98,i);
        public override void setPlayerFragment(int i) => write(0x004B0C9C,i);
        public override void setBomb(int i) => write(0x004B0CA0,i);
        public override void setBombFragment(int i) => write(0x004B0CA4,i);
        public override void setPower(int i) => write(0x004B0C48,i);
        public override void setScore(int i) => write(0x004B0C44,i/10);
        public override void setMaxPoint(int i) => write(0x004B0C78,i*100);
        public override void setSpecial1(int i) => write(0x004B0C4C,i);
        public override void setSpecial2(int i) => write(0x004B0C50,i);
        public override void setSpecial3(int i) => throw new NotImplementedException();
        public override int getSpecial1() => mt.ReadInteger(0x004B0C4C);
        public override int getSpecial2() => mt.ReadInteger(0x004B0C50);
        public override int getSpecial3() => throw new NotImplementedException();
        public override void setIPlayer(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            write(0x00421E81,new byte[] { 0xE9,0x5A,0x5C,0x07,0x00,0x90 });              //jmp 00497AE0
            write(0x00497AE0,new byte[] { 0xC7,0x05,0x98,0x0C,0x4B,0x00,b,0x00,0x00,0x00,//mov [004B0C98],b
                                          0xE9,0x98,0xA3,0xF8,0xFF });                   //jmp 00421E87
            write(0x00421E92,new byte[] { 0xC7,0x05,0x98,0x0C,0x4B,0x00,b });            //mov [004B0C98],b
        }
        public override void setIPlayerFragment(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            write(0x00421E79,new byte[] { 0xE9,0x71,0x5C,0x07,0x00,0x90 });              //jmp 00497AEF
            write(0x00497AEF,new byte[] { 0xC7,0x05,0x9C,0x0C,0x4B,0x00,b,0x00,0x00,0x00,//mov [004B0C9C],b
                                          0xE9,0x81,0xA3,0xF8,0xFF });                   //jmp 00421E7F
        }
        public override void setIBomb(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            write(0x00421DEF,new byte[] { 0xE9,0x0A,0x5D,0x07,0x00,0x90 });              //jmp 00497AFE
            write(0x00497AFE,new byte[] { 0xC7,0x05,0xA0,0x0C,0x4B,0x00,b,0x00,0x00,0x00,//mov [004B0CA0],b
                                          0xE9,0xE8,0xA2,0xF8,0xFF });                   //jmp 00421DF5
        }
        public override void setIBombFragment(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            write(0x00421E35,new byte[] { 0xE9,0xD3,0x5C,0x07,0x00,0x90 });              //jmp 00497B0D
            write(0x00497B0D,new byte[] { 0xC7,0x05,0xA4,0x0C,0x4B,0x00,b,0x00,0x00,0x00,//mov [004B0CA4],b
                                          0xE9,0x1F,0xA3,0xF8,0xFF });                   //jmp 00421E3B
        }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00421F20,new byte[] { 0xE9,0xF7,0x5B,0x07,0x00 });//jmp 00497B1C
            write(0x00497B1C,new byte[] { 0xC7,0x05,0x48,0x0C,0x4B,0x00,b[0],b[1],b[2],b[3],   //mov [004B0C48],b[]
                                          0xE9,0xFA,0xA3,0xF8,0xFF });                         //jmp 00421F25
            write(0x00421ED3,new byte[] { 0xC7,0x05,0x48,0x0C,0x4B,0x00,b[0],b[1],b[2],b[3] });//mov [004B0C48],b[]
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x00421DE9,new byte[] { 0xE9,0x3D,0x5D,0x07,0x00,0x90 });                 //jmp 00497B2B
            write(0x00497B2B,new byte[] { 0xC7,0x05,0x44,0x0C,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004B0C44],b[]
                                          0xE9,0xB5,0xA2,0xF8,0xFF });                      //jmp 00421DEF
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x00421E74,new byte[] { 0xE9,0xC1,0x5C,0x07,0x00 });                      //jmp 00497B3A
            write(0x00497B3A,new byte[] { 0xC7,0x05,0x78,0x0C,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004B0C78],b[]
                                          0xE9,0x30,0xA3,0xF8,0xFF });                      //jmp 00421E79
        }
        public override void setISpecial1(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00421E47,new byte[] { 0xE9,0xFD,0x5C,0x07,0x00,0x90 });                 //jmp 00497B49
            write(0x00497B49,new byte[] { 0xC7,0x05,0x4C,0x0C,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004B0C4C],b[]
                                          0xE9,0xF5,0xA2,0xF8,0xFF });                      //jmp 00421E4D
        }
        public override void setISpecial2(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00421E41,new byte[] { 0xE9,0x12,0x5D,0x07,0x00,0x90 });                 //jmp 00497B58
            write(0x00497B58,new byte[] { 0xC7,0x05,0x50,0x0C,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004B0C50],b[]
                                          0xE9,0xE0,0xA2,0xF8,0xFF });                      //jmp 00421E47
        }
        public override void setISpecial3(int i) => throw new NotImplementedException();
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
