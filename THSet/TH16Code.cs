using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public class TH16Code:THCode {
        public override string getName() {
            return "TH16";
        }
        public override int getPlayerAddress() {
            return 0x004A57F4;
        }
        public override int getPlayerFragmentAddress() {
            return 0;
        }
        public override int getPlayerCodeAddress() {
            return 0x00443D3A;
        }
        public override byte[] getLockPlayerCode0() {
            return new byte[] { 0xA3,0xF4,0x57,0x4A,0x00 };
        }
        public override byte[] getLockPlayerCode1() {
            return new byte[] { 0x90,0x90,0x90,0x90,0x90 };
        }
        public override int getBombAddress() {
            return 0x004A5800;
        }
        public override int getBombFragmentAddress() {
            return 0x004A5804;
        }
        public override int getBombCodeAddress() {
            return 0x0040DB9C;
        }
        public override byte[] getLockBombCode0() {
            return new byte[] { 0xA3,0x00,0x58,0x4A,0x00 };
        }
        public override byte[] getLockBombCode1() {
            return new byte[] { 0x90,0x90,0x90,0x90,0x90 };
        }
        public override int getPowerAddress() {
            return 0x004A57E4;
        }
        public override int[] getSpecialAddress() {
            return new int[] { 0x004A5808 };
        }
    }
}
