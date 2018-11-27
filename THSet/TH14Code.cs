using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH14Code :THCode {
        MemoryTool mt;
        string gameTitle = "东方1.6";
        public override string getTitle() {
            return gameTitle;
        }
        public override string getSpecialTip() {
            return "1：非2.0次数 2:已获得的奖残数";
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override bool[] getEnable() {
            return new bool[13] { true,true,true,true,true,true,true,true,true,true,true,true,false };
        }
        public override void setLockPlayer(bool b) {
            write(0x0044F618,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0x64,0x58,0x4F,0x00 });
        }
        public override void setLockBomb(bool b) {
            write(0x0041218A,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0x70,0x58,0x4F,0x00 });
        }
        public override void setUnbeatable(bool b) {
            write(0x0044F871,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xC7,0x87,0x84,0x06,0x00,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setPlayer(int i) {
            write(0x004F5864,i);
        }
        public override void setPlayerFragment(int i) {
            write(0x004F5868,i);
        }
        public override void setBomb(int i) {
            write(0x004F5870,i);
        }
        public override void setBombFragment(int i) {
            write(0x004F5874,i);
        }
        public override void setPower(int i) {
            write(0x004F5858,i);
        }
        public override void setScore(int i) {
            write(0x004F5830,i/10);
        }
        public override void setMaxPoint(int i) {
            write(0x004F584C,i*100);
        }
        public override void setSpecial1(int i) {
            write(0x004F5894,i);
        }
        public override void setSpecial2(int i) {
            write(0x004F586C,i);
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            return mt.ReadInteger(0x004F5894);
        }
        public override int getSpecial2() {
            return mt.ReadInteger(0x004F586C);
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }
        public override void setIPlayer(byte b) {
            write(0x00435D42,b);
            write(0x00435D57,b);
        }
        public override void setIPlayerFragment(byte b) {
            write(0x004375E4,b);
        }
        public override void setIBomb(byte b) {
            write(0x004375C1,b);
        }
        public override void setIBombFragment(byte b) {
            write(0x004375DD,b);
        }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00435DBA,new byte[] { 0x90,0x90,0x90,0x90,0x90 });
            write(0x00435E12,new byte[] { 0x90,0x90,0x90,0x90,0x90 });
            write(0x00435D86,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90 });
            write(0x004375B3,i);
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x00435C95,new byte[] { 0xE9,0xC9,0x10,0x00,0x00,0x90 });
            write(0x00436D63,new byte[] { 0xC7,0x05,0x30,0x58,0x4F,0x00,b[0],b[1],b[2],b[3],0xEB,0x06 });
            write(0x00436D75,new byte[] { 0xE9,0x21,0xEF,0xFF,0xFF });
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x00435CB0,new byte[] { 0xB9,0xFF,0xFF,b[0],b[1],b[2],b[3] });
        }
        public override void setISpecial1(int i) {
            write(0x0043760E,i);
        }
        public override void setISpecial2(int i) {
            write(0x004375EB,i);
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
