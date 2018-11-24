using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THSet {
    public class THDataManager {

        public string name;
        public bool[] enable;
        public string specialTip;

        public int player;
        public int playerFragment;
        public int playerCode;
        public byte[] lockPlayerCode0;
        public byte[] lockPlayerCode1;

        public int bomb;
        public int bombFragment;
        public int bombCode;
        public byte[] lockBombCode0;
        public byte[] lockBombCode1;

        public int power;

        public int[] special;

        public int Iplayer;
        public byte[] IplayerCode;
        public int IplayerFragment;
        public byte[] IplayerFragmentCode;

        public int Ibomb;
        public byte[] IbombCode;
        public int IbombFragment;
        public byte[] IbombFragmentCode;

        public int Ipower;
        public byte[] IpowerCode;

        public int[] Ispecial;
        public byte[][] IspecialCode;

        public THDataManager(THCode t) {
            name=t.getName();
            enable=t.getEnable();
            specialTip=t.getSpecialTip();

            player=t.getPlayerAddress();
            playerFragment=t.getPlayerFragmentAddress();
            playerCode=t.getPlayerCodeAddress();
            lockPlayerCode0=t.getLockPlayerCode0();
            lockPlayerCode1=t.getLockPlayerCode1();

            bomb=t.getBombAddress();
            bombFragment=t.getBombFragmentAddress();
            bombCode=t.getBombCodeAddress();
            lockBombCode0=t.getLockBombCode0();
            lockBombCode1=t.getLockBombCode1();

            power=t.getPowerAddress();

            special=t.getSpecialAddress();

            Iplayer=t.getIPlayerAddress();
            IplayerCode=t.getIPlayerCode();
            IplayerFragment=t.getIPlayerFragmentAddress();
            IplayerFragmentCode=t.getIPlayerFragmentCode();

            Ibomb=t.getIBombAddress();
            IbombCode=t.getIBombCode();
            IbombFragment=t.getIBombFragmentAddress();
            IbombFragmentCode=t.getIBombFragmentCode();

            Ipower=t.getIPowerAddress();
            IpowerCode=t.getIPowerCode();

            Ispecial=t.getISpecialAddress();
            IspecialCode=t.getISpecialCode();
        }





    }
}
