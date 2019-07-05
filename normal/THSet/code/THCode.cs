using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public abstract class THCode {
        public abstract string GetTitle();
        public abstract string[] GetSpecialTip();
        public abstract string GetAboutBug();
        public abstract string GetAboutSpecial();
        public abstract string[] GetDefaultValue();
        public abstract void SetStage(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss);
        public abstract void SetChapter(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss);
        public abstract void SetMBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss);
        public abstract void SetBossNum(MaterialListView stage,MaterialListView chapter,MaterialListView mBoss,MaterialListView boss);
        public abstract void StartCount();
        public abstract int GetMissCount();
        public abstract int GetBombCount();
        public abstract int GetBulletCount();
        public abstract int GetBossLife();
        public abstract void KillSelf();
        public abstract void CheckNeedBomb();

        public abstract bool[] GetEnable();

        public abstract void SetLockPlayer(bool b);
        public abstract void SetLockBomb(bool b);
        public abstract void SetUnbeatable(bool b);
        public abstract void SetFPS(int i);

        public abstract void SetPlayer(int i);
        public abstract void SetPlayerFragment(int i);

        public abstract void SetBomb(int i);
        public abstract void SetBombFragment(int i);

        public abstract void SetPower(int i);

        public abstract void SetScore(int i);
        public abstract void SetMaxPoint(int i);

        public abstract void SetSpecial1(int i);
        public abstract void SetSpecial2(int i);
        public abstract void SetSpecial3(int i);
        public abstract void SetSpecial4(int i);
        public abstract int GetSpecial1();
        public abstract int GetSpecial2();
        public abstract int GetSpecial3();
        public abstract int GetSpecial4();


        public abstract void SetIPlayer(int i);
        public abstract void SetIPlayerFragment(int i);
        public abstract void SetIBomb(int i);
        public abstract void SetIBombFragment(int i);

        public abstract void SetIPower(int i);

        public abstract void SetIScore(int i);
        public abstract void SetIMaxPoint(int i);

        public abstract void SetISpecial1(int i);
        public abstract void SetISpecial2(int i);
        public abstract void SetISpecial3(int i);
        public abstract void SetISpecial4(int i);

        public bool EnableSetIPlayer => GetEnable()[0];
        public bool EnableSetIPlayerFragment => GetEnable()[1];
        public bool EnableSetIBomb => GetEnable()[2];
        public bool EnableSetIBombFragment => GetEnable()[3];
        public bool EnableSetIPower => GetEnable()[4];
        public bool EnableSetIScore => GetEnable()[5];
        public bool EnableSetIMaxPoint => GetEnable()[6];

        public bool EnableSetPlayer => GetEnable()[7];
        public bool EnableSetPlayerFragment => GetEnable()[8];
        public bool EnableSetBomb => GetEnable()[9];
        public bool EnableSetBombFragment => GetEnable()[10];
        public bool EnableSetPower => GetEnable()[11];
        public bool EnableSetScore => GetEnable()[12];
        public bool EnableSetMaxPoint => GetEnable()[13];

        public bool EnableSetLockPlayer => GetEnable()[14];
        public bool EnableSetLockBomb => GetEnable()[15];
        public bool EnableSetUnbeatable => GetEnable()[16];
        public bool EnableSetFPS => GetEnable()[17];
        public bool EnableSourceCount => GetEnable()[18];
        public bool EnableBossHPInfo => GetEnable()[19];
        public bool EnableShowBulletCount => GetEnable()[20];
        public bool EnableKillSelf => GetEnable()[21];
        public bool EnableChapterPractice => GetEnable()[22];
        public bool EnableAutoBomb => GetEnable()[23];

    }
}
