using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace THSet {
    public class MemoryTool {
        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr Handle,long Address,byte[] buffer,int Size,int BytesWritten = 0);
        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr Handle,long Address,byte[] buffer,int Size,int BytesRead = 0);

        public IntPtr pHandle;
        public string ExeName { get; set; }

        public MemoryTool(string exeName) {
            ExeName=exeName;
            pHandle=GetProcessHandle();
        }
        public IntPtr GetProcessHandle() {
            try {
                Process[] ProcList = Process.GetProcessesByName(ExeName);
                pHandle=ProcList[0].Handle;
                return pHandle;
            } catch {
                return IntPtr.Zero;
            }
        }

        public long GetPointerAddress(long Pointer,int[] Offset = null) {
            byte[] Buffer = new byte[8];
            ReadProcessMemory(GetProcessHandle(),Pointer,Buffer,Buffer.Length);
            if(Offset!=null) {
                for(int x = 0;x<(Offset.Length-1);x++) {
                    Pointer=BitConverter.ToInt64(Buffer,0)+Offset[x];
                    ReadProcessMemory(GetProcessHandle(),Pointer,Buffer,Buffer.Length);
                }
                Pointer=BitConverter.ToInt64(Buffer,0)+Offset[Offset.Length-1];
            }
            return Pointer;
        }

        public void WriteBytes(long Address,byte[] Bytes) {
            WriteProcessMemory(GetProcessHandle(),Address,Bytes,Bytes.Length);
        }
        public void WriteInteger(long Address,int Value) {
            WriteProcessMemory(GetProcessHandle(),Address,BitConverter.GetBytes(Value),4);
        }
        public int ReadInteger(long Address) {
            byte[] Buffer = new byte[4];
            ReadProcessMemory(GetProcessHandle(),Address,Buffer,4);
            return BitConverter.ToInt32(Buffer,0);
        }
    }
}
