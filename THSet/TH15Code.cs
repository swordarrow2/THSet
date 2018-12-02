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
        public override string getAboutBug() {
            return "boss符卡宣言时扔雷会导致boss保持无敌状态，bomb结束(铃仙为撞掉一层盾)时解除无敌\n\n无敌状态进入Extra8非时boss也会无敌且无法解除\n\n无欠模式纯符击破撞重开时弹幕处于减速状态且boss无敌，需重启游戏再打此章节";
        }
        public override string getAboutSpecial() {
            return "没啥好说的，使劲擦弹就得了（";
        }
        public override string[] getSpecialTip() {
            return new string[] { "","","" };
        }
        public override string[] getDefaultValue() {
            return new string[] { "0","0","0" };
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override bool[] getEnable() {
            return new bool[] { true,true,true,true,true,true,true,true,false,true,false,false,false};
        }
        public override void setLockPlayer(bool b) {
            write(0x00456398,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0x50,0x74,0x4E,0x00 });
        }
        public override void setLockBomb(bool b) {
            write(0x0041797A,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0x5C,0x74,0x4E,0x00 });
        }
        public override void setUnbeatable(bool b) {
            write(0x0045669F,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xC7,0x87,0x20,0x62,0x01,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setPlayer(int i) {
            write(0x004E7450,i);
        }
        public override void setPlayerFragment(int i) {
            write(0x004E7454,i);
        }
        public override void setBomb(int i) {
            write(0x004E745C,i);
        }
        public override void setBombFragment(int i) {
            write(0x004E7460,i);
        }
        public override void setPower(int i) {
            write(0x004E7440,i);
        }
        public override void setScore(int i) {
            write(0x004E740C,i/10);
        }
        public override void setMaxPoint(int i) {
            write(0x004E7434,i*100);
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
        public override void setIPlayer(int i) {
            write(0x0043C2B3,i);
            write(0x0043C2C8,i);
        }
        public override void setIPlayerFragment(int i) {
            write(0x0043E716,i);
        }
        public override void setIBomb(int i) {
            write(0x0043E6F1,i);
        }
        public override void setIBombFragment(int i) {
            write(0x0043E70F,i);
        }
        public override void setIPower(int i) {
            write(0x0043C32B,new byte[] { 0x90,0x90,0x90,0x90,0x90 });
            write(0x0043C383,new byte[] { 0x90,0x90,0x90,0x90,0x90 });
            write(0x0043E6E3,i);
        }
        public override void setIScore(int i) {
            throw new NotImplementedException();
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x0043C225,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90,0x90 });

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
