using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class MemoryTool {

        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr Handle,long Address,byte[] buffer,int Size,int BytesWritten = 0);
        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr Handle,long Address,byte[] buffer,int Size,int BytesRead = 0);
        [DllImport("user32.dll",EntryPoint = "keybd_event",SetLastError = true)]
        public static extern void keybd_event(Keys bVk,byte bScan,uint dwFlags,uint dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern byte MapVirtualKey(byte wCode,int wMap);       
        
        Process pro;

        public MemoryTool(Process p) => pro=p;
        public IntPtr GetProcessHandle() {
            return pro.Handle;
        }

        public int WriteBytes(long Address,byte[] Bytes) => WriteProcessMemory(GetProcessHandle(),Address,Bytes,Bytes.Length);
        public int WriteInteger(long Address,int Value) => WriteProcessMemory(GetProcessHandle(),Address,BitConverter.GetBytes(Value),4);
        public int ReadInteger(long Address) {
            byte[] Buffer = new byte[4];
            ReadProcessMemory(GetProcessHandle(),Address,Buffer,4);
            return BitConverter.ToInt32(Buffer,0);
        }
        public double ReadFloat(long Address) {
            byte[] Buffer = new byte[4];
            ReadProcessMemory(GetProcessHandle(),Address,Buffer,4);
            return BitConverter.ToSingle(Buffer,0);
        }
        public byte[] ReadBytes(long Address,int length) {
            byte[] Buffer = new byte[length];
            ReadProcessMemory(GetProcessHandle(),Address,Buffer,length);
            return Buffer;
        }
        public void clickKey(Keys bVk,byte bScan,uint dwFlags,uint dwExtraInfo) {
            keybd_event(bVk,bScan,dwFlags,dwExtraInfo);
        }
        public byte virtualKey(byte wCode,int wMap) {
            return MapVirtualKey(wCode,wMap);
        }
    }
}
