﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    class TH14Code:THCode {
        MemoryTool mt;
        string gameTitle = "东方1.6";
        public override string getTitle() {
            if((new Random().Next())%2==0) { return gameTitle; }
            return "东方掉帧城";
        }
        public override string getAboutBug() {
            return "有时候播放replay出错，如果replay文件没问题，可重启游戏再播放此处\n\n魔理沙激光可能会歪，其中一部分会导致播放录像时出错而另一部分不会(录像中的激光也是歪的)";
        }
        public override string getAboutSpecial() {
            return "非2.0为收点系统中获得的非Bonus2.0奖励的次数，已得奖残在辉针城似乎用处不大，2un仅仅设置了可获得的上限";
        }
        public override string[] getSpecialTip() {
            return new string[] { "非2.0","已得奖残","" };
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
        public override void StartCount() {
            //miss
            write(0x0044F618,new byte[] { 0xEB,0xB7,0x90,0x90,0x90 });    //jmp 0044F5D1
            write(0x0044F5D1,new byte[] { 0xA3,0x64,0x58,0x4F,0x00,       //mov [004F5864],eax
                                          0xFF,0x05,0xC0,0x59,0x4F,0x00,  //inc [004F59C0]
                                          0xEB,0x3F });                   //jmp 0044F61D
            write(0x004F59C0,0);
            //bomb
            write(0x0041218A,new byte[] { 0xE9,0x76,0xFF,0xFF,0xFF });    //jmp 00412105
            write(0x00412105,new byte[] { 0xFF,0x05,0xC4,0x59,0x4F,0x00,  //inc [004F59C4]
                                          0xEB,0xE8,0x00,0x00,0x00 });    //jmp 004120F5
            write(0x004120F5,new byte[] { 0xA3,0x70,0x58,0x4F,0x00,       //mov [004F5870],eax
                                          0xE9,0x90,0x00,0x00,0x00 });    //jmp 0041218F
            write(0x004F59C4,0);
        }
        public override int getMissCount() {
            return mt.ReadInteger(0x004F59C0);
        }
        public override int getBombCount() {
            return mt.ReadInteger(0x004F59C4);
        }
        public override bool[] getEnable() {
            return new bool[] { true,true,true,true,true,true,true,true,true,true,true,true,false,true,true };
        }
        public override void setLockPlayer(bool b) {
            write(0x0044F5D1,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } ://nop
                                 new byte[] { 0xA3,0x64,0x58,0x4F,0x00 });//mov [004F5864],eax
        }
        public override void setLockBomb(bool b) {
            write(0x004120F5,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } ://nop
                                 new byte[] { 0xA3,0x70,0x58,0x4F,0x00 });//mov [004F5870],eax
        }
        public override void setUnbeatable(bool b) {
            write(0x0044F871,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } ://nop
                                 new byte[] { 0xC7,0x87,0x84,0x06,0x00,0x00,0x04,0x00,0x00,0x00 });//mov [edi+00000684],00000004
        }
        public override void setFPS(int i) {
            mt.WriteBytes(0x0046A715,BitConverter.GetBytes((double)1/i));
            mt.WriteBytes(0x0046A78E,new byte[] { 0xF2,0x0F,0x10,0x15,0x15,0xA7,0x46,0x00 });//movsd xmm2,[0046A715]
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
        public override void setIPlayer(int i) {
            write(0x00435D42,i);
            write(0x00435D57,i);
        }
        public override void setIPlayerFragment(int i) {
            write(0x004375E4,i);
        }
        public override void setIBomb(int i) {
            write(0x004375C1,i);
        }
        public override void setIBombFragment(int i) {
            write(0x004375DD,i);
        }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00435DBA,new byte[] { 0x90,0x90,0x90,0x90,0x90 });                      //nop
            write(0x00435E12,new byte[] { 0x90,0x90,0x90,0x90,0x90 });                      //nop
            write(0x00435DE2,new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 });                 //nop
            write(0x00435D86,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90 });            //mov ecx,b[]
            write(0x004375B3,i);
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x00435C95,new byte[] { 0xE9,0xC9,0x10,0x00,0x00,0x90 });                 //jmp 00436D63
            write(0x00436D63,new byte[] { 0xC7,0x05,0x30,0x58,0x4F,0x00,b[0],b[1],b[2],b[3],//mov [004F5830],b[]
                                          0xEB,0x06 });                                     //jmp 00436D75
            write(0x00436D75,new byte[] { 0xE9,0x21,0xEF,0xFF,0xFF });                      //jmp 00435C9B
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x00435CB0,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90 });            //mov ecx,b[]
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


        private int write(int addr,int value) {
            return mt.WriteInteger(addr,value);
        }
        private int write(int addr,byte[] value) {
            return mt.WriteBytes(addr,value);
        }
        private int write(int addr,byte[] opCode,byte value2) {
            List<byte> tmp = opCode.ToList();
            tmp.Add(value2);
            return mt.WriteBytes(addr,tmp.ToArray());
        }
    }
}
