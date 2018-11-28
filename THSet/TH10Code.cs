using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH10Code:THCode {
        MemoryTool mt;
        string gameTitle = "东方神曲录";
        public override string getTitle() {
            return gameTitle;
        }
        public override string[] getSpecialTip() {
            return new string[] { "信仰值","","" };
        }
        public override string[] getDefaultValue() {
            return new string[] { "999990","0","0" };
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override bool[] getEnable() {
            return new bool[13] { true,true,true,true,false,false,false,true,true,false,true,false,false };
        }
        public override void setLockPlayer(bool b) {
            write(0x00426A1C,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 } :
                               new byte[] { 0x89,0x0D,0x70,0x4C,0x47,0x00 });
        }
        public override void setLockBomb(bool b) {
            write(0x004259D4,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0x66,0x83,0x05,0x48,0x4C,0x47,0x00,0xEC });
            write(0x00425C43,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0x66,0x83,0x05,0x48,0x4C,0x47,0x00,0xEC });
        }
        public override void setUnbeatable(bool b) {
            write(0x00426CFF,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xC7,0x85,0x58,0x04,0x00,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setPlayer(int i) {
            write(0x00474C70,i);
        }
        public override void setPlayerFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setBomb(int i) {
            throw new NotImplementedException();
        }
        public override void setBombFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setPower(int i) {
            write(0x00474C48,i/5);
        }
        public override void setScore(int i) {
            write(0x00474C44,i/10);
        }
        public override void setMaxPoint(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial1(int i) {
            write(0x00474C4C,i/10);
        }
        public override void setSpecial2(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            return mt.ReadInteger(0x00474C4C)*10;
        }
        public override int getSpecial2() {
            throw new NotImplementedException();
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }
        public override void setIPlayer(byte b) {
            write(0x0041794F,new byte[] { 0xC7,0x05,0x70,0x4C,0x47,0x00,b });
            write(0x00417964,new byte[] { 0xC7,0x05,0x70,0x4C,0x47,0x00,b });
        }
        public override void setIPlayerFragment(byte b) {
            throw new NotImplementedException();
        }
        public override void setIBomb(byte b) {
            throw new NotImplementedException();
        }
        public override void setIBombFragment(byte b) {
            throw new NotImplementedException();
        }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i/5);
            write(0x0041798C,new byte[] { 0xE9,0xF5,0xE0,0x04,0x00,0x90 });
            write(0x00465A86,new byte[] { 0xC7,0x05,0x48,0x4C,0x47,0x00,b[0],b[1],b[2],b[3],0xE9,0xFD,0x1E,0xFB,0xFF });
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x0041793B,new byte[] { 0xE9,0x67,0xE1,0x04,0x00,0x90 });
            write(0x00465AA7,new byte[] { 0xC7,0x05,0x44,0x4C,0x47,0x00,b[0],b[1],b[2],b[3],0xE9,0x8B,0x1E,0xFB,0xFF });

        }
        public override void setIMaxPoint(int i) {
            throw new NotImplementedException();
        }
        public override void setISpecial1(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x00418B93,new byte[] { 0xE9,0xFD,0xCE,0x04,0x00,0x90 });
            write(0x00465A95,new byte[] { 0xC7,0x05,0x4C,0x4C,0x47,0x00,b[0],b[1],b[2],b[3],0x8B,0x41,0x24,0xE9,0xF2,0x30,0xFB,0xFF });
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
