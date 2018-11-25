using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public abstract class THCode {
        public abstract string getTitle();
        public abstract string getSpecialTip();
        public abstract void setTitle(string s);
        public abstract void setMemoryTool(MemoryTool m);

        public abstract bool[] getEnable();

        public abstract void setLockPlayer(bool b);
        public abstract void setLockBomb(bool b);
        public abstract void setChoice(bool b);

        public abstract void setPlayer(int i);
        public abstract void setPlayerFragment(int i);

        public abstract void setBomb(int i);
        public abstract void setBombFragment(int i);

        public abstract void setPower(int i);

        public abstract void setScore(int i);
        public abstract void setMaxPoint(int i);

        public abstract void setSpecial1(int i);
        public abstract void setSpecial2(int i);
        public abstract void setSpecial3(int i);
        public abstract int getSpecial1();
        public abstract int getSpecial2();
        public abstract int getSpecial3();


        public abstract void setIPlayer(byte b);
        public abstract void setIPlayerFragment(byte b);
        public abstract void setIBomb(byte b);
        public abstract void setIBombFragment(byte b);

        public abstract void setIPower(int b);

        public abstract void setIScore(int i);
        public abstract void setIMaxPoint(int i);

        public abstract void setISpecial1(int b);
        public abstract void setISpecial2(int b);
        public abstract void setISpecial3(int b);

    }
}
