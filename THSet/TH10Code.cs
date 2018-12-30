using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH10Code:THCode {
        MemoryTool mt;
        public TH10Code(MemoryTool m) => mt=m;
        public override void setStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override void setBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox) { }
        public override string getTitle() => new Random().Next()%2==0 ? "东方炸比录" : "东方神曲录";
        public override string getAboutBug() => "四面部分地点诱导失效,是因为屏幕外侧有打不到的敌人\n\n全关的replay如果直接从4面播放会导致录像爆炸，从3面开始播放即可避免\n\nreplay保存多次将会爆炸";
        public override string getAboutSpecial() => "信仰值初始为50000，最大值为999990";
        public override string[] getSpecialTip() => new string[] { "信仰值","","" };
        public override string[] getDefaultValue() => new string[] { "50000","0","0" };
        public override void StartCount() {
            //miss
            write(0x00426A1C,new byte[] { 0xE9,0xA2,0xE4,0xFF,0xFF,0x90 });            //jmp 00424EC3
            write(0x00424EC3,new byte[] { 0x89,0x0D,0x70,0x4C,0x47,0x00,               //mov [00474C70],ecx
                                          0xE9,0x47,0x01,0x00,0x00 });                 //jmp 00425015
            write(0x00425015,new byte[] { 0xFF,0x05,0xE0,0x50,0x47,0x00,               //inc [004750E0]
                                          0xE9,0x02,0x1A,0x00,0x00 });                 //jmp 00426A22
            write(0x004750E0,0);
            //决死
            write(0x00425C43,new byte[] { 0xE9,0x59,0xF2,0xFF,0xFF,0x90,0x90,0x90 });  //jmp 00424EA1
            write(0x00424EA1,new byte[] { 0x66,0x81,0x05,0x48,0x4C,0x47,0x00,0xEC,0xFF,//add word ptr [00474C48],FFEC
                                          0xEB,0x07 });                                //jmp 00424EB3
            write(0x00424EB3,new byte[] { 0xFF,0x05,0xE4,0x50,0x47,0x00,               //inc [004750E4]
                                          0xE9,0x8D,0x0D,0x00,0x00 });                 //jmp 00425C4B
            //主动
            write(0x004259D4,new byte[] { 0xE9,0x7A,0x0C,0x00,0x00,0x90,0x90,0x90 });  //jmp 00426653
            write(0x00426653,new byte[] { 0x66,0x81,0x05,0x48,0x4C,0x47,0x00,0xEC,0xFF,//add word ptr [00474C48],FFEC
                                          0xEB,0xA7 });                                //jmp 00426605
            write(0x00426605,new byte[] { 0xFF,0x05,0xE4,0x50,0x47,0x00,               //inc [004750E4]
                                          0xE9,0x3B,0xF6,0xFF,0xFF });                 //jmp 00425C4B
            write(0x004750E4,0);
        }
        public override int getMissCount() => mt.ReadInteger(0x004750E0);
        public override int getBombCount() => mt.ReadInteger(0x004750E4);
        public override int getBulletCount() => mt.ReadInteger(mt.ReadInteger(0x004776F0)+0x5C);
        public override int getBossLife() => mt.ReadInteger(mt.ReadInteger(0x0047770C)+0x9E8C);
        public override void killSelf() => write(mt.ReadInteger(0x00477834)+0x458,4);
        public override bool[] getEnable() => new bool[29] { true,false,false,false,true,true,false,true,false,false,
                                                             true,false,false,false,true,true,false,true,false,false,
                                                             true,true,true,
                                                             mt.ReadInteger(0x00439397)==107752 ? false : true,
                                                             true,true,true,true,false };

        public override void setLockPlayer(bool b) => write(0x00424EC3,g4EclCode.getValueArray(new byte[] { 0x89,0x0D,0x70,0x4C,0x47,0x00 },b));//mov [00474C70],ecx
        public override void setLockBomb(bool b) {
            byte[] by = new byte[] { 0x66,0x81,0x05,0x48,0x4C,0x47,0x00,0xEC,0xFF }; //add word ptr [00474C48],FFEC
            write(0x00424EA1,g4EclCode.getValueArray(by,b)); 
            write(0x00426653,g4EclCode.getValueArray(by,b)); 
        }
        public override void setUnbeatable(bool b) => write(0x00426CFF,g4EclCode.getValueArray(new byte[] { 0xC7,0x85,0x58,0x04,0x00,0x00,0x04,0x00,0x00,0x00 },b));//mov [ebp+00000458],00000004
        public override void setFPS(int i) => write(0x60018AB4,i);
        public override void setPlayer(int i) => write(0x00474C70,i);
        public override void setPlayerFragment(int i){ }
        public override void setBomb(int i){ }
        public override void setBombFragment(int i){ }
        public override void setPower(int i) => write(0x00474C48,i/5);
        public override void setScore(int i) => write(0x00474C44,i/10);
        public override void setMaxPoint(int i){ }
        public override void setSpecial1(int i) => write(0x00474C4C,i/10);
        public override void setSpecial2(int i){ }
        public override void setSpecial3(int i){ }
        public override int getSpecial1() => mt.ReadInteger(0x00474C4C)*10;
        public override int getSpecial2(){ return 0; }
        public override int getSpecial3(){ return 0; }
        public override void setIPlayer(int i) {
            byte b = BitConverter.GetBytes(i)[0];
            byte[] by = new byte[] { 0xC7,0x05,0x70,0x4C,0x47,0x00,b };//mov[00474C70],b
            write(0x0041794F,by); 
            write(0x00417964,by);
        }
        public override void setIPlayerFragment(int i){ }
        public override void setIBomb(int i){ }
        public override void setIBombFragment(int i){ }
        public override void setIPower(int i) {
            byte[] b = BitConverter.GetBytes(i/5);
            write(0x0041798C,new byte[] { 0xE9,0xF5,0xE0,0x04,0x00,0x90 });                 //jmp 00465A86
            write(0x00465A86,new byte[] { 0xC7,0x05,0x48,0x4C,0x47,0x00,b[0],b[1],b[2],b[3],//mov [00474C48],b[]
                                          0xE9,0xFD,0x1E,0xFB,0xFF });                      //jmp 00417992
        }
        public override void setIScore(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            int gettedPlayer = 0;
            if(i<20000000) { gettedPlayer=0; } else
            if(i>=20000000&&i<40000000) { gettedPlayer=1; } else
            if(i>=40000000&&i<80000000) { gettedPlayer=2; } else
            if(i>=40000000&&i<150000000) { gettedPlayer=3; } else { gettedPlayer=4; }
            byte[] c = BitConverter.GetBytes(gettedPlayer);
            write(0x0041793B,new byte[] { 0xE9,0x67,0xE1,0x04,0x00,0x90 });                 //jmp 00465AA7
            write(0x00465AA7,new byte[] { 0xC7,0x05,0x44,0x4C,0x47,0x00,b[0],b[1],b[2],b[3],//mov [00474C44],b[]
                                          0xC7,0x05,0x9C,0x4C,0x47,0x00,c[0],c[1],c[2],c[3],//mov [00474C9C],c[]
                                          0xE9,0x81,0x1E,0xFB,0xFF });                      //jmp 00417941
            write(0x004179D5,g4EclCode.getNop(6));
        }
        public override void setIMaxPoint(int i){ }
        public override void setISpecial1(int i) {
            byte[] b = BitConverter.GetBytes(i/10);
            write(0x00418B93,new byte[] { 0xE9,0xFD,0xCE,0x04,0x00,0x90 });                 //jmp 00465A95
            write(0x00465A95,new byte[] { 0xC7,0x05,0x4C,0x4C,0x47,0x00,b[0],b[1],b[2],b[3],//mov [00474C4C],b[]
                                          0x8B,0x41,0x24,                                   //mov eax,[ecx+24]
                                          0xE9,0xF2,0x30,0xFB,0xFF });                      //jmp 00418B99
        }
        public override void setISpecial2(int i){ }
        public override void setISpecial3(int i){ }
        private int write(int addr,int value) => mt.WriteInteger(addr,value);
        private int write(int addr,byte[] value) => mt.WriteBytes(addr,value);
    }
}
