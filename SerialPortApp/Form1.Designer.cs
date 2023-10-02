namespace SerialPortApp
{
    partial class Form1
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
            this.lal_port = new System.Windows.Forms.Label();
            this.Cbo_Port = new System.Windows.Forms.ComboBox();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Txt_Send = new System.Windows.Forms.TextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Txt_Receive = new System.Windows.Forms.TextBox();
            this.lbl_Send = new System.Windows.Forms.Label();
            this.Lbl_Receive = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Btc_clear_send = new System.Windows.Forms.Button();
            this.Btn_Clear_receive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lal_port
            // 
            this.lal_port.AutoSize = true;
            this.lal_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lal_port.Location = new System.Drawing.Point(54, 74);
            this.lal_port.Name = "lal_port";
            this.lal_port.Size = new System.Drawing.Size(53, 25);
            this.lal_port.TabIndex = 0;
            this.lal_port.Text = "Port:";
            // 
            // Cbo_Port
            // 
            this.Cbo_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Port.FormattingEnabled = true;
            this.Cbo_Port.Location = new System.Drawing.Point(165, 74);
            this.Cbo_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_Port.Name = "Cbo_Port";
            this.Cbo_Port.Size = new System.Drawing.Size(241, 33);
            this.Cbo_Port.TabIndex = 1;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Open.Location = new System.Drawing.Point(447, 60);
            this.Btn_Open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(172, 75);
            this.Btn_Open.TabIndex = 2;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Close.Location = new System.Drawing.Point(668, 60);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(165, 75);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Txt_Send
            // 
            this.Txt_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_Send.Location = new System.Drawing.Point(165, 175);
            this.Txt_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Send.Multiline = true;
            this.Txt_Send.Name = "Txt_Send";
            this.Txt_Send.Size = new System.Drawing.Size(772, 256);
            this.Txt_Send.TabIndex = 4;
            this.Txt_Send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Message_KeyPress);
            // 
            // Btn_Send
            // 
            this.Btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Send.Location = new System.Drawing.Point(766, 466);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(172, 75);
            this.Btn_Send.TabIndex = 5;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Txt_Receive
            // 
            this.Txt_Receive.Location = new System.Drawing.Point(165, 571);
            this.Txt_Receive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Receive.Multiline = true;
            this.Txt_Receive.Name = "Txt_Receive";
            this.Txt_Receive.ReadOnly = true;
            this.Txt_Receive.Size = new System.Drawing.Size(772, 256);
            this.Txt_Receive.TabIndex = 6;
            // 
            // lbl_Send
            // 
            this.lbl_Send.AutoSize = true;
            this.lbl_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Send.Location = new System.Drawing.Point(54, 175);
            this.lbl_Send.Name = "lbl_Send";
            this.lbl_Send.Size = new System.Drawing.Size(59, 25);
            this.lbl_Send.TabIndex = 8;
            this.lbl_Send.Text = "Send";
            // 
            // Lbl_Receive
            // 
            this.Lbl_Receive.AutoSize = true;
            this.Lbl_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Receive.Location = new System.Drawing.Point(26, 571);
            this.Lbl_Receive.Name = "Lbl_Receive";
            this.Lbl_Receive.Size = new System.Drawing.Size(88, 25);
            this.Lbl_Receive.TabIndex = 9;
            this.Lbl_Receive.Text = "Receive:";
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Btc_clear_send
            // 
            this.Btc_clear_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btc_clear_send.Location = new System.Drawing.Point(165, 466);
            this.Btc_clear_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btc_clear_send.Name = "Btc_clear_send";
            this.Btc_clear_send.Size = new System.Drawing.Size(172, 75);
            this.Btc_clear_send.TabIndex = 10;
            this.Btc_clear_send.Text = "Clear";
            this.Btc_clear_send.UseVisualStyleBackColor = true;
            this.Btc_clear_send.Click += new System.EventHandler(this.Btc_clear_send_Click);
            // 
            // Btn_Clear_receive
            // 
            this.Btn_Clear_receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Clear_receive.Location = new System.Drawing.Point(165, 878);
            this.Btn_Clear_receive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Clear_receive.Name = "Btn_Clear_receive";
            this.Btn_Clear_receive.Size = new System.Drawing.Size(172, 75);
            this.Btn_Clear_receive.TabIndex = 11;
            this.Btn_Clear_receive.Text = "Clear";
            this.Btn_Clear_receive.UseVisualStyleBackColor = true;
            this.Btn_Clear_receive.Click += new System.EventHandler(this.Btn_Clear_receive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 1062);
            this.Controls.Add(this.Btn_Clear_receive);
            this.Controls.Add(this.Btc_clear_send);
            this.Controls.Add(this.Lbl_Receive);
            this.Controls.Add(this.lbl_Send);
            this.Controls.Add(this.Txt_Receive);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Txt_Send);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.Cbo_Port);
            this.Controls.Add(this.lal_port);
            this.Name = "Form1";
            this.Text = "Port: ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lal_port;
        private System.Windows.Forms.ComboBox Cbo_Port;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox Txt_Send;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.TextBox Txt_Receive;
        private System.Windows.Forms.Label lbl_Send;
        private System.Windows.Forms.Label Lbl_Receive;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Btc_clear_send;
        private System.Windows.Forms.Button Btn_Clear_receive;
    }
}

