using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH128Code:THCode {
        MemoryTool mt;
        string gameTitle = "妖精大战争";
        public override string getTitle() {
            return gameTitle;
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override string[] getSpecialTip() {
            return new string[] { "蓄力","","" };
        }
        public override string getAboutBug() {
            return "终符若同时击破了两只妖精，则卡关……无解\n“满身疮痍”界面直接重新开始会导致录像爆炸，应返回主界面重新开始，若没有疮痍，则可以放心使用ESC+R\n难度\\路线选择界面如果按键频率过高可能会出现选择不正确的情况";
        }
        public override string getAboutSpecial() {
            return "";
        }
        public override string[] getDefaultValue() {
            return new string[] { "0","0","0" };
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override bool[] getEnable() {
            return new bool[] { true,true,true,true,false,true,false,true,true,false,true,false,false,true };
        }
        public override void setLockPlayer(bool b) {
            write(0x0042729C,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 } 
                               : new byte[] { 0x89,0x0D,0x64,0x4D,0x4B,0x00 });
        }
        public override void setLockBomb(bool b) {
            write(0x0043B7C1,b ? new byte[] { 0x90,0x90 } : new byte[] { 0x7C,0x30 });
        }
        public override void setUnbeatable(bool b) {
            write(0x0043D0CF,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xC7,0x80,0x78,0x0F,0x00,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setFPS(int i) {
            mt.WriteBytes(0x00454938,BitConverter.GetBytes((double)1/i));
            mt.WriteBytes(0x00454C48,new byte[] { 0xDD,0x05,0x38,0x49,0x45,0x00 });
        }
        public override void setPlayer(int i) {
            write(0x004B4D64,i*100);
        }
        public override void setPlayerFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setBomb(int i) {
            write(0x004B4D70,i*100);
        }
        public override void setBombFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setPower(int i) {
            float f = i;
            write(0x004B4D60,BitConverter.GetBytes(f));
        }
        public override void setScore(int i) {
            throw new NotImplementedException();
        }
        public override void setMaxPoint(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial1(int i) {
            write(0x004B4D6C,i*100);
        }
        public override void setSpecial2(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            return mt.ReadInteger(0x004B4D6C)/100;
        }
        public override int getSpecial2() {
            throw new NotImplementedException();
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }
        public override void setIPlayer(int i) {
            write(0x00425FFF,i*100);
        }
        public override void setIPlayerFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setIBomb(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x00426009,new byte[] { 0xE9,0x24,0xFE,0xFF,0xFF,0x90 });
            write(0x00425E32,new byte[] { 0xC7,0x05,0x70,0x4D,0x4B,0x00,b[0],b[1],b[2],b[3],0xEB,0x89 });
            write(0x00425DC7,new byte[] { 0xE9,0x43,0x02,0x00,0x00 });
        }
        public override void setIBombFragment(int i) {
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
            write(0x00425F08,i*100);
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
