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
        public abstract void SetStage(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox);
        public abstract void SetChapter(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox);
        public abstract void SetMBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox);
        public abstract void SetBossNum(ComboBox stageBox,ComboBox chapterBox,ComboBox MBossBox,ComboBox bossBox);
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
        public abstract int GetSpecial1();
        public abstract int GetSpecial2();
        public abstract int GetSpecial3();


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

        public bool EnableSetIPlayer => GetEnable()[0];
        public bool EnableSetIPlayerFragment => GetEnable()[1];
        public bool EnableSetIBomb => GetEnable()[2];
        public bool EnableSetIBombFragment => GetEnable()[3];
        public bool EnableSetIPower => GetEnable()[4];
        public bool EnableSetIScore => GetEnable()[5];
        public bool EnableSetIMaxPoint => GetEnable()[6];
        public bool EnableSetISpecial1 => GetEnable()[7];
        public bool EnableSetISpecial2 => GetEnable()[8];
        public bool EnableSetISpecial3 => GetEnable()[9];

        public bool EnableSetPlayer => GetEnable()[10];
        public bool EnableSetPlayerFragment => GetEnable()[11];
        public bool EnableSetBomb => GetEnable()[12];
        public bool EnableSetBombFragment => GetEnable()[13];
        public bool EnableSetPower => GetEnable()[14];
        public bool EnableSetScore => GetEnable()[15];
        public bool EnableSetMaxPoint => GetEnable()[16];
        public bool EnableSetSpecial1 => GetEnable()[17];
        public bool EnableSetSpecial2 => GetEnable()[18];
        public bool EnableSetSpecial3 => GetEnable()[19];

        public bool EnableSetLockPlayer => GetEnable()[20];
        public bool EnableSetLockBomb => GetEnable()[21];
        public bool EnableSetUnbeatable => GetEnable()[22];
        public bool EnableSetFPS => GetEnable()[23];
        public bool EnableSourceCount => GetEnable()[24];
        public bool EnableBossHPInfo => GetEnable()[25];
        public bool EnableShowBulletCount => GetEnable()[26];
        public bool EnableKillSelf => GetEnable()[27];
        public bool EnableChapterPrictice => GetEnable()[28];
        public bool EnableAutoBomb => GetEnable()[29];

    }
}
