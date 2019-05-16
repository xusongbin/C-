using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cc
{
    public partial class Form1 : Form
    {
        int[] status = new int[50];

        public Form1()
        {
            InitializeComponent();
        }

        private string get_Random(int num)
        {
            Random random = new Random();
            int[] oldlist = new int[49];
            int[] newlist = new int[num];
            int i;

            for (i = 0; i < 49; i++)
            {
                oldlist[i] = i + 1;
            }

            for (i = 0; i < num; i++)
            {
                int idx = random.Next(0, oldlist.Length);
                newlist[i] = oldlist[idx];
                List<int> al = new List<int>(oldlist);
                al.RemoveAt(idx);
                oldlist = al.ToArray();
            }
            //Array.Sort(newlist);
            return string.Join(",", newlist);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt16(textBox1.Text);
                if (num > 49) num = 49;
            }
            catch
            {
                return;
            }
            this.richTextBox1.Text = this.get_Random(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt16(textBox2.Text);
                if (num > 49) num = 49;
            }
            catch
            {
                return;
            }
            this.richTextBox2.Text = this.get_Random(num);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt16(textBox3.Text);
                if (num > 49) num = 49;
            }
            catch
            {
                return;
            }
            this.richTextBox3.Text = this.get_Random(num);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<char> list = new List<char>();
            for (int i = 32; i < 48; i++)
            {
                list.Add((char)i);
            }
            for (int i = 58; i < 127; i++)
            {
                list.Add((char)i);
            }
            char[] ch = new char[list.Count];
            list.CopyTo(ch);

            string[] t1 = this.richTextBox1.Text.Split(ch);
            string[] t2 = this.richTextBox2.Text.Split(ch);
            string[] t3 = this.richTextBox3.Text.Split(ch);
            //string[] tt = new string[49];
            int[] result = new int[49];
            int cnt;
            string str, tmp;
            bool flag;

            for(int i = 0; i < t1.Length; i++)
            {
                int idx = Convert.ToInt16(t1[i])-1;
                if (idx < 0 || idx > 49) continue;
                result[idx]++;
            }
            for (int i = 0; i < t2.Length; i++)
            {
                int idx = Convert.ToInt16(t2[i]) - 1;
                if (idx < 0 || idx > 49) continue;
                result[idx]++;
            }
            for (int i = 0; i < t3.Length; i++)
            {
                int idx = Convert.ToInt16(t3[i]) - 1;
                if (idx < 0 || idx > 49) continue;
                result[idx]++;
            }

            flag = false;
            tmp = "";
            cnt = 0;
            for (int i = 0; i < 49; i++)
            {
                if(result[i] == 3)
                {
                    if (flag)
                    {
                        tmp += ",";
                    }
                    tmp += (i+1).ToString();
                    cnt++;
                    flag = true;
                }
            }
            str = string.Format("重复3次 {0} 码：{1}\n", cnt, tmp);
            
            flag = false;
            tmp = "";
            cnt = 0;
            for (int i = 0; i < 49; i++)
            {
                if (result[i] == 2)
                {
                    if (flag)
                    {
                        tmp += ",";
                    }
                    tmp += (i+1).ToString();
                    cnt++;
                    flag = true;
                }
            }
            str += string.Format("重复2次 {0} 码：{1}\n", cnt, tmp);

            flag = false;
            tmp = "";
            cnt = 0;
            for (int i = 0; i < 49; i++)
            {
                if (result[i] == 1)
                {
                    if (flag)
                    {
                        tmp += ",";
                    }
                    tmp += (i+1).ToString();
                    cnt++;
                    flag = true;
                }
            }
            str += string.Format("重复1次 {0} 码：{1}", cnt, tmp);

            this.richTextBox4.Text = str;
        }

        private void label_Click(object sender, EventArgs e)
        {
            int idx;
            Image img;

            Label label = (Label)sender;
            idx = Convert.ToInt16(label.Text);
            if (this.status[idx] > 0)
            {
                this.status[idx] = 0;
                img = global::cc.Properties.Resources.round_blue_25x25;
            }
            else
            {
                this.status[idx] = 1;
                img = global::cc.Properties.Resources.round_red_25x25;
            }
            ((Label)Controls["label" + idx]).Image = img;

            int len = 0;
            for(int i=0; i<50; i++)
            {
                if (this.status[i] > 0) len++;
            }

            string head = "已选择" + Convert.ToInt16(len) + "码：";
            string str = "";
            for (int i = 0; i < 50; i++)
            {
                if (this.status[i] > 0)
                {
                    if(str != "")
                    {
                        str += ",";
                    }
                    str += Convert.ToInt16(i);
                }
            }
            str = head + str;
            this.richTextBox5.Text = str;
        }

        private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(this.richTextBox1.Text);
        }

        private void richTextBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(this.richTextBox2.Text);
        }

        private void richTextBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(this.richTextBox3.Text);
        }

        private void richTextBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(this.richTextBox4.Text);
        }

        private void richTextBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(this.richTextBox5.Text);
        }
    }
}
