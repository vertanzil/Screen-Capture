using System;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace Screen_Capture{
	public partial class MainForm : Form {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        enum KeyModifier{
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

		public MainForm(){
			InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Control, Keys.D4.GetHashCode());       // Register Shift + A as global hotkey.

            option_copymode.Text = Properties.Settings.Default.sett_copymode;
            option_openinbrowser.Checked = Properties.Settings.Default.sett_openinbrowser;
            option_copytoclipboard.Checked = Properties.Settings.Default.sett_copytoclipboard;

		}
       
		void MainFormLoad(object sender, EventArgs e){
        	notifyicon_main.Visible = true;
		}
        
		void ShowToolStripMenuItemClick(object sender, EventArgs e){
	    	this.WindowState = FormWindowState.Normal;
           	this.Show();
		}
        
		void CaptureToolStripMenuItemClick(object sender, EventArgs e){
            CaptureWindow capture = new CaptureWindow();
            capture.Show();
        }
		void Lbl_noticeClick(object sender, EventArgs e){}
		void GroupBox1Enter(object sender, EventArgs e){}
		
		void QuitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit();
		}
        
		void Button_mainClick(object sender, EventArgs e){
	            this.Visible = false;
	            notifyicon_main.Visible = true;
		}
		void Option_openinbrowserCheckedChanged(object sender, EventArgs e){
			if (option_openinbrowser.Checked == true) {
				lbl_notice.Text = "Open in Browser enabled";
				ScreenCapture.Default.setting_openinbrowser = option_openinbrowser.Checked;
			} else {
				lbl_notice.Text = "Open in Browser Disabled";
				ScreenCapture.Default.setting_openinbrowser = false;
			}
			ScreenCapture.Default.Save();
		}
		
		
		void Option_copytoclipboardCheckedChanged(object sender, EventArgs e){
			if (option_copytoclipboard.Checked == true) {
				lbl_notice.Text = "Copy to Clipboard enabled";
				ScreenCapture.Default.setting_copytoclipboard = option_copytoclipboard.Checked;
			} else {
				lbl_notice.Text = "Copy to Clipboard disabled";
				ScreenCapture.Default.setting_copytoclipboard = false;
			}
			ScreenCapture.Default.Save();
			
		}
		void Option_copymodeSelectedIndexChanged(object sender, EventArgs e){
			if (option_copymode.Text == "Link Mode"){
				ScreenCapture.Default.setting_copymode = option_copymode.SelectedIndex = option_copymode.Items.IndexOf("Link Mode");
			    option_openinbrowser.Enabled = true;
			    option_copytoclipboard.Checked = true;
        	   	lbl_notice.Text = "Link Mode: Copies the link to the clipboard and also can open this in the default browser of your choice";
			  } else {
				ScreenCapture.Default.setting_copymode = option_copymode.SelectedIndex = option_copymode.Items.IndexOf("Image Mode");
			   option_openinbrowser.Enabled = false;
        	   option_openinbrowser.Checked = false;
        	   lbl_notice.Text = "Image Mode: Copies the image to the clipboard. NOTE: Open in Browser is disabled in this mode.";	
			}
        	 ScreenCapture.Default.Save();
		}
		void Notifyicon_mainMouseDoubleClick(object sender, MouseEventArgs e){}
	}
}
	
	
	
	

