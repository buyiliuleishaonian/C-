﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U盘移动硬盘
{
    public class UDisk:Father
    {
        public override void Read(string path)
        {
            using (FileStream fileRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int number = fileRead.Read(buffer, 0, buffer.Length);
                string read = Encoding.UTF8.GetString(buffer, 0, number);
                Console.WriteLine("U盘读取");
                Console.WriteLine(read);
            }
        }
        public override void Write(string path)
        {
            using (FileStream fileWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string s = "今天天气好晴朗，处处好风光" + "\r\n" + "U盘硬盘";
                byte[] buffer = Encoding.UTF8.GetBytes(s);
                fileWrite.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
