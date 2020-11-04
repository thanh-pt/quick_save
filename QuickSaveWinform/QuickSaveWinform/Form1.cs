using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSaveWinform
{
    public partial class Form1 : Form
    {
        string m_lastClipboardData = "";
        string m_dataFileName = "";

        public Form1()
        {
            InitializeComponent();
            initFileName();
            SetClipboardViewer(this.Handle);
        }

        #region CLIPBOARD HANDLE

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        // defined in winuser.h
        const int WM_DRAWCLIPBOARD = 0x308;
        const int WM_CHANGECBCHAIN = 0x030D;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if (Clipboard.ContainsText())
                    {
                        string newClipboardText = Clipboard.GetText();
                        if (newClipboardText != m_lastClipboardData)
                        {
                            m_lastClipboardData = newClipboardText;
                            writeToFile(newClipboardText);
                        }
                    }
                    break;

                case WM_CHANGECBCHAIN:
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

        private void initFileName()
        {
            m_dataFileName = Application.StartupPath + "\\QuickSaveData(" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ").txt";
        }

        private void writeToFile(string data)
        {
            if (m_dataFileName == "")
            {
                return;
            }

            if (File.Exists(m_dataFileName) == false)
            {
                File.WriteAllText(m_dataFileName, data + Environment.NewLine);
                return;
            }
            
            File.AppendAllText(m_dataFileName, data + Environment.NewLine);
            
        }
    }
}
