/*
 * Created by SharpDevelop.
 * User: Kyle
 * Date: 08/09/2017
 * Time: 22:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Screen_Capture
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox option_copytoclipboard;
		private System.Windows.Forms.CheckBox option_openinbrowser;
		private System.Windows.Forms.ComboBox option_copymode;
		private System.Windows.Forms.Label lbl_copytoclipboard;
		private System.Windows.Forms.Label lbl_openinbrowser;
		private System.Windows.Forms.Label lbl_mode;
		private System.Windows.Forms.Button button_main;
		private System.Windows.Forms.NotifyIcon notifyicon_main;
		private System.Windows.Forms.ContextMenuStrip menu_main;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.Label lbl_notice;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_main = new System.Windows.Forms.Button();
            this.option_copytoclipboard = new System.Windows.Forms.CheckBox();
            this.option_openinbrowser = new System.Windows.Forms.CheckBox();
            this.option_copymode = new System.Windows.Forms.ComboBox();
            this.lbl_copytoclipboard = new System.Windows.Forms.Label();
            this.lbl_openinbrowser = new System.Windows.Forms.Label();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.notifyicon_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_notice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_main);
            this.groupBox1.Controls.Add(this.option_copytoclipboard);
            this.groupBox1.Controls.Add(this.option_openinbrowser);
            this.groupBox1.Controls.Add(this.option_copymode);
            this.groupBox1.Controls.Add(this.lbl_copytoclipboard);
            this.groupBox1.Controls.Add(this.lbl_openinbrowser);
            this.groupBox1.Controls.Add(this.lbl_mode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
            // 
            // button_main
            // 
            this.button_main.Location = new System.Drawing.Point(214, 119);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(68, 24);
            this.button_main.TabIndex = 21;
            this.button_main.Text = "Done";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.Button_mainClick);
            // 
            // option_copytoclipboard
            // 
            this.option_copytoclipboard.Location = new System.Drawing.Point(119, 105);
            this.option_copytoclipboard.Name = "option_copytoclipboard";
            this.option_copytoclipboard.Size = new System.Drawing.Size(108, 23);
            this.option_copytoclipboard.TabIndex = 6;
            this.option_copytoclipboard.UseVisualStyleBackColor = true;
            this.option_copytoclipboard.CheckedChanged += new System.EventHandler(this.Option_copytoclipboardCheckedChanged);
            // 
            // option_openinbrowser
            // 
            this.option_openinbrowser.Location = new System.Drawing.Point(117, 76);
            this.option_openinbrowser.Name = "option_openinbrowser";
            this.option_openinbrowser.Size = new System.Drawing.Size(108, 23);
            this.option_openinbrowser.TabIndex = 5;
            this.option_openinbrowser.UseVisualStyleBackColor = true;
            this.option_openinbrowser.CheckedChanged += new System.EventHandler(this.Option_openinbrowserCheckedChanged);
            // 
            // option_copymode
            // 
            this.option_copymode.AllowDrop = true;
            this.option_copymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option_copymode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option_copymode.FormattingEnabled = true;
            this.option_copymode.Items.AddRange(new object[] {
            "Image Mode",
            "Link Mode"});
            this.option_copymode.Location = new System.Drawing.Point(117, 40);
            this.option_copymode.Name = "option_copymode";
            this.option_copymode.Size = new System.Drawing.Size(110, 21);
            this.option_copymode.Sorted = true;
            this.option_copymode.TabIndex = 4;
            this.option_copymode.SelectedIndexChanged += new System.EventHandler(this.Option_copymodeSelectedIndexChanged);
            // 
            // lbl_copytoclipboard
            // 
            this.lbl_copytoclipboard.Location = new System.Drawing.Point(17, 113);
            this.lbl_copytoclipboard.Name = "lbl_copytoclipboard";
            this.lbl_copytoclipboard.Size = new System.Drawing.Size(96, 15);
            this.lbl_copytoclipboard.TabIndex = 3;
            this.lbl_copytoclipboard.Text = "Copy to Clipboard:";
            // 
            // lbl_openinbrowser
            // 
            this.lbl_openinbrowser.Location = new System.Drawing.Point(17, 80);
            this.lbl_openinbrowser.Name = "lbl_openinbrowser";
            this.lbl_openinbrowser.Size = new System.Drawing.Size(108, 19);
            this.lbl_openinbrowser.TabIndex = 2;
            this.lbl_openinbrowser.Text = "Open in Browser:";
            // 
            // lbl_mode
            // 
            this.lbl_mode.Location = new System.Drawing.Point(17, 43);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(68, 19);
            this.lbl_mode.TabIndex = 1;
            this.lbl_mode.Text = "Copy Mode:";
            // 
            // notifyicon_main
            // 
            this.notifyicon_main.BalloonTipText = "Loaded";
            this.notifyicon_main.BalloonTipTitle = "Screen Grabber";
            this.notifyicon_main.ContextMenuStrip = this.menu_main;
            this.notifyicon_main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyicon_main.Icon")));
            this.notifyicon_main.Text = "Screen  Grabber";
            this.notifyicon_main.Visible = true;
            this.notifyicon_main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notifyicon_mainMouseDoubleClick);
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menu_main.Name = "contextMenuStrip1";
            this.menu_main.Size = new System.Drawing.Size(117, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.AutoSize = false;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItemClick);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.captureToolStripMenuItem.Text = "Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.CaptureToolStripMenuItemClick);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItemClick);
            // 
            // lbl_notice
            // 
            this.lbl_notice.Location = new System.Drawing.Point(12, 164);
            this.lbl_notice.Name = "lbl_notice";
            this.lbl_notice.Size = new System.Drawing.Size(286, 15);
            this.lbl_notice.TabIndex = 2;
            this.lbl_notice.Click += new System.EventHandler(this.Lbl_noticeClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 187);
            this.Controls.Add(this.lbl_notice);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Screen Capture";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.menu_main.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}
