namespace MyDijkstra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnResult = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtEndPoint = new System.Windows.Forms.TextBox();
			this.txtStartPoint = new System.Windows.Forms.TextBox();
			this.txtPoint = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbPoint = new System.Windows.Forms.Label();
			this.panelControl = new System.Windows.Forms.Panel();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnPath = new System.Windows.Forms.Button();
			this.btnPoint = new System.Windows.Forms.Button();
			this.panel_graphic = new System.Windows.Forms.Panel();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(17, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(277, 10);
			this.label9.TabIndex = 6;
			this.label9.Text = "__________________________________________";
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(14, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(280, 10);
			this.label8.TabIndex = 6;
			this.label8.Text = "__________________________________________";
			// 
			// btnResult
			// 
			this.btnResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnResult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
			this.btnResult.Location = new System.Drawing.Point(38, 297);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(88, 33);
			this.btnResult.TabIndex = 2;
			this.btnResult.Text = "Kết quả";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(125, 87);
			this.txtPath.Multiline = true;
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(123, 33);
			this.txtPath.TabIndex = 1;
			this.txtPath.Text = "7";
			this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtEndPoint
			// 
			this.txtEndPoint.Location = new System.Drawing.Point(125, 167);
			this.txtEndPoint.Multiline = true;
			this.txtEndPoint.Name = "txtEndPoint";
			this.txtEndPoint.Size = new System.Drawing.Size(123, 36);
			this.txtEndPoint.TabIndex = 1;
			// 
			// txtStartPoint
			// 
			this.txtStartPoint.Location = new System.Drawing.Point(125, 126);
			this.txtStartPoint.Multiline = true;
			this.txtStartPoint.Name = "txtStartPoint";
			this.txtStartPoint.Size = new System.Drawing.Size(123, 35);
			this.txtStartPoint.TabIndex = 1;
			// 
			// txtPoint
			// 
			this.txtPoint.Location = new System.Drawing.Point(125, 47);
			this.txtPoint.Multiline = true;
			this.txtPoint.Name = "txtPoint";
			this.txtPoint.Size = new System.Drawing.Size(123, 34);
			this.txtPoint.TabIndex = 1;
			this.txtPoint.Text = "6";
			this.txtPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 14);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số đường nối";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 14);
			this.label5.TabIndex = 0;
			this.label5.Text = "Điểm kết thúc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 14);
			this.label4.TabIndex = 0;
			this.label4.Text = "Điểm bắt đầu";
			// 
			// lbPoint
			// 
			this.lbPoint.AutoSize = true;
			this.lbPoint.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPoint.Location = new System.Drawing.Point(17, 58);
			this.lbPoint.Name = "lbPoint";
			this.lbPoint.Size = new System.Drawing.Size(56, 14);
			this.lbPoint.TabIndex = 0;
			this.lbPoint.Text = "Số đỉnh";
			// 
			// panelControl
			// 
			this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelControl.Controls.Add(this.btnReset);
			this.panelControl.Controls.Add(this.btnPath);
			this.panelControl.Controls.Add(this.btnPoint);
			this.panelControl.Controls.Add(this.label9);
			this.panelControl.Controls.Add(this.label8);
			this.panelControl.Controls.Add(this.btnResult);
			this.panelControl.Controls.Add(this.txtPath);
			this.panelControl.Controls.Add(this.txtEndPoint);
			this.panelControl.Controls.Add(this.txtStartPoint);
			this.panelControl.Controls.Add(this.txtPoint);
			this.panelControl.Controls.Add(this.label3);
			this.panelControl.Controls.Add(this.label5);
			this.panelControl.Controls.Add(this.label4);
			this.panelControl.Controls.Add(this.lbPoint);
			this.panelControl.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.panelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelControl.Location = new System.Drawing.Point(3, 8);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(323, 424);
			this.panelControl.TabIndex = 4;
			// 
			// btnReset
			// 
			this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnReset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
			this.btnReset.Location = new System.Drawing.Point(156, 297);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 33);
			this.btnReset.TabIndex = 11;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnPath
			// 
			this.btnPath.Location = new System.Drawing.Point(255, 86);
			this.btnPath.Name = "btnPath";
			this.btnPath.Size = new System.Drawing.Size(50, 34);
			this.btnPath.TabIndex = 10;
			this.btnPath.Text = "OK";
			this.btnPath.UseVisualStyleBackColor = true;
			this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
			// 
			// btnPoint
			// 
			this.btnPoint.Location = new System.Drawing.Point(255, 47);
			this.btnPoint.Name = "btnPoint";
			this.btnPoint.Size = new System.Drawing.Size(50, 34);
			this.btnPoint.TabIndex = 9;
			this.btnPoint.Text = "OK";
			this.btnPoint.UseVisualStyleBackColor = true;
			this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
			// 
			// panel_graphic
			// 
			this.panel_graphic.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel_graphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel_graphic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_graphic.Location = new System.Drawing.Point(332, 9);
			this.panel_graphic.Name = "panel_graphic";
			this.panel_graphic.Size = new System.Drawing.Size(656, 423);
			this.panel_graphic.TabIndex = 3;
			this.panel_graphic.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_graphic_Paint);
			// 
			// txtLog
			// 
			this.txtLog.Location = new System.Drawing.Point(95, 451);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(595, 36);
			this.txtLog.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 463);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "LOG:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 513);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.panelControl);
			this.Controls.Add(this.panel_graphic);
			this.Name = "Form1";
			this.Text = "MyDijkstraGUI";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelControl.ResumeLayout(false);
			this.panelControl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.TextBox txtEndPoint;
		private System.Windows.Forms.TextBox txtStartPoint;
		private System.Windows.Forms.TextBox txtPoint;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbPoint;
		private System.Windows.Forms.Panel panelControl;
		private System.Windows.Forms.Panel panel_graphic;
		private System.Windows.Forms.Button btnPath;
		private System.Windows.Forms.Button btnPoint;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Label label1;
	}
}

