﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class FileManager
    {
        public String onStartup()
        {
            try
            {
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                String strNaamFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NetPay";
                if (!(System.IO.Directory.Exists(strNaamFolder)))
                {
                    System.IO.Directory.CreateDirectory(strNaamFolder);
                    System.IO.File.Create(strNaamFolder + @"\Products.json");
                    return "success";
                }
                else
                {
                    if (!(System.IO.File.Exists(strNaamFolder + @"\Products.json"))) {
                        System.IO.File.Create(strNaamFolder + @"\Products.json");
                        return "success";
                    }else{
                        return "success";
                    }
                }

                    

            }catch(Exception e)
            {
                return e.ToString();
            }
        }


    }
}
