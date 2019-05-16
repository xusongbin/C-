using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;


namespace RHF6CLN
{
    public partial class Form2 : Form
    {
        Form1 f1;
        Thread logic_thread;
        Thread tick_thread;
        int tick_cur, tick_per;

        string comStr = String.Empty;
        int comNodeIdx = -1;
        int comModuleIdx = -1;

        string node_id = "VID_0483&PID_5740";
        string module_id = "VID_0483&PID_374B";

        Test test = new Test();
        Queue<string> textQueue = new Queue<string>();
        Queue<State> stateQueue = new Queue<State>();

        string nodeRecvData = String.Empty;
        string moduleRecvData = String.Empty;

        public Form2(Form1 f, String type)
        {
            InitializeComponent();

            f1 = f;
            Text = type + " TEST";

            serialPortNode.BaudRate = 115200;
            serialPortModule.BaudRate = 9600;

            tick_thread = new Thread(new ThreadStart(TickThread));
            tick_thread.Start();

            logic_thread = new Thread(new ThreadStart(LogicThread));
            logic_thread.Start();
        }

        public static void WriteLog(string strLog)
        {
            string sFilePath = Directory.GetCurrentDirectory();
            string sFileName = "rizhi.log";
            FileStream fs;
            StreamWriter sw;
            if (File.Exists(sFileName))
            {
                fs = new FileStream(sFileName, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
            }
            sw = new StreamWriter(fs);
            strLog = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss.fff") + " --- " + strLog;
            sw.WriteLine(strLog);
            Debug.WriteLine(strLog);
            sw.Close();
            fs.Close();
        }

        private void TickThread()
        {
            for (; ; )
            {
                Thread.Sleep(1000);
                tick_cur++;
            }
        }

        private void LogicThread()
        {
            while (true)
            {
                switch(test.StateGet().flow)
                {
                    case Flow.IDLE:
                        //serialPortNode.Write("AT\r\n");
                        break;
                    case Flow.CODE:
                        if (serialPortNodeSetSend("AT+MODE=TEST\r\n", "+MODE: TEST") == String.Empty)
                        {
                            continue;
                        }
                        fun_work_state_next();
                        break;
                    case Flow.FREQ:
                        break;
                    case Flow.VER:
                        break;
                    case Flow.SENSOR:
                        break;
                    case Flow.TX:
                        break;
                    case Flow.RX:
                        break;
                    case Flow.RESULT:
                        break;
                }
                Thread.Sleep(100);
            }
        }
        private void fun_refresh_com()
        {
            string comStrTmp = string.Join(",", SerialPort.GetPortNames());
            int idxNode = Array.IndexOf(comStr.Split(','), serialPortNode.PortName);
            int idxModule = Array.IndexOf(comStr.Split(','), serialPortModule.PortName);

            if (comStr != comStrTmp || idxNode != comNodeIdx)
            {
                comStr = comStrTmp;
                comNodeIdx = idxNode;
                WriteLog("comStr:" + comStr + " comNodeIdx:" + idxNode);
                comboBoxNode.Items.Clear();
                comboBoxNode.SelectedText = " ";
                foreach (string a in comStr.Split(','))
                {
                    if (a != null)
                    {
                        comboBoxNode.Items.Add(a);
                    }
                }
                comboBoxNode.SelectedIndex = idxNode;
            }
            if (comStr != comStrTmp || idxModule != comModuleIdx)
            {
                comStr = comStrTmp;
                comModuleIdx = idxModule;
                WriteLog("comStr:" + comStr + " comModuleIdx:" + idxModule);
                comboBoxModule.Items.Clear();
                comboBoxModule.SelectedText = " ";
                foreach (string a in comStr.Split(','))
                {
                    if (a != null)
                    {
                        comboBoxModule.Items.Add(a);
                    }
                }
                comboBoxModule.SelectedIndex = idxModule;
            }
        }

        private void fun_work_state_next(string sta="NEXT")
        {
            switch (sta)
            {
                case "NEXT":
                    State perSta = test.StateGet();
                    if(perSta.flow > Flow.IDLE)
                    {
                        perSta.result = Result.PASS;
                        stateQueue.Enqueue(perSta);
                    }

                    test.StateNext();
                    State nextSta = test.StateGet();
                    stateQueue.Enqueue(nextSta);
                    break;
                case "ERROR":
                    break;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter || e.KeyCode == Keys.Control )
            {
                string str = textBoxCode.Text;
                if ( test.StateGet().flow == Flow.IDLE && str != "")
                {
                    test.DataCodeSet(str);
                    textQueue.Enqueue("CODE:" + str);
                    fun_work_state_next();
                }
                textBoxCode.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fun_refresh_com();

            if(textQueue.Count > 0)
            {
                richTextBoxTips.AppendText(textQueue.Dequeue() + "\r\n");
            }

            if(stateQueue.Count > 0)
            {
                State sta = stateQueue.Dequeue();
                Color color = new Color();

                if(sta.result == Result.DOING)
                {
                    color = Color.Blue;
                }
                else if (sta.result == Result.PASS)
                {
                    color = Color.Green;
                }
                else if (sta.result == Result.FAIL)
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.Black;
                }
                switch (sta.flow)
                {
                    case Flow.IDLE:
                        labelGetCode.ForeColor = color;
                        labelSetFreq.ForeColor = color;
                        labelGetVer.ForeColor = color;
                        labelGetSensor.ForeColor = color;
                        labelSetTx.ForeColor = color;
                        labelSetRx.ForeColor = color;
                        labelResult.ForeColor = color;
                        break;
                    case Flow.CODE:
                        labelGetCode.ForeColor = color;
                        break;
                    case Flow.FREQ:
                        labelSetFreq.ForeColor = color;
                        break;
                    case Flow.VER:
                        labelGetVer.ForeColor = color;
                        break;
                    case Flow.SENSOR:
                        labelGetSensor.ForeColor = color;
                        break;
                    case Flow.TX:
                        labelSetTx.ForeColor = color;
                        break;
                    case Flow.RX:
                        labelSetRx.ForeColor = color;
                        break;
                    case Flow.RESULT:
                        labelResult.ForeColor = color;
                        break;
                }
            }
        }

        private void serialPortNode_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            nodeRecvData += serialPortNode.ReadExisting();
        }

        private void serialPortModule_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            moduleRecvData += serialPortNode.ReadExisting();
        }

        private string serialPortNodeSetSend(string tData, string rData, long timeout = 50)
        {
            nodeRecvData = String.Empty;

            if (tData != String.Empty)
            {
                serialPortNode.Write(tData);
            }
            if (rData == String.Empty)
            {
                return String.Empty;
            }

            long _now = DateTime.Now.Ticks / 10000;
            long _start = DateTime.Now.Ticks / 10000;
            int recvLen = 0;
            while ((_now - _start) < timeout)
            {
                if (nodeRecvData.Length != recvLen)
                {
                    recvLen = nodeRecvData.Length;
                    _start = DateTime.Now.Ticks / 10000;
                }
                _now = DateTime.Now.Ticks / 10000;
                Thread.Sleep(5);
            }
            if (nodeRecvData != String.Empty)
            {
                int idx = nodeRecvData.IndexOf(rData);
                if (idx > -1)
                {
                    return nodeRecvData.Substring(idx);
                }
            }
            return String.Empty;
        }

        private string serialPortModuleSetSend(string tData, string rData, long timeout = 50)
        {
            moduleRecvData = String.Empty;

            if (tData != String.Empty)
            {
                serialPortModule.Write(tData);
            }
            if (rData == String.Empty)
            {
                return String.Empty;
            }

            long _now = DateTime.Now.Ticks / 10000;
            long _start = DateTime.Now.Ticks / 10000;
            int recvLen = 0;
            while ((_now - _start) < timeout)
            {
                if (moduleRecvData.Length != recvLen)
                {
                    recvLen = moduleRecvData.Length;
                    _start = DateTime.Now.Ticks / 10000;
                }
                _now = DateTime.Now.Ticks / 10000;
                Thread.Sleep(5);
            }
            if (moduleRecvData != String.Empty)
            {
                int idx = moduleRecvData.IndexOf(rData);
                if (idx > -1)
                {
                    return moduleRecvData.Substring(idx);
                }
            }
            return String.Empty;
        }

        private void comboBoxNode_TextChanged(object sender, EventArgs e)
        {
            string com = comboBoxNode.Text;
            WriteLog("comboBoxNode Change:" + com);
            if (com != " " && com != String.Empty)
            {
                try
                {
                    if (serialPortNode.IsOpen)
                    {
                        serialPortNode.Close();
                    }
                    serialPortNode.PortName = com;
                    serialPortNode.Open();
                }
                catch
                {
                    WriteLog("try close and open serialPortNode exception!");
                }
            }
        }

        private void comboBoxModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com = comboBoxModule.Text;
            WriteLog("comboBoxModule Change:" + com);
            if (com != " " && com != String.Empty)
            {
                try
                {
                    if (serialPortModule.IsOpen)
                    {
                        serialPortModule.Close();
                    }
                    serialPortModule.PortName = com;
                    serialPortModule.Open();
                }
                catch
                {
                    WriteLog("try close and open serialPortModule exception!");
                }
            }
        }

        private void Form2_Closed(object sender, FormClosedEventArgs e)
        {
            f1.Form1_Show();
            if (serialPortNode.IsOpen)
            {
                serialPortNode.Close();
            }
            if (serialPortModule.IsOpen)
            {
                serialPortModule.Close();
            }
            logic_thread.Abort();
            tick_thread.Abort();
        }
    }

    public enum Flow
    {
        IDLE,
        CODE,
        FREQ,
        VER,
        SENSOR,
        TX,
        RX,
        RESULT,
        DONE
    };

    public enum Result
    {
        IDLE,
        DOING,
        PASS,
        FAIL
    };

    public struct State
    {
        public Flow flow;
        public Result result;
    }

    public class Test
    {
        State state;

        string DataCode = String.Empty;
        UInt32 ConfigFreq = 470000000;

        public void DataCodeSet(string s)
        {
            DataCode = s;
        }
        public string DataCodeGet()
        {
            return DataCode;
        }

        public void ConfigFreqSet(UInt32 f)
        {
            ConfigFreq = f;
        }
        public UInt32 ConfigFreqGet()
        {
            return ConfigFreq;
        }

        public void StateInit()
        {
            state.flow = Flow.IDLE;
            state.result = Result.IDLE;
        }
        public void StateNext()
        {
            state.flow++;
            state.result = Result.DOING;
        }
        public State StateGet()
        {
            return state;
        }
    }
}
