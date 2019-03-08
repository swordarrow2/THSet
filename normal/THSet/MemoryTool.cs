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

        public int WriteBytes(long Address,byte[] Bytes) {
            return WriteProcessMemory(GetProcessHandle(),Address,Bytes,Bytes.Length);
        }

        public int WriteBytes(long baseAddress,int offset,byte[] Bytes) {
            return WriteBytes(ReadInteger(baseAddress)+offset,Bytes);
        }

        public int WriteInteger(long Address,int Value) {
            return WriteProcessMemory(GetProcessHandle(),Address,BitConverter.GetBytes(Value),4);
        }

        public int WriteInteger(long baseAddress,int offset,int Value) {
            return WriteInteger(ReadInteger(baseAddress)+offset,Value);
        }

        public int ReadInteger(long Address) {
            byte[] Buffer = new byte[4];
            ReadProcessMemory(GetProcessHandle(),Address,Buffer,4);
            return BitConverter.ToInt32(Buffer,0);
        }

        public int ReadInteger(long baseAddress,int offset) {
            return ReadInteger(ReadInteger(baseAddress)+offset);
        }

        public float ReadFloat(long Address) {
            byte[] Buffer = new byte[4];
            ReadProcessMemory(GetProcessHandle(),Address,Buffer,4);
            return BitConverter.ToSingle(Buffer,0);
        }

        public float ReadFloat(long baseAddress,int offset) {
            return ReadFloat(ReadInteger(baseAddress)+offset);
        }

        public byte[] ReadBytes(long Address,int length) {
            byte[] Buffer = new byte[length];
            ReadProcessMemory(GetProcessHandle(),Address,Buffer,length);
            return Buffer;
        }

        public byte[] ReadBytes(long baseAddress,int offset,int length) {
            return ReadBytes(ReadInteger(baseAddress)+offset,length);
        }

        public void clickKey(Keys bVk,byte bScan,uint dwFlags,uint dwExtraInfo) {
            keybd_event(bVk,bScan,dwFlags,dwExtraInfo);
        }

        public byte virtualKey(byte wCode,int wMap) {
            return MapVirtualKey(wCode,wMap);
        }
    }
}
