using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;
using SharpConfig;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitcfgRead();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            timer1.Enabled = false;
            
        }
        bool PTy = true;
        public string str = "", strOne = "";
        public string SavePath = "";
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string mpAppName, string mpKeyName, string mpDefault, string mpFileName);
        public void  InitcfgRead()
        {
           try
           {
               SavePath = System.Windows.Forms.Application.StartupPath;
               str=SavePath+"\\USR-TCP-Test.cfg";
               strOne = "NetSettings";            
            ///获取cfg文件内容
            Configuration config = Configuration.LoadFromFile(str);
            foreach (Section item in config)
            {
                if (item.Name == "NetSettings")//获取yolo节点
                {
                    txtIP.Text=item["IP"].StringValue;
                    txtPort.Text = item["LocalPort"].StringValue;
                }  
            }
            config.SaveToFile(str, Encoding.ASCII);//保存
           }
           catch
           {

           }

        }
        #region
        //Thread threadWatch = null; // 负责监听客户端连接请求的 线程；
        //  Socket socketWatch = null;
        //  Dictionary<string, Socket> dict = new Dictionary<string, Socket>();
        //  Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();
        // /// <summary>
        //  /// 啟動監控服務
        //  /// </summary>
        //  /// <param name="sender"></param>
        //  /// <param name="e"></param>
        //  private void button1_Click(object sender, EventArgs e)
        //  {
        //      // 创建负责监听的套接字，注意其中的参数；
        //      socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //      // 获得文本框中的IP对象；
        //      IPAddress address = IPAddress.Parse(textBox1.Text.Trim());
        //      // 创建包含ip和端口号的网络节点对象；
        //      IPEndPoint endPoint = new IPEndPoint(address, int.Parse(textBox2.Text.Trim()));
        //      try
        //      {
        //          // 将负责监听的套接字绑定到唯一的ip和端口上；
        //          socketWatch.Bind(endPoint);
        //      }
        //      catch (SocketException se)
        //      {
        //          MessageBox.Show("异常：" + se.Message);
        //          return;
        //      }
        //      // 设置监听队列的长度；
        //      socketWatch.Listen(10);
        //      // 创建负责监听的线程；
        //      threadWatch = new Thread(WatchConnecting);
        //      threadWatch.IsBackground = true;
        //      threadWatch.Start();
        //      ShowMsg("服务器启动监听成功！");
        //      WritePrivateProfileString(strOne, "IP", textBox1.Text.Trim(), str);
        //      WritePrivateProfileString(strOne, "LocalPort", textBox2.Text.Trim(), str);
              
        //  }
        //  /// <summary>
        //  /// 监听客户端请求的方法；
        //  /// </summary>
        //  void WatchConnecting()
        //  {
        //      while (true)  // 持续不断的监听客户端的连接请求；
        //      {
        //          // 开始监听客户端连接请求，Accept方法会阻断当前的线程；
        //          Socket sokConnection = socketWatch.Accept(); // 一旦监听到一个客户端的请求，就返回一个与该客户端通信的 套接字；
        //          // 想列表控件中添加客户端的IP信息；
        //          listBox1.Items.Add(sokConnection.RemoteEndPoint.ToString());
        //          // 将与客户端连接的 套接字 对象添加到集合中；
        //          dict.Add(sokConnection.RemoteEndPoint.ToString(), sokConnection);
        //          ShowMsg("客户端连接成功！");
        //          Thread thr = new Thread(RecMsg);
        //          thr.IsBackground = true;
        //          thr.Start(sokConnection);
        //          dictThread.Add(sokConnection.RemoteEndPoint.ToString(), thr);  //  将新建的线程 添加 到线程的集合中去。
        //      }
        //  }
        //  void RecMsg(object sokConnectionparn)
        //  {
        //      Socket sokClient = sokConnectionparn as Socket;             
        //      while (true)
        //      {
        //          // 定义一个2M的缓存区；
        //          byte[] arrMsgRec = new byte[1024 * 1024 * 2];
        //          // 将接受到的数据存入到输入  arrMsgRec中；
        //          int length = -1;
        //          try
        //          {
        //              length = sokClient.Receive(arrMsgRec); // 接收数据，并返回数据的长度；
        //          }
        //          catch (SocketException se)
        //          {
        //             ShowMsg("异常：" + se.Message);
        //             // 从 通信套接字 集合中删除被中断连接的通信套接字；
        //             dict.Remove(sokClient.RemoteEndPoint.ToString());
        //             // 从通信线程集合中删除被中断连接的通信线程对象；
        //            dictThread.Remove(sokClient.RemoteEndPoint.ToString());
        //             // 从列表中移除被中断的连接IP
        //             listBox1.Items.Remove(sokClient.RemoteEndPoint.ToString());
        //             break;
        //         }
        //         catch (Exception e)
        //         {
        //             ShowMsg("异常：" + e.Message);
        //             // 从 通信套接字 集合中删除被中断连接的通信套接字；
        //             dict.Remove(sokClient.RemoteEndPoint.ToString());
        //             // 从通信线程集合中删除被中断连接的通信线程对象；
        //             dictThread.Remove(sokClient.RemoteEndPoint.ToString());
        //             // 从列表中移除被中断的连接IP
        //             listBox1.Items.Remove(sokClient.RemoteEndPoint.ToString());
        //             break;
        //         }      
        //         ///--------------------------------------接收客戶端發送過來的信息----------------------------------------------
        //          string strMsg = System.Text.Encoding.UTF8.GetString(arrMsgRec, 1, length - 1);// 将接受到的字节数据转化成字符串；
        //             ShowMsg(strMsg);
        //             ///------------------------------------向客戶端發送回執信息--------------------------------------
        //             string send = "*RR," + strMsg.Substring(1, 2) + "," + strMsg.Substring(5, 7) + "#";
        //             byte[] arrMsg = System.Text.Encoding.UTF8.GetBytes(send); // 将要发送的字符串转换成Utf-8字节数组；
        //             byte[] arrSendMsg = new byte[arrMsg.Length + 1];
        //             arrSendMsg[0] = 0; // 表示发送的是消息数据
        //             Buffer.BlockCopy(arrMsg, 0, arrSendMsg, 1, arrMsg.Length);    
        //             for (int i = 0; i < listBox1.Items.Count; i++)
        //             {
        //                     string strKey = listBox1.Items[i].ToString();
        //                     dict[strKey].Send(arrSendMsg);// 解决了 sokConnection是局部变量，不能再本函数中引用的问题；
        //                     ShowMsg(send);  
        //             }                   
        //     }
        // }
        // void ShowMsg(string str)
        // {
        //     textBox3.AppendText(str + "\r\n");
        // }
        // int portNum =0;
        // string hostName = null;   
        // private void button2_Click(object sender, EventArgs e)
        // {
        //      portNum = int.Parse(textBox2.Text.Trim());//服务器端口，可以随意修改
        //     hostName = textBox1.Text;//服务器地址，127.0.0.1指本机
             
        //     Thread thr1 = new Thread(CRecMsg);
        //     thr1.IsBackground = true;
        //     thr1.Start();
        //     ShowCMsg("服务器连接成功！");
  
        // }
        // void CRecMsg()
        // {
        //     while (true)
        //     {
        //     TcpClient client = new TcpClient(hostName, portNum);
        //     NetworkStream ns = client.GetStream();
        //         byte[] bytes = new byte[1024];
        //         int bytesRead = ns.Read(bytes, 0, bytes.Length);
        //     ShowCMsg(Encoding.ASCII.GetString(bytes, 0, bytesRead));
        //      //ns.Write
        //      client.Close();
        //     }
         
        // }
        // void ShowCMsg(string str)
        // {
        //     textBox4.AppendText(str + "\r\n");
        // }
        // private void button4_Click(object sender, EventArgs e)
        // {

        // }
        #endregion
         /// <summary>
         /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        #region
        private Socket serverSocket;
        List<Socket> ClientProxClentList = new List<Socket>();
        private bool state = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket = socket;
                //ip port
                socket.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text.ToString()), int.Parse(txtPort.Text)));
                //listen
                socket.Listen(10);//连接等待队列
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.AcceptClientConnect), socket);
                state = true;
                btnStart.Text = "停止服务器";
            }
            else
            {
                try
                {
                    serverSocket.Close();
                    serverSocket.Shutdown(SocketShutdown.Both);
                }
                catch (Exception)
                {
                    state = false;
                    btnStart.Text = "启动服务器";
                }
            }
            //对象

           
        }
 
        //日志文本框追加数据
        public void AppendTextToTxtLog(string txt) 
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.BeginInvoke(new Action<string>(s =>
                {
                    this.txtLog.Text = string.Format("{0}\r\n{1}", s, txtLog.Text);
                }), txt);
            }
            else
            {
                this.txtLog.Text = string.Format("{0}\r\n{1}", txt, txtLog.Text);
            }
        }
        public void AcceptClientConnect(object socket)
        {
            var serverSocket = socket as Socket;
            this.AppendTextToTxtLog("服务器端开始接受客户端的链接");
            while (true)
            {
                try
                {
                    var proxSocket = serverSocket.Accept();
                    this.AppendTextToTxtLog(string.Format("客户端{0}连接上了", proxSocket.RemoteEndPoint.ToString()));
                    ClientProxClentList.Add(proxSocket);
 
                    //接受消息
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ReceiveData), proxSocket);
                }
                catch (Exception)
                {
                }
                
            }
        }
        public void ReceiveData(object obj)
        {
            Socket proxSocket = obj as Socket;
            byte[] data = new byte[1024 * 1024];
            while (true)
            {
                int readLen = 0;
                try
                {
                    readLen = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception ex)
                {
                    //异常退出时
                    AppendTextToTxtLog(string.Format("客户端{0}非正常退出", proxSocket.RemoteEndPoint.ToString()));
                    ClientProxClentList.Remove(proxSocket);
                    StopConnetct(proxSocket);
                    return;
                }
                if (readLen<=0)
                {
                    //客户端正常退出
                    AppendTextToTxtLog(string.Format("客户端:{0}正常退出", proxSocket.RemoteEndPoint.ToString()));
                    ClientProxClentList.Remove(proxSocket);
                    StopConnetct(proxSocket);
                    return;//方法结束->终结当前接受客户端数据的异步线程
                }
                string txt = Encoding.Default.GetString(data, 0, readLen);
                AppendTextToTxtLog(string.Format("接收到客户端{0}的消息{1}",proxSocket.RemoteEndPoint.ToString(),txt));
            }
        }
 
        private void btnSend1_Click(object sender, EventArgs e)
        {
            foreach (var proxSocket in ClientProxClentList)
            {
                if (proxSocket.Connected)
                {
                    //原始的字符串转换成的字节数组
                    byte[] data = Encoding.Default.GetBytes(txtSendMsg.Text);
                    //在头部加上标记字节
                    byte[] result = new byte[data.Length + 1];
                    //头部协议字节 1:代表字符串
                    result[0] = 1;
                    Buffer.BlockCopy(data, 0, result, 1, data.Length);
                    proxSocket.Send(result, 0, result.Length,SocketFlags.None);
                }
            }
        }
 
        private void StopConnetct(Socket proxSocket)
        {
            try
            {
                if (proxSocket.Connected)
                {
                    proxSocket.Shutdown(SocketShutdown.Both);
                    proxSocket.Close(100);
                }
            }
            catch (Exception ex)
            {
            }
        }
 



  /////////////////////////////////////////
         public Socket ClientSocket { get; set;   }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            ClientSocket = socket;
            try
            {
                socket.Connect(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Bad");
                return;
            }            
            AppendTextToTxtLog(string.Format("服务端{0}已连接",ClientSocket.RemoteEndPoint.ToString()));
            Thread thread = new Thread(new ParameterizedThreadStart(ReceiveData));
            thread.IsBackground = true;
            thread.Start(ClientSocket);
        }
        #region//客户端接收
        //public void ReceiveData(object obj)
        //{
        //    Socket proxSocket = obj as Socket;
        //    byte[] data = new byte[1024 * 1024];
        //    while (true)
        //    {
        //        int readLen = 0;
        //        try
        //        {
        //            readLen = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
        //        }
        //        catch (Exception)
        //        {
        //            //异常退出时
        //            AppendTextToTxtLog(string.Format("服务端{0}非正常退出", proxSocket.RemoteEndPoint.ToString()));
        //            StopConnetct();
        //            return;
        //        }
        //        if (readLen <= 0)
        //        {
        //            //客户端正常退出
        //            AppendTextToTxtLog(string.Format("服务端:{0}正常退出", proxSocket.RemoteEndPoint.ToString()));                    
        //            StopConnetct();
        //            return;//方法结束->终结当前接受客户端数据的异步线程
        //        }
        //        //接受的数据中第一个字节如果是1,那么是字符串.2是闪屏.3是文件
        //        if (data[0]==1)
        //        {
        //            string strMsg = ProcessRecieveString(data, readLen);
        //            AppendTextToTxtLog(string.Format("接收到服务端{0}的消息{1}", proxSocket.RemoteEndPoint.ToString(), strMsg));
        //        }
        //        else if (data[0] == 2)
        //        {
        //            ProcessRecieveShake();
        //        }
        //        else if (data[0]==3)
        //        {
        //            ProcessRecieveFile(data, readLen);
        //        }
        //    }
        //}
        //public string ProcessRecieveString(byte[] data,int readLen)
        //{
        //    string str = Encoding.Default.GetString(data, 1, readLen);
        //    return str;
        //}
        //public void ProcessRecieveShake()
        //{
        //    Point oldLocation = this.Location;
        //    Random r = new Random();
            
        //    if (this.InvokeRequired)
        //    {
        //        txtLog.BeginInvoke(new Action<Point,Random>(Shake),oldLocation,r);
        //    }
        //    else
        //    {
        //        Shake(oldLocation, r);
        //    }         
        //}
 
        //private void Shake(Point oldLocation, Random r)
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        this.Location = new Point(r.Next(oldLocation.X - 5, oldLocation.X + 5), r.Next(oldLocation.Y - 5, oldLocation.Y + 5));
        //        Thread.Sleep(50);
        //        this.Location = oldLocation;
        //    }
        //}
 
        public void ProcessRecieveFile(byte[] data,int readLen)//接收文件
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "txt";
                sfd.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
                if (sfd.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
                byte[] fileData = new byte[readLen - 1];
                Buffer.BlockCopy(data, 1, fileData, 0, readLen - 1);
                File.WriteAllBytes(sfd.FileName, fileData);
                AppendTextToTxtLog(string.Format("接收到文件,已保存到{0}", sfd.FileName));
            }
        }
        //public void AppendTextToTxtLog(string txt)
        //{
        //    if (txtLog.InvokeRequired)
        //    {
        //        txtLog.BeginInvoke(new Action<string>(s =>{this.txtLog.Text = String.Format("{0}\r\n{1}", s, txtLog.Text);}), txt);
        //    }
        //    else
        //    {
        //        this.txtLog.Text = string.Format("{0}\r\n{1}", txt, txtLog.Text);
        //    }
        //}
        #endregion
        private void btnSend_Click(object sender, EventArgs e)
        {
            // AppendTextToTxtLog("123");
            if (ClientSocket==null)
            {
                return;
            }
            if (ClientSocket.Connected)
            {
                byte[] data = Encoding.Default.GetBytes(txtSendMsg.Text);
                ClientSocket.Send(data, 0, data.Length, SocketFlags.None);
            }
            
        }
        #region//客户端关闭
        private void StopConnetct()
        {
            try
            {
                if (ClientSocket.Connected)
                {
                    ClientSocket.Shutdown(SocketShutdown.Both);
                    ClientSocket.Close(100);
                }
            }
            catch (Exception ex)
            {
            }
        }
 
        private void Mianfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopConnetct();
 
        }
 
        private void Mianfrm_Load(object sender, EventArgs e)
        {
            AppendTextToTxtLog("请单击连接到服务器");
        }
        #endregion
        #endregion
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>

        #region 得到光标在屏幕上的位置
        [DllImport("user32")]
        public static extern bool GetCaretPos(out Point lpPoint);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetFocus();
        [DllImport("user32.dll")]
        private static extern IntPtr AttachThreadInput(IntPtr idAttach, IntPtr idAttachTo, int fAttach);
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentThreadId();
        [DllImport("user32.dll")]
        private static extern void ClientToScreen(IntPtr hWnd, ref Point p);

        private Point CaretPos()
        {
            IntPtr ptr = GetForegroundWindow();
            Point p = new Point();

            //得到Caret在屏幕上的位置   
            if (ptr.ToInt32() != 0)
            {
                IntPtr targetThreadID = GetWindowThreadProcessId(ptr, IntPtr.Zero);
                IntPtr localThreadID = GetCurrentThreadId();
                if (localThreadID != targetThreadID)
                {
                    AttachThreadInput(localThreadID, targetThreadID, 1);
                    ptr = GetFocus();
                    if (ptr.ToInt32() != 0)
                    {
                        GetCaretPos(out   p);
                        ClientToScreen(ptr, ref   p);
                    }
                    AttachThreadInput(localThreadID, targetThreadID, 0);
                }
            }
            return p;
            
        }


      

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CaretPos();
        }

  
       //GetForegroundWindow找到当前窗口
       //GetGUIThreadInfo返回的结构体中的hwndCaret得到句柄
        //SendMessage WM_TEXT/WM_PASTE或者SendKeys.Send发送文本。
        #endregion













        #region//网络TCP连接


        private void cbbox_Protocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbox_Protocol.SelectedIndex==1)
            {
                button6.Text = "启动客户端";
                PTy = false;
            }
            else
            {
                button6.Text = "启动服务器";
                PTy = true;
            }

        }
        //启动网络连接
        private void button6_Click(object sender, EventArgs e)
        {
            if (PTy)
            {
                if (!state)
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    serverSocket = socket;
                    //ip port
                    socket.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text.ToString()), int.Parse(txtPort.Text)));
                    //listen
                    socket.Listen(10);//连接等待队列
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.AcceptClientConnect), socket);
                    state = true;
                    button6.Text = "停止";
                }
                else
                {
                    try
                    {
                        serverSocket.Close();
                        serverSocket.Shutdown(SocketShutdown.Both);
                    }
                    catch (Exception)
                    {
                        state = false;
                        button6.Text = "启动服务器";
                    }
                }  
            }
            else
            {
                if (!state)
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ClientSocket = socket;
                    try
                    {
                        socket.Connect(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bad");
                        return;
                    }
                    AppendTextToTxtLog(string.Format("服务端{0}已连接", ClientSocket.RemoteEndPoint.ToString()));
                    Thread thread = new Thread(new ParameterizedThreadStart(ReceiveData));
                    thread.IsBackground = true;
                    thread.Start(ClientSocket);
                    state = true;
                    button6.Text = "停止";
                }
                else
                {
                    try
                    {
                        ClientSocket.Close();
                        ClientSocket.Shutdown(SocketShutdown.Both);
                    }
                    catch (Exception)
                    {
                        state = false;
                        button6.Text = "启动客户端";
                    }
                }

            }
            WritePrivateProfileString(strOne, "IP", txtIP.Text.Trim(), str);
            WritePrivateProfileString(strOne, "LocalPort", txtPort.Text.Trim(), str);
        }
        //发送数据
        private void button7_Click(object sender, EventArgs e)
        {
            if (PTy)
            {
                foreach (var proxSocket in ClientProxClentList)
                {
                    if (proxSocket.Connected)
                    {
                        //原始的字符串转换成的字节数组
                        byte[] data = Encoding.Default.GetBytes(txtSendMsg.Text);
                        //在头部加上标记字节
                        byte[] result = new byte[data.Length + 1];
                        //头部协议字节 1:代表字符串
                        result[0] = 1;
                        Buffer.BlockCopy(data, 0, result, 1, data.Length);
                        proxSocket.Send(result, 0, result.Length, SocketFlags.None);
                    }
                }  
            }
            else
            {
                if (ClientSocket == null)
                {
                    return;
                }
                if (ClientSocket.Connected)
                {
                    byte[] data = Encoding.Default.GetBytes(txtSendMsg.Text);
                    ClientSocket.Send(data, 0, data.Length, SocketFlags.None);
                }
            }
        }
        private void btn_ClearSend_Click(object sender, EventArgs e)
        {
            txtSendMsg.Text = "";
        }
        private void btn_ClearReceive_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }


#endregion



    }
 }



