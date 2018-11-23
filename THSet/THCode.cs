using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public abstract class THCode {
        public abstract string getName();

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
    }
}
