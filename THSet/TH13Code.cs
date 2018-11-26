﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH13Code:THCode {
        MemoryTool mt;
        string gameTitle = "东方神灵庙";
        public override string getTitle() {
            return gameTitle;
        }
        public override string getSpecialTip() {
            return "1:灵界槽(0-600) 2:已获得的奖残个数(0-6)";
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
            write(0x0042D3FB,new byte[] { 0xE9,0xD1,0x01,0x00,0x00,0x90,0x90,0x90,0x90 });
            write(0x0042D5D1,new byte[] { 0xC7,0x05,0x04,0xE8,0x4B,0x00,0x00,0x00,0x00,0x00,0xE9,0xDC,0xFE,0xFF,0xFF });
            write(0x0042D4BC,new byte[] { 0xC7,0x46,0x44,0x00,0x00,0x00,0x00,0x90,0xC7,0x46,0x40,0x00,0x00,0x00,0x00,0xE9,0x34,0xFF,0xFF,0xFF });

        }
        public override bool[] getEnable() {
            return new bool[13] { true,true,true,true,true,true,true,true,true,true,true,true,false };
        }
        public override void setLockPlayer(bool b) {
            write(0x00444A52,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90} :
                                 new byte[] { 0xFF,0x0D,0xF4,0xE7,0x4B,0x00 });
        }
        public override void setLockBomb(bool b) {
            write(0x0040A404,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0x00,0xE8,0x4B,0x00 });
        }
        public override void setUnbeatable(bool b) {
            write(0x00444D75,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xC7,0x87,0x5C,0x06,0x00,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setPlayer(int i) {
            write(0x004BE7F4,i);
        }
        public override void setPlayerFragment(int i) {
            write(0x004BE7F8,i);
        }
        public override void setBomb(int i) {
            write(0x004BE800,i);
        }
        public override void setBombFragment(int i) {
            write(0x004BE804,i);
        }
        public override void setPower(int i) {
            write(0x004BE7E8,i);
        }
        public override void setScore(int i) {
            write(0x004BE7C0,i/10);
        }
        public override void setMaxPoint(int i) {
            write(0x004BE7DC,i*100);
        }
        public override void setSpecial1(int i) {
            write(0x004BE808,i);
        }
        public override void setSpecial2(int i) {
            write(0x004BE7FC,i);
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            return mt.ReadInteger(0x004BE808);
        }
        public override int getSpecial2() {
            return mt.ReadInteger(0x004BE7FC);
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }
        public override void setIPlayer(byte b) {
            write(0x0042BC18,b);
            write(0x0042BC2D,b);
        }
        public override void setIPlayerFragment(byte b) {
            write(0x0042D4C7,b);
        }
        public override void setIBomb(byte b) {
            write(0x0042D3DA,b);
        }
        public override void setIBombFragment(byte b) {
            write(0x0042D5D7,b);
        }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042BC69,new byte[] { 0x90,0x90,0x90,0x90,0x90 });
            write(0x0042BC87,new byte[] { 0x90,0x90,0x90,0x90,0x90 });
            write(0x0042D3CD,new byte[] { 0xEB,0xB5,0x90 });
            write(0x0042D384,new byte[] { 0xC7,0x46,0x30,b[0],b[1],b[2],b[3],0xEB,0x43 });
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x0042BB65,new byte[] { 0xE9,0x98,0xFC,0xFF,0xFF,0x90 });
            write(0x0042B802,new byte[] { 0xC7,0x05,0xC0,0xE7,0x4B,0x00,b[0],b[1],b[2],b[3],0xEB,0x14 });
            write(0x0042B822,new byte[] { 0xE9,0x44,0x03,0x00,0x00 });
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x0042BB76,new byte[] { 0xB8,b[0],b[1],b[2],b[3] });
            write(0x0042BB7B,new byte[] { 0xEB,0x03,0x90,0x90,0x90 });
        }
        public override void setISpecial1(int i) {
            write(0x0042D407,i);
        }
        public override void setISpecial2(int i) {
            write(0x0042D4BF,i);
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