using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public class TH16Code:THCode {
        MemoryTool mt;
        string gameTitle = "东方CBC";
        public override string getTitle() {
            if((new Random().Next())%2==0) { return "东方CBC"; }
            return "东方Bug璋";
        }
        public override string getAboutBug() {
            return "太多了，我就不写了……";
        }
        public override void setTitle(string s) {
            gameTitle=s;
        }
        public override string getAboutSpecial() {
            return "季节槽范围为0-1140";
        }
        public override string[] getSpecialTip() {
            return new string[] { "季节槽","","" };
        }
        public override string[] getDefaultValue() {
            return new string[] { "0","0","0" };
        }
        public override void setMemoryTool(MemoryTool m) {
            mt=m;
        }
        public override bool[] getEnable() {
            return new bool[13] { true,true,true,true,false,true,true,true,true,true,true,false,false };
        }
        public override void setLockPlayer(bool b) {
            write(0x00443D3A,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0xF4,0x57,0x4A,0x00 });
        }
        public override void setLockBomb(bool b) {
            write(0x0040DB9C,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90 } :
                                 new byte[] { 0xA3,0x00,0x58,0x4A,0x00 });
        }
        public override void setUnbeatable(bool b) {
            write(0x00443FDB,b ? new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90 } :
                                new byte[] { 0xC7,0x87,0xA8,0x65,0x01,0x00,0x04,0x00,0x00,0x00 });
        }
        public override void setFPS(int i) {
            throw new NotImplementedException();
        }
        public override void setPlayer(int i) {
            write(0x004A57F4,i);
        }
        public override void setPlayerFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setBomb(int i) {
            write(0x004A5800,i);
        }
        public override void setBombFragment(int i) {
            write(0x004A5804,i);
        }
        public override void setPower(int i) {
            write(0x004A57E4,i);
        }
        public override void setScore(int i) {
            write(0x004A57B0,i/10);
        }
        public override void setMaxPoint(int i) {
            write(0x004A57D8,i*100);
        }
        public override void setSpecial1(int i) {
            write(0x004A5808,i);
        }
        public override void setSpecial2(int i) {
            throw new NotImplementedException();
        }
        public override void setSpecial3(int i) {
            throw new NotImplementedException();
        }
        public override int getSpecial1() {
            return mt.ReadInteger(0x004A5808);
        }
        public override int getSpecial2() {
            throw new NotImplementedException();
        }
        public override int getSpecial3() {
            throw new NotImplementedException();
        }
        public override void setIPlayer(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            write(0x0042CDEE,new byte[] { 0xC7,0x05,0xF4,0x57,0x4A,0x00 },b);   //story
            write(0x0042CE03,new byte[] { 0xC7,0x05,0xF4,0x57,0x4A,0x00 },b);   //practice
            //spell practice no need
        }
        public override void setIPlayerFragment(int i) {
            throw new NotImplementedException();
        }
        public override void setIBomb(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            //story and practice,spell practice no need
            write(0x0042E5AE,new byte[] { 0xC7,0x46,0x70 },b);
        }
        public override void setIBombFragment(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            //story and practice,spell practice no need
            write(0x0042E5CC,new byte[] { 0xC7,0x46,0x74 },b);
        }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042E5A0,new byte[] { 0xC7,0x46,0x54,b[0],b[1],b[2],b[3] });

            //Stop to set default values
            write(0x0042CE91,new byte[] { 0x90,0x90,0x90,0x90,0x90,0x90 });       //story
            write(0x0042CEEC,new byte[] { 0x90,0x90,0x90,0x90,0x90 });            //practice
            write(0x0042CEBC,new byte[] { 0x90,0x90,0x90,0x90,0x90 });            //extra
            write(0x0042CE51,new byte[] { 0x90,0x90,0x90,0x90,0x90 });            //spell practice
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x0042CD38,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x89,0x0D,0xB0,0x57,0x4A,
                0x00,0xB9,0x00,0x00,0x00,0x00,0x89,0x0D,0xC0,0x57,0x4A,0x00,0x90,0x90,0x90 });
        }
        public override void setIMaxPoint(int i) {
            byte[] b = BitConverter.GetBytes(i*100);
            write(0x0042CD66,new byte[] { 0xB9,b[0],b[1],b[2],b[3],0x90,0x90,0x90 });
        }
        public override void setISpecial1(int i) {
            byte[] b = BitConverter.GetBytes(i);
            write(0x0042CEC6,new byte[] { 0xC7,0x05,0x08,0x58,0x4A,0x00,b[0],b[1],b[2],b[3] });                  //story
            write(0x0042CEF8,new byte[] { 0xC7,0x05,0x08,0x58,0x4A,0x00,b[0],b[1],b[2],b[3],0x90 });   //practice
            write(0x0042CE5B,new byte[] { 0xC7,0x05,0x08,0x58,0x4A,0x00,b[0],b[1],b[2],b[3] });                  //spell practice
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
