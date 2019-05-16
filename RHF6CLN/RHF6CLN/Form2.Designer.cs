namespace RHF6CLN
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelGetCode = new System.Windows.Forms.Label();
            this.richTextBoxTips = new System.Windows.Forms.RichTextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelSetFreq = new System.Windows.Forms.Label();
            this.labelGetVer = new System.Windows.Forms.Label();
            this.labelGetSensor = new System.Windows.Forms.Label();
            this.labelSetTx = new System.Windows.Forms.Label();
            this.labelSetRx = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelStaticCode = new System.Windows.Forms.Label();
            this.labelStaticTips = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelStaticTestPass = new System.Windows.Forms.Label();
            this.labelStaticTestFail = new System.Windows.Forms.Label();
            this.labelNode = new System.Windows.Forms.Label();
            this.comboBoxNode = new System.Windows.Forms.ComboBox();
            this.labelCountPass = new System.Windows.Forms.Label();
            this.labelCountFail = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPortNode = new System.IO.Ports.SerialPort(this.components);
            this.serialPortModule = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxModule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGetCode
            // 
            this.labelGetCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGetCode.AutoSize = true;
            this.labelGetCode.Location = new System.Drawing.Point(25, 45);
            this.labelGetCode.Name = "labelGetCode";
            this.labelGetCode.Size = new System.Drawing.Size(65, 12);
            this.labelGetCode.TabIndex = 0;
            this.labelGetCode.Text = "等待二维码";
            // 
            // richTextBoxTips
            // 
            this.richTextBoxTips.Location = new System.Drawing.Point(94, 35);
            this.richTextBoxTips.Name = "richTextBoxTips";
            this.richTextBoxTips.Size = new System.Drawing.Size(254, 320);
            this.richTextBoxTips.TabIndex = 1;
            this.richTextBoxTips.Text = "";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(94, 361);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(180, 21);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // labelSetFreq
            // 
            this.labelSetFreq.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSetFreq.AutoSize = true;
            this.labelSetFreq.Location = new System.Drawing.Point(13, 91);
            this.labelSetFreq.Name = "labelSetFreq";
            this.labelSetFreq.Size = new System.Drawing.Size(77, 12);
            this.labelSetFreq.TabIndex = 0;
            this.labelSetFreq.Text = "设置测试频率";
            // 
            // labelGetVer
            // 
            this.labelGetVer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGetVer.AutoSize = true;
            this.labelGetVer.Location = new System.Drawing.Point(13, 137);
            this.labelGetVer.Name = "labelGetVer";
            this.labelGetVer.Size = new System.Drawing.Size(77, 12);
            this.labelGetVer.TabIndex = 0;
            this.labelGetVer.Text = "软件版本校验";
            // 
            // labelGetSensor
            // 
            this.labelGetSensor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGetSensor.AutoSize = true;
            this.labelGetSensor.Location = new System.Drawing.Point(1, 183);
            this.labelGetSensor.Name = "labelGetSensor";
            this.labelGetSensor.Size = new System.Drawing.Size(89, 12);
            this.labelGetSensor.TabIndex = 0;
            this.labelGetSensor.Text = "获取传感器数据";
            // 
            // labelSetTx
            // 
            this.labelSetTx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSetTx.AutoSize = true;
            this.labelSetTx.Location = new System.Drawing.Point(13, 229);
            this.labelSetTx.Name = "labelSetTx";
            this.labelSetTx.Size = new System.Drawing.Size(77, 12);
            this.labelSetTx.TabIndex = 0;
            this.labelSetTx.Text = "测试发射功率";
            // 
            // labelSetRx
            // 
            this.labelSetRx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSetRx.AutoSize = true;
            this.labelSetRx.Location = new System.Drawing.Point(13, 275);
            this.labelSetRx.Name = "labelSetRx";
            this.labelSetRx.Size = new System.Drawing.Size(77, 12);
            this.labelSetRx.TabIndex = 0;
            this.labelSetRx.Text = "测试接收信号";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(37, 321);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(53, 12);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "测试结果";
            // 
            // labelStaticCode
            // 
            this.labelStaticCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStaticCode.AutoSize = true;
            this.labelStaticCode.Location = new System.Drawing.Point(49, 364);
            this.labelStaticCode.Name = "labelStaticCode";
            this.labelStaticCode.Size = new System.Drawing.Size(41, 12);
            this.labelStaticCode.TabIndex = 0;
            this.labelStaticCode.Text = "QRCode";
            // 
            // labelStaticTips
            // 
            this.labelStaticTips.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStaticTips.AutoSize = true;
            this.labelStaticTips.Location = new System.Drawing.Point(92, 20);
            this.labelStaticTips.Name = "labelStaticTips";
            this.labelStaticTips.Size = new System.Drawing.Size(53, 12);
            this.labelStaticTips.TabIndex = 0;
            this.labelStaticTips.Text = "消息提示";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "停止测试";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "清零计数";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "导出测试结果";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "设置参考范围";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // labelStaticTestPass
            // 
            this.labelStaticTestPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStaticTestPass.AutoSize = true;
            this.labelStaticTestPass.Location = new System.Drawing.Point(300, 406);
            this.labelStaticTestPass.Name = "labelStaticTestPass";
            this.labelStaticTestPass.Size = new System.Drawing.Size(65, 12);
            this.labelStaticTestPass.TabIndex = 0;
            this.labelStaticTestPass.Text = "测试成功：";
            // 
            // labelStaticTestFail
            // 
            this.labelStaticTestFail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStaticTestFail.AutoSize = true;
            this.labelStaticTestFail.Location = new System.Drawing.Point(401, 406);
            this.labelStaticTestFail.Name = "labelStaticTestFail";
            this.labelStaticTestFail.Size = new System.Drawing.Size(65, 12);
            this.labelStaticTestFail.TabIndex = 0;
            this.labelStaticTestFail.Text = "测试失败：";
            // 
            // labelNode
            // 
            this.labelNode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNode.AutoSize = true;
            this.labelNode.Location = new System.Drawing.Point(128, 406);
            this.labelNode.Name = "labelNode";
            this.labelNode.Size = new System.Drawing.Size(29, 12);
            this.labelNode.TabIndex = 0;
            this.labelNode.Text = "节点";
            // 
            // comboBoxNode
            // 
            this.comboBoxNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNode.FormattingEnabled = true;
            this.comboBoxNode.Location = new System.Drawing.Point(157, 402);
            this.comboBoxNode.Name = "comboBoxNode";
            this.comboBoxNode.Size = new System.Drawing.Size(60, 20);
            this.comboBoxNode.TabIndex = 4;
            this.comboBoxNode.TextChanged += new System.EventHandler(this.comboBoxNode_TextChanged);
            // 
            // labelCountPass
            // 
            this.labelCountPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCountPass.AutoSize = true;
            this.labelCountPass.Location = new System.Drawing.Point(370, 406);
            this.labelCountPass.Name = "labelCountPass";
            this.labelCountPass.Size = new System.Drawing.Size(23, 12);
            this.labelCountPass.TabIndex = 0;
            this.labelCountPass.Text = "123";
            this.labelCountPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountFail
            // 
            this.labelCountFail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCountFail.AutoSize = true;
            this.labelCountFail.Location = new System.Drawing.Point(472, 406);
            this.labelCountFail.Name = "labelCountFail";
            this.labelCountFail.Size = new System.Drawing.Size(23, 12);
            this.labelCountFail.TabIndex = 0;
            this.labelCountFail.Text = "123";
            this.labelCountFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPortNode
            // 
            this.serialPortNode.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortNode_DataReceived);
            // 
            // serialPortModule
            // 
            this.serialPortModule.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortModule_DataReceived);
            // 
            // comboBoxModule
            // 
            this.comboBoxModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModule.FormattingEnabled = true;
            this.comboBoxModule.Location = new System.Drawing.Point(56, 403);
            this.comboBoxModule.Name = "comboBoxModule";
            this.comboBoxModule.Size = new System.Drawing.Size(60, 20);
            this.comboBoxModule.TabIndex = 6;
            this.comboBoxModule.SelectedIndexChanged += new System.EventHandler(this.comboBoxModule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "模块";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 451);
            this.Controls.Add(this.comboBoxModule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNode);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.richTextBoxTips);
            this.Controls.Add(this.labelStaticTestFail);
            this.Controls.Add(this.labelCountFail);
            this.Controls.Add(this.labelCountPass);
            this.Controls.Add(this.labelNode);
            this.Controls.Add(this.labelStaticTestPass);
            this.Controls.Add(this.labelStaticCode);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSetRx);
            this.Controls.Add(this.labelSetTx);
            this.Controls.Add(this.labelGetSensor);
            this.Controls.Add(this.labelGetVer);
            this.Controls.Add(this.labelSetFreq);
            this.Controls.Add(this.labelStaticTips);
            this.Controls.Add(this.labelGetCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(523, 489);
            this.MinimumSize = new System.Drawing.Size(523, 489);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGetCode;
        private System.Windows.Forms.RichTextBox richTextBoxTips;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelSetFreq;
        private System.Windows.Forms.Label labelGetVer;
        private System.Windows.Forms.Label labelGetSensor;
        private System.Windows.Forms.Label labelSetTx;
        private System.Windows.Forms.Label labelSetRx;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelStaticCode;
        private System.Windows.Forms.Label labelStaticTips;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelStaticTestPass;
        private System.Windows.Forms.Label labelStaticTestFail;
        private System.Windows.Forms.Label labelNode;
        private System.Windows.Forms.ComboBox comboBoxNode;
        private System.Windows.Forms.Label labelCountPass;
        private System.Windows.Forms.Label labelCountFail;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPortNode;
        private System.IO.Ports.SerialPort serialPortModule;
        private System.Windows.Forms.ComboBox comboBoxModule;
        private System.Windows.Forms.Label label1;
    }
}