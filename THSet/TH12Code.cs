using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH12Code:THCode {
        MemoryTool mt;
        string gameTitle = "东方红红蓝";
        public override bool[] getEnable() {
            return new bool[] { true,true,true,true,true,true,true,true,true,true,true,true,false };
        }
        public override string getTitle() {
            return gameTitle;
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override string getSpecialTip() {
            return "0无 1红 2蓝 3绿";
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override void setLockBomb(bool b) {
            write(0x00422F28,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0xA0,0x0C,0x4B,0x00 });
        }
        public override void setLockPlayer(bool b) {
            write(0x004381E7,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0x29,0x1D,0x98,0x0C,0x4B,0x00 });
        }
        public override void setChoice(bool b) {
            write(0x00438379,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xC7,0x86,0x28,0x0A,0x00,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setPlayer(int i) {
            write(0x004B0C98,i);
        }
        public override void setPlayerFragment(int i) {
            write(0x004B0C9C,i);
        }
        public override void setBomb(int i) {
            write(0x004B0CA0,i);
        }
        public override void setBombFragment(int i) {
            write(0x004B0CA4,i);
        }
        public override void setPower(int i) {
            write(0x004B0C48,i);
        }
        public override void setScore(int i) {
            write(0x004B0C44,i/10);
        }
        public override void setMaxPoint(int i) {
            write(0x004B0C78,i*100);
        }
        public override void setSpecial1(int i) {
            write(0x004B0C4C,i);
        }
        public override void setSpecial2(int i) {
            write(0x004B0C50,i);
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            return mt.ReadInteger(0x004B0C4C);
        }
        public override int getSpecial2() {
            return mt.ReadInteger(0x004B0C50);
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }

        public override void setIPlayer(byte b) {
            write(0x00421E81,new byte[] { 0xE9,0x5A,0x5C,0x07,0x00,0x90 });
            write(0x00497AE0,new byte[] { 0xC7,0x05,0x98,0x0C,0x4B,0x00,b,0x00,0x00,0x00,0xE9,0x98,0xA3,0xF8,0xFF });
            write(0x00421E92,new byte[] { 0xC7,0x05,0x98,0x0C,0x4B,0x00,b });
        }
        public override void setIPlayerFragment(byte b) {
            write(0x00421E79,new byte[] { 0xE9,0x71,0x5C,0x07,0x00,0x90 });
            write(0x00497AEF,new byte[] { 0xC7,0x05,0x9C,0x0C,0x4B,0x00,b,0x00,0x00,0x00,0xE9,0x81,0xA3,0xF8,0xFF });
        }
        public override void setIBomb(byte b) {
            write(0x00421DEF,new byte[] { 0xE9,0x0A,0x5D,0x07,0x00,0x90 });
            write(0x00497AFE,new byte[] { 0xC7,0x05,0xA0,0x0C,0x4B,0x00,b,0x00,0x00,0x00,0xE9,0xE8,0xA2,0xF8,0xFF });
        }
        public override void setIBombFragment(byte b) {
            write(0x00421E35,new byte[] { 0xE9,0xD3,0x5C,0x07,0x00,0x90 });
            write(0x00497B0D,new byte[] { 0xC7,0x05,0xA4,0x0C,0x4B,0x00,b,0x00,0x00,0x00,0xE9,0x1F,0xA3,0xF8,0xFF });
        }
        public override void setIPower(int i) {
            byte[] b1 = BitConverter.GetBytes(i);
            write(0x00421F20,new byte[] { 0xE9,0xF7,0x5B,0x07,0x00 });
            write(0x00497B1C,new byte[] { 0xC7,0x05,0x48,0x0C,0x4B,0x00,b1[0],b1[1],b1[2],b1[3],0xE9,0xFA,0xA3,0xF8,0xFF });
        }
        public override void setIScore(int i) {
            byte[] b1 = BitConverter.GetBytes(i/10);
            write(0x00421DE9,new byte[] { 0xE9,0x3D,0x5D,0x07,0x00,0x90 });
            write(0x00497B2B,new byte[] { 0xC7,0x05,0x44,0x0C,0x4B,0x00,b1[0],b1[1],b1[2],b1[3],0xE9,0xB5,0xA2,0xF8,0xFF });
        }
        public override void setIMaxPoint(int i) {
            byte[] b1 = BitConverter.GetBytes(i*100);
            write(0x00421E74,new byte[] { 0xE9,0xC1,0x5C,0x07,0x00 });
            write(0x00497B3A,new byte[] { 0xC7,0x05,0x78,0x0C,0x4B,0x00,b1[0],b1[1],b1[2],b1[3],0xE9,0x30,0xA3,0xF8,0xFF });
        }
        public override void setISpecial1(int i) {
            byte[] b1 = BitConverter.GetBytes(i);
            write(0x00421E47,new byte[] { 0xE9,0xFD,0x5C,0x07,0x00,0x90 });
            write(0x00497B49,new byte[] { 0xC7,0x05,0x4C,0x0C,0x4B,0x00,b1[0],b1[1],b1[2],b1[3],0xE9,0xF5,0xA2,0xF8,0xFF });
        }
        public override void setISpecial2(int i) {
            byte[] b1 = BitConverter.GetBytes(i);
            write(0x00421E41,new byte[] { 0xE9,0x12,0x5D,0x07,0x00,0x90 });
            write(0x00497B58,new byte[] { 0xC7,0x05,0x50,0x0C,0x4B,0x00,b1[0],b1[1],b1[2],b1[3],0xE9,0xE0,0xA2,0xF8,0xFF });
        }
        public override void setISpecial3(int i) {
            throw new NotImplementedException();
        }


        private void write(int addr,int value) {
            mt.WriteInteger(addr,value);
        }
        private void write(int addr,byte[] value) {
            mt.WriteBytes(addr,value);
        }
        private void write(int addr,byte[] opCode,byte value2) {
            List<byte> tmp = opCode.ToList();
            tmp.Add(value2);
            mt.WriteBytes(addr,tmp.ToArray());
        }
    }
}
