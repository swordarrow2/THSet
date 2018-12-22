using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH15Code:THCode {
        MemoryTool mt;
        public TH15Code(MemoryTool m) => mt=m;
        public override string getTitle() => new Random().Next()%2==0 ? "东方跟着转" : "东方199";
        public override string getAboutBug() => "boss符卡宣言时扔雷会导致boss保持无敌状态，bomb结束(铃仙为撞掉一层盾)时解除无敌\n\n无敌状态进入Extra八非时boss会无敌且无法解除\n\n无欠模式若纯符击破撞，需重启游戏再打此章节";
        public override string getAboutSpecial() => "没啥好说的，使劲擦弹就得了（";
        public override string[] getSpecialTip() => new string[] { "章节擦弹","","" };
        public override string[] getDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() {
            //miss
            write(0x00456398,new byte[] { 0xE9,0x95,0x03,0x00,0x00 });   //jmp 00456732
            write(0x00456732,new byte[] { 0xA3,0x50,0x74,0x4E,0x00,      //mov [004E7450],eax
                                          0xFF,0x05,0x3C,0x75,0x4E,0x00, //inc [004E753C]
                                          0xEB,0x65 });                  //jmp 004567A4
            write(0x004567A4,new byte[] { 0xE9,0xF4,0xFB,0xFF,0xFF });   //jmp 0045639D
            write(0x004E753C,0);
            //bomb
            write(0x0041497A,new byte[] { 0xE9,0x56,0xFF,0xFF,0xFF });     //jmp 004148D5
            write(0x004148D5,new byte[] { 0xA3,0x5C,0x74,0x4E,0x00,        //mov [004E745C],eax
                                          0xEB,0x09 });                    //jmp 004148E5
            write(0x004148E5,new byte[] { 0xFF,0x05,0x40,0x75,0x4E,0x00,   //inc [004E7540]
                                          0xE9,0x8F,0x00,0x00,0x00 });     //jmp 0041497F
            write(0x004E7540,0);
        }
        public override int getMissCount() => mt.ReadInteger(0x004E753C);
        public override int getBombCount() => mt.ReadInteger(0x004E7540);
        public override int getBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004E9A6C)+0x40);
        public override int getBossLife() => mt.ReadInteger(mt.ReadInteger(0x004E9A8C)+0x1D4);
        public override void killSelf() => write(mt.ReadInteger(0x004E9BB8)+0x16220,4);
        public override bool[] getEnable() => new bool[28] { true,true,true,true,true,false,true,true,false,false,
                                                             true,true,true,true,true,false,true,false,false,false,
                                                             true,true,true,true,true,true,true,true };
        public override void setLockPlayer(bool b) => write(0x00456732,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xA3,0x50,0x74,0x4E,0x00 });                         //mov [004E7450],eax
        public override void setLockBomb(bool b) => write(0x004148D5,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xA3,0x5C,0x74,0x4E,0x00 });                         //mov [004E745C],eax
        public override void setUnbeatable(bool b) => write(0x0045669F,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } : new byte[] { 0xC7,0x87,0x20,0x62,0x01,0x00,0x04,0x00,0x00,0x00 });//mov [edi+00016220],00000004
        public override void setFPS(int i) {
            if(write(0x60940A34,i)==0) {
                write(0x00472931,BitConverter.GetBytes((double)1/i));
                write(0x004727FE,new byte[] { 0xF2,0x0F,0x10,0x15,0x31,0x29,0x47,0x00 });          //movsd xmm2,[00472931]
            }
        }
        public override void setPlayer(int i) => write(0x004E7450,i);
        public override void setPlayerFragment(int i) => write(0x004E7454,i);
        public override void setBomb(int i) => write(0x004E745C,i);
        public override void setBombFragment(int i) => write(0x004E7460,i);
        public override void setPower(int i) => write(0x004E7440,i);
        public override void setScore(int i) => write(0x004E740C,i/10);
        public override void setMaxPoint(int i) => write(0x004E7434,i*100);
        public override void setSpecial1(int i) => write(0x004E7420,i);
        public override void setSpecial2(int i) => throw new NotImplementedException();
        public override void setSpecial3(int i) => throw new NotImplementedException();
        public override int getSpecial1() => mt.ReadInteger(0x004E7420);
        public override int getSpecial2() => throw new NotImplementedException();
        public override int getSpecial3() => throw new NotImplementedException();
        public override void setIPlayer(int i) {
            write(0x0043C2B3,i);
            write(0x0043C2C8,i);
        }
        public override void setIPlayerFragment(int i) => write(0x0043E716,i);
        public override void setIBomb(int i) => write(0x0043E6F1,i);
        public override void setIBombFragment(int i) => write(0x0043E70F,i);
        public override void setIPower(int i) {
            write(0x0043C32B,new byte[] { 0x90,0x90,0x90,0x90,0x90 });               //nop
            write(0x0043C383,new byte[] { 0x90,0x90,0x90,0x90,0x90 });               //nop
            write(0x0043C353,new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 });          //nop
            write(0x0043E6E3,i);
        }
        public override void setIScore(int i) => throw new NotImplementedException();
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x0043C225,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90,0x90 });//mov ecx,b[]
        }
        public override void setISpecial1(int i) => throw new NotImplementedException();
        public override void setISpecial2(int i) => throw new NotImplementedException();
        public override void setISpecial3(int i) => throw new NotImplementedException();
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
