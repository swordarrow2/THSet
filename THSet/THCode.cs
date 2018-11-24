using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public abstract class THCode {
        public abstract string getName();
        public abstract string getSpecialTip();

        public abstract bool[] getEnable();

        public abstract int getPlayerAddress();
        public abstract int getPlayerFragmentAddress();
        public abstract int getPlayerCodeAddress();
        public abstract byte[] getLockPlayerCode0();
        public abstract byte[] getLockPlayerCode1();

        public abstract int getBombAddress();
        public abstract int getBombFragmentAddress();
        public abstract int getBombCodeAddress();
        public abstract byte[] getLockBombCode0();
        public abstract byte[] getLockBombCode1();

        public abstract int getPowerAddress();

        public abstract int[] getSpecialAddress();


        public abstract int getIPlayerAddress();
        public abstract byte[] getIPlayerCode();
        public abstract int getIPlayerFragmentAddress();
        public abstract byte[] getIPlayerFragmentCode();
        public abstract int getIBombAddress();
        public abstract byte[] getIBombCode();
        public abstract int getIBombFragmentAddress();
        public abstract byte[] getIBombFragmentCode();

        public abstract int getIPowerAddress();
        public abstract byte[] getIPowerCode();

        public abstract int[] getISpecialAddress();
        public abstract byte[][] getISpecialCode();
    }
}
