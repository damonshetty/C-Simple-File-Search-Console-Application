﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSearch
{
    public class File
    {
        public delegate void DisplayFileName(string file);
        public event DisplayFileName sendFileName;

        public void Search(string dirName)
        {
            foreach(string dir in Directory.GetDirectories(dirName))
            { 

                foreach(string str in Directory.GetFiles(dirName))
                {
                    sendFileName(str);
                    //send it to the console application

                }

                Search(dir);

            }

        }

    }
}
