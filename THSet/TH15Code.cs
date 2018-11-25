using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH15Code:THCode {
        MemoryTool mt;
        string gameTitle = "东方199";
        public override string getTitle() {
            return gameTitle;
        }
        public override string getSpecialTip() {
            return "当前阶段擦弹数";
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override bool[] getEnable() {
            return new bool[] { true,true,true,true,true,true,true,true,true,true,true,false,false};
        }
        public override void setLockPlayer(bool b) {
            throw new NotImplementedException();
        }
        public override void setLockBomb(bool b) {
            throw new NotImplementedException();
        }
        public override void setUnbeatable(bool b) {
            throw new NotImplementedException();
        }
        public override void setPlayer(int i) {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        public override void setScore(int i) {
            throw new NotImplementedException();
        }
        public override void setMaxPoint(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial1(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial2(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            throw new NotImplementedException();
        }
        public override int getSpecial2() {
            throw new NotImplementedException();
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }
        public override void setIPlayer(byte b) {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        public override void setIScore(int i) {
            throw new NotImplementedException();
        }
        public override void setIMaxPoint(int i) {
            throw new NotImplementedException();
        }
        public override void setISpecial1(int i) {
            throw new NotImplementedException();
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
