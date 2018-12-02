using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH11Code:THCode {
        MemoryTool mt;
        string gameTitle = "东方弟灵殿";
        public override string getTitle() {
            return gameTitle;
        }
        public override string[] getDefaultValue() {
            return new string[] { "0","0","0" };
        }
        public override string[] getSpecialTip() {
            return new string[] { "魔A灵力","","" };
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override bool[] getEnable() {
            return new bool[13] { true,true,true,true,true,false,false,true,false,false,true,false,false };
        }
        public override void setLockPlayer(bool b) {
            write(0x004327F0,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0x89,0x15,0x18,0x57,0x4A,0x00 });
        }
        public override void setLockBomb(bool b) {
            write(0x004311F1,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0x29,0x15,0xE8,0x56,0x4A,0x00 });
        }
        public override void setUnbeatable(bool b) {
            write(0x00432A9E,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xC7,0x87,0x28,0x09,0x00,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setPlayer(int i) {
            write(0x004A5718,i);
        }
        public override void setPlayerFragment(int i) {
            write(0x004A571C,i);
        }
        public override void setBomb(int i) {
            throw new NotImplementedException();
        }
        public override void setBombFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setPower(int i) {
            write(0x004A56E8,i/5);
        }
        public override void setScore(int i) {
            write(0x004A56E4,i/10);
        }
        public override void setMaxPoint(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial1(int i) {
            write(0x004A56E8,(int)(i/8.333333333333f));
        }
        public override void setSpecial2(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            return (int)(mt.ReadInteger(0x004A56E8)*8.333333333333f);
        }
        public override int getSpecial2() {
            throw new NotImplementedException();
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }
        public override void setIPlayer(byte b) {
            write(0x0041FA38,new byte[] { 0xE9,0x84,0xFE,0xFF,0xFF,0x90 });
            write(0x0041F8C1,new byte[] { 0xC7,0x05,0x18,0x57,0x4A,0x00,b,0x00,0x00,0x00,0xE9,0x6E,0x01,0x00,0x00 });
            write(0x0041FA4F,b);
        }
        public override void setIPlayerFragment(byte b) {
            write(0x0041FA30,new byte[] { 0xE9,0x1F,0xFE,0xFF,0xFF,0x90 });
            write(0x0041F854,new byte[] { 0xC7,0x05,0x1C,0x57,0x4A,0x00,b,0x00,0x00,0x00,0xEB,0x17 });
            write(0x0041F877,new byte[] { 0xE9,0xBA,0x01,0x00,0x00 });
            write(0x0041F85A,b);

        }
        public override void setIBomb(byte b) {
            throw new NotImplementedException();
        }
        public override void setIBombFragment(byte b) {
            throw new NotImplementedException();
        }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i/5);
            write(0x0041FA8C,new byte[] { 0xE9,0x12,0xFD,0xFF,0xFF,0x90 });
            write(0x0041F7A3,new byte[] { 0xC7,0x05,0xE8,0x56,0x4A,0x00,b[0],b[1],b[2],b[3],0xEB,0x18 });
            write(0x0041FA7D,new byte[] { 0xE9,0xE0,0xFC,0xFF,0xFF,0x90 });
            write(0x0041F762,new byte[] { 0xC7,0x05,0xE8,0x56,0x4A,0x00,b[0],b[1],b[2],b[3],0xEB,0xDA });
            write(0x0041F748,new byte[] { 0xE9,0x36,0x03,0x00,0x00 });
        }
        public override void setIScore(int i) {
            throw new NotImplementedException();
        }
        public override void setIMaxPoint(int i) {
            throw new NotImplementedException();
        }
        public override void setISpecial1(int i) {
            byte[] b = BitConverter.GetBytes((int)(i/8.3333333333f));
            write(0x0041FA8C,new byte[] { 0xE9,0x12,0xFD,0xFF,0xFF,0x90 });
            write(0x0041F7A3,new byte[] { 0xC7,0x05,0xE8,0x56,0x4A,0x00,b[0],b[1],b[2],b[3],0xEB,0x18 });
            write(0x0041FA7D,new byte[] { 0xE9,0xE0,0xFC,0xFF,0xFF,0x90 });
            write(0x0041F762,new byte[] { 0xC7,0x05,0xE8,0x56,0x4A,0x00,b[0],b[1],b[2],b[3],0xEB,0xDA });
            write(0x0041F748,new byte[] { 0xE9,0x36,0x03,0x00,0x00 });
        }
        public override void setISpecial2(int i) {
            throw new NotImplementedException();
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
