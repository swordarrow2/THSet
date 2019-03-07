using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace THSet {
    class HexCodeHelper {
        /*    [DllImport("kernel32.dll",EntryPoint = "CloseHandle")]
            public static extern int CloseHandle(int hObject);

            [DllImport("kernel32.dll")]
            public static extern Int32 WriteProcessMemory(IntPtr hProcess,IntPtr lpBaseAddress,[In, Out] byte[] buffer,int size,out IntPtr lpNumberOfBytesWritten);

            [DllImport("kernel32.dll")]
            public static extern Int32 WriteProcessMemory(int hProcess,int lpBaseAddress,byte[] buffer,int size,int lpNumberOfBytesWritten);

            [DllImport("kernel32",EntryPoint = "CreateRemoteThread")]
            public static extern int CreateRemoteThread(int hProcess,int lpThreadAttributes,int dwStackSize,int lpStartAddress,int lpParameter,int dwCreationFlags,ref int lpThreadId);

            [DllImport("Kernel32.dll")]
            public static extern System.Int32 VirtualAllocEx(IntPtr hProcess,System.Int32 lpAddress,System.Int32 dwSize,System.Int16 flAllocationType,System.Int16 flProtect);

            [DllImport("Kernel32.dll")]
            public static extern System.Int32 VirtualAllocEx(int hProcess,int lpAddress,int dwSize,int flAllocationType,int flProtect);

            [DllImport("Kernel32.dll")]
            public static extern System.Int32 VirtualFreeEx(int hProcess,int lpAddress,int dwSize,int flAllocationType);

            [DllImport("kernel32.dll",EntryPoint = "OpenProcess")]
            public static extern int OpenProcess(int dwDesiredAccess,int bInheritHandle,int dwProcessId);

            private const int PAGE_EXECUTE_READWRITE = 0x4;
            private const int MEM_COMMIT = 4096;
            private const int MEM_RELEASE = 0x8000;
            private const int MEM_DECOMMIT = 0x4000;
            private const int PROCESS_ALL_ACCESS = 0x1F0FFF;
            private const int PROCESS_CREATE_THREAD = 0x2;
            private const int PROCESS_VM_OPERATION = 0x8;
            private const int PROCESS_VM_WRITE = 0x20;
            */
        public static byte[] stringToAsm(string asmPram) {
            asmPram=asmPram.Replace(" ","").Replace("0x","").Replace(",","");
            byte[] reAsmCode = new byte[asmPram.Length/2];
            for(int i = 0;i<reAsmCode.Length;i++) {
                reAsmCode[i]=Convert.ToByte(Int32.Parse(asmPram.Substring(i*2,2),System.Globalization.NumberStyles.AllowHexSpecifier));
            }
            return reAsmCode;
        }
        /*  
           public static string valueToHex(int value) {
               string str1 = ""; ;
               string str2 = "";
               str1="0000000"+value.ToString("X");
               str1=str1.Substring(str1.Length-8,8);
               for(int i = 0;i<str1.Length/2;i++) {
                   str2=str2+str1.Substring(str1.Length-2-2*i,2);
               }
               return str2;
           } 
           */
        public static string toHex(int value) {
            byte[] b = BitConverter.GetBytes(value);
            return Convert.ToString(b[0],16)+Convert.ToString(b[1],16)+Convert.ToString(b[2],16)+Convert.ToString(b[3],16);
        }
        public static string toHex(float value) {
            byte[] b = BitConverter.GetBytes(value);
            return Convert.ToString(b[0],16)+Convert.ToString(b[1],16)+Convert.ToString(b[2],16)+Convert.ToString(b[3],16);
        }
        public static string valueToHex(double value) {
            byte[] b = BitConverter.GetBytes(value);
            return Convert.ToString(b[0],16)+Convert.ToString(b[1],16)+Convert.ToString(b[2],16)+Convert.ToString(b[3],16)+Convert.ToString(b[4],16)+Convert.ToString(b[5],16)+Convert.ToString(b[6],16)+Convert.ToString(b[7],16);
        }

        public static byte[] getValueArray(byte[] array,bool isHooked) {
            return isHooked ? getNop(array.Length) : array;
        }

        public static byte[] getNop(int count) {
            byte[] b = new byte[count];
            for(int i = 0;i<count;i++) {
                b[i]=0x90;
            }
            return b;
        }

        /*   public static void RunAsm(int pid,string asm) {
               int hwnd, addre, threadhwnd;
               byte[] Asm = stringToAsm(asm);
               if(pid!=0) {
                   hwnd=OpenProcess(PROCESS_ALL_ACCESS|PROCESS_CREATE_THREAD|PROCESS_VM_WRITE,0,pid);
                   if(hwnd!=0) {
                       addre=VirtualAllocEx(hwnd,0,Asm.Length,MEM_COMMIT,PAGE_EXECUTE_READWRITE);
                       WriteProcessMemory(hwnd,addre,Asm,Asm.Length,0);
                       threadhwnd=CreateRemoteThread(hwnd,0,0,addre,0,0,ref pid);
                       VirtualFreeEx(hwnd,addre,Asm.Length,MEM_RELEASE);
                       CloseHandle(threadhwnd);
                       CloseHandle(hwnd);
                   }
               }
           }*/
    }
}

