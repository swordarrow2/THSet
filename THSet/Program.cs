using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace THSet {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            int getPID(string exeName) {
                try {
                    return Process.GetProcessesByName(exeName)[0].Id;
                } catch {
                    return 0;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(getPID("th09")!=0||getPID("th09c")!=0) {
                Application.Run(new TH09Form());
            } else {
                Application.Run(new MainForm());
            }

        }

    }
}
