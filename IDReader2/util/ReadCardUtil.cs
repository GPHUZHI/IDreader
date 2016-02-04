using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IDReader2.view;
using IDReader2.model;
using System.Windows.Forms;
using System.IO;

namespace IDReader2.util
{
    class ReadCardUtil
    {
        [DllImport("termb.dll")]
        public extern static int InitComm(int Port);
        [DllImport("termb.dll")]
        public extern static int InitCommExt();
        [DllImport("termb.dll")]
        public extern static int Authenticate();
        [DllImport("termb.dll")]
        public extern static int Read_Content(int Active);
        [DllImport("termb.dll")]
        public extern static int Read_Content_Path(string strPath, int Active);
        [DllImport("termb.dll")]
        public extern static int CloseComm();
        [DllImport("termb.dll")]
        public extern static int GetBmpPhoto(string Wlt_File);

        private HotelForm hotelForm = null;
        private string  m_strPath = Application.StartupPath;
        private TrainForm trainForm;

        private string ReadUser()
        {
            int r;
            r = Read_Content(1);//读卡
            String res = null;
            if (r <= 0)
            {
                res = null;
            }
            else {
                string filename = m_strPath + @"\\xp.wlt";filename = m_strPath + @"\\wz.txt";
                    FileStream fs = new FileStream(filename, FileMode.Open);
                    StreamReader sr = new StreamReader(fs, System.Text.Encoding.Unicode);
                    string filecontent = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                if (filecontent != null) { 
                    string strID = filecontent.Substring(61, 18);//IDNumber      
                    string strName = filecontent.Substring(0, 15);//name
                    string strTemp = filecontent.Substring(15, 1);//gender
                    string strSex = @"男";
                    if (@"1" == strTemp)
                        strSex = @"男";
                    else
                        strSex = @"女";
                    res =  @"SUC" + strID.Substring(12) + strID.Substring(12) + strName + strSex;

                }
                if (File.Exists(m_strPath + @"\\xp.wlt"))
                {
                    File.Delete(m_strPath + @"\\xp.wlt");
                }
                if (File.Exists(m_strPath + @"\\wz.txt"))
                {
                    File.Delete(m_strPath + @"\\wz.txt");
                }
                if (File.Exists(m_strPath + @"\\zp.bmp"))
                {
                    File.Delete(m_strPath + @"\\zp.bmp");
                }
            }
            return res;
        }

        private void ReadCardHotel()
        {
            int ret = 0;
            while (true)
            {
                Thread.Sleep(5000);
                try
                {
                    ret = Authenticate();//卡认证
                }
                catch (Exception e)
                {
                    hotelForm.UpdateState(e.Message+"请重新设定外部设备...");
                    return;
                }
                if (1 == ret)
                {
                    string user = ReadUser();
                    hotelForm.UpdateReadCard(user != null ? user : "FAI");
                }
            }
        }

/*
        internal void SearchCustomer(Thread thread, HotelForm hotelForm)
        {
            this.hotelForm = hotelForm;
            int port = 1;
            port = InitCommExt();//初始化
            if (0 == port)
            {
                throw new Exception("连接读卡器失败...");
            }
            thread = new Thread(new ThreadStart(ReadCard));
            thread.IsBackground = false;
            thread.Start();
        }
        */

        internal void ReadCustomer(Thread thread, HotelForm hotelForm)
        {
            this.hotelForm = hotelForm;
            int port = 1;
            port = InitCommExt();//初始化
            if (0 == port)
            {
                throw new Exception("连接读卡器失败...");
            }
            thread = new Thread(new ThreadStart(ReadCardHotel));
            //thread.IsBackground = true;
            thread.Start();
        }

        internal void ReadCustomer(Thread readRun, TrainForm trainForm)
        {
            this.trainForm = trainForm;
            int port = 1;
            port = InitCommExt();//初始化
            if (0 == port)
            {
                throw new Exception("连接读卡器失败...");
            }
            readRun = new Thread(new ThreadStart(ReadCardTrain));
            //thread.IsBackground = true;
            readRun.Start();
        }

        private void ReadCardTrain()
        {
            int ret = 0;
            while (true)
            {
                Thread.Sleep(5000);
                try
                {
                    ret = Authenticate();//卡认证
                }
                catch (Exception e)
                {
                    trainForm.UpdateState(e.Message + "请重新设定外部设备...");
                    return;
                }
                if (1 == ret)
                {
                    string user = ReadUser();
                    trainForm.UpdateReadCard(user != null ? user : "FAI");
                }
            }
        }
    }
}
