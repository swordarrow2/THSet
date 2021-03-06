﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH128Code:THCode {
        MemoryTool mt;
        int lastStatu = 1;
        int thisStatu = 1;
        public override void CheckNeedBomb() {
            thisStatu=mt.ReadInteger(mt.ReadInteger(0x004B8A80)+0xF78);
            if(lastStatu!=4&&thisStatu==4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),0,0);
            } else if(lastStatu==4&&thisStatu!=4) {
                mt.clickKey(Keys.X,mt.virtualKey((byte)'X',0),2,0);
            }
            lastStatu=thisStatu;
        }
        public TH128Code(MemoryTool m) => mt=m;
        public override void SetStage(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) { }
        public override void SetChapter(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) { }
        public override void SetMBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) { }
        public override void SetBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss) { }
        public override string GetTitle() => new Random().Next()%2==0 ? "1+1=9" : "妖精大战争";
        public override string[] GetSpecialTip() => new string[] { "蓄力","","" };
        public override string GetAboutBug() => "终符若同时击破了两只妖精，则卡关……无解\n“满身疮痍”界面直接重新开始会导致录像爆炸，应返回主界面重新开始，若没有疮痍，则可以放心使用ESC+R\n难度\\路线选择界面如果按键频率过高可能会出现选择不正确的情况";
        public override string GetAboutSpecial() => "";
        public override string[] GetDefaultValue() => new string[] { "0","0","0" };
        public override void StartCount() {
            //miss
            write(0x0043D0CF,new byte[] { 0xEB,0xE0 });                                       //jmp 0043D0B1
            write(0x0043D0B1,new byte[] { 0xC7,0x80,0x78,0x0F,0x00,0x00,0x04,0x00,0x00,0x00,  //mov [eax+00000F78],00000004
                                          0xEB,0x14 });                                       //jmp 0043D0D1
            write(0x0043D0D1,new byte[] { 0xFF,0x05,0xAC,0x51,0x4B,0x00,0x90,0x90 });         //inc [004B51AC]
            write(0x004B51AC,0);
            //bomb
            write(0x0043B7DB,new byte[] { 0xE9,0x32,0xFE,0xFF,0xFF });      //jmp 0043B612
            write(0x0043B612,new byte[] { 0xE8,0xE9,0xBC,0xFE,0xFF,         //call 00427300
                                          0xFF,0x05,0xB0,0x51,0x4B,0x00,    //inc [004B51B0]
                                          0xEB,0x17 });                     //jmp 0043B636
            write(0x0043B636,new byte[] { 0xE9,0xA5,0x01,0x00,0x00 });      //jmp 0043B7E0
            write(0x004B51B0,0);
        }
        public override int GetMissCount() => mt.ReadInteger(0x004B51AC);
        public override int GetBombCount() => mt.ReadInteger(0x004B51B0);
        public override int GetBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004B8930)+0x5C);
        public override int GetBossLife() => mt.ReadInteger(mt.ReadInteger(0x004B8950)+0x5910);
        public override void KillSelf() => write(mt.ReadInteger(0x004B8A80)+0xF78,4);
        public override bool[] GetEnable() => new bool[24] { true,false,true,false,true,false,false,
                                                             true,false,true,false,true,false,false,
                                                             true,true,true,true,true,true,true,true,false,true };
        public override void SetLockPlayer(bool b) => write(0x0042729C,HexCodeHelper.getValueArray(new byte[] { 0x89,0x0D,0x64,0x4D,0x4B,0x00 },b));//mov [004B4D64],ecx
        public override void SetLockBomb(bool b) => write(0x0043B7C1,HexCodeHelper.getValueArray(new byte[] { 0x7C,0x30 },b)); //jl 0043B7F3
        public override void SetUnbeatable(bool b) => write(0x0043D0CF,HexCodeHelper.getValueArray(new byte[] { 0xC7,0x80,0x78,0x0F,0x00,0x00,0x04,0x00,0x00,0x00 },b));//mov [eax+00000F78],00000004
        public override void SetFPS(int i) {
            write(0x00455158,BitConverter.GetBytes((double)1/i));
            write(0x00454C48,new byte[] { 0xDD,0x05,0x58,0x51,0x45,0x00 });//fld qword ptr [00455158]
        }
        public override void SetPlayer(int i) => write(0x004B4D64,i*100);
        public override void SetPlayerFragment(int i) { }
        public override void SetBomb(int i) => write(0x004B4D70,i*100);
        public override void SetBombFragment(int i) { }
        public override void SetPower(int i) => write(0x004B4D60,BitConverter.GetBytes((float)i));
        public override void SetScore(int i) { }
        public override void SetMaxPoint(int i) { }
        public override void SetSpecial1(int i) => write(0x004B4D6C,i*100);
        public override void SetSpecial2(int i) { }
        public override void SetSpecial3(int i) { }
        public override void SetSpecial4(int i) { }
        public override int GetSpecial1() => mt.ReadInteger(0x004B4D6C)/100;
        public override int GetSpecial2() { return 0; }
        public override int GetSpecial3() { return 0; }
        public override int GetSpecial4() { return 0; }
        public override void SetIPlayer(int i) => write(0x00425FFF,i*100);
        public override void SetIPlayerFragment(int i) { }
        public override void SetIBomb(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x00426009,new byte[] { 0xE9,0x24,0xFE,0xFF,0xFF,0x90 });                 //jmp 00425E32
            write(0x00425E32,new byte[] { 0xC7,0x05,0x70,0x4D,0x4B,0x00,b[0],b[1],b[2],b[3],//mov [004B4D70],b[]
                                          0xEB,0x89 });                                     //jmp 00425DC7
            write(0x00425DC7,new byte[] { 0xE9,0x43,0x02,0x00,0x00 });                      //jmp 0042600F
        }
        public override void SetIBombFragment(int i) { }
        public override void SetIPower(int i) {
            byte[] b = BitConverter.GetBytes((float)i);
            write(0x00425FEE,new byte[] { 0xE9,0x0E,0x09,0x00,0x00,0x90 });                     //jmp 00426901
            write(0x00426901,new byte[] { 0xC7,0x05,0x60,0x4D,0x4B,0x00,b[0],b[1],b[2],b[3] }); //jmp 0042600F
        }
        public override void SetIScore(int i) { }
        public override void SetIMaxPoint(int i) { }
        public override void SetISpecial1(int i) => write(0x00425F08,i*100);
        public override void SetISpecial2(int i) { }
        public override void SetISpecial3(int i) { }
        public override void SetISpecial4(int i) { }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
