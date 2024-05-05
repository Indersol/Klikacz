using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Reflection.Metadata;


namespace Klikacz
{
    public partial class Klikacz : Form
    {
        private int centerMouseX;
        private int centerMouseY;
        private bool run = false;
        const int MYACTION_HOTKEY_ID = 65;
        private static object threadLocker = new object();
        List<ListViewItem> LVI = new List<ListViewItem>();
        delegate void UpdateMouseCoordLabelsCallback(string xCoord, string yCoord);
        public Klikacz()
        {
            InitializeComponent();
            KeyPreview = true;
            Thread mouseCoordinateLabelThread = new Thread(() => ContinuallyUpdateMouseCoordLabel());
            mouseCoordinateLabelThread.IsBackground = true;
            mouseCoordinateLabelThread.Start();
            LoadConfig();
        }
        private void AutoClickOnNewThread()
        {
            centerMouseX = Cursor.Position.X;
            centerMouseY = Cursor.Position.Y;
            Thread t = new Thread(AutoClick);
            t.IsBackground = true;
            t.Start();
        }
        private void AutoClick()
        {
            int minWaitTime = int.Parse("2000");
            int maxWaitTime = int.Parse("3000");
            int loop = 0;
            int actualX = 0;
            int actualY = 0;

            if (loopCountTB.Text.Length == 0)
            {
                loop = 1;
            }
            else
            {
                loop = int.Parse(loopCountTB.Text);
            }
            while (this.run)
            {

                isWorkingL.Invoke(new MethodInvoker(() => isWorkingL.Text = "On"));
                Random rnd = new Random();
                for (int i = 1; i <= loop; i++)
                {
                    isWorkingL.Invoke(new MethodInvoker(() => loopNumberLL.Text = i.ToString()));
                    foreach (ListViewItem item in LVI)
                    {
                        if (item.SubItems[3].Text == "-")
                        {
                            int timeBetweenClicks = rnd.Next(minWaitTime, maxWaitTime) + Int32.Parse(item.SubItems[2].Text);
                            actualX = Cursor.Position.X;
                            actualY = Cursor.Position.Y;
                            DoMouseClick(Int32.Parse(item.SubItems[0].Text), Int32.Parse(item.SubItems[1].Text));
                            System.Windows.Forms.Cursor.Position = new Point(actualX, actualY);
                            Thread.Sleep(timeBetweenClicks);
                        }
                        else
                        {
                            char[] keys = item.SubItems[3].Text.ToCharArray();
                            foreach (char key in keys)
                            {
                                isWorkingL.Invoke(new MethodInvoker(() => SendKeys.Send("{" + key + "}")));
                            }
                        }
                    }
                }
                this.run = false;
                isWorkingL.Invoke(new MethodInvoker(() => isWorkingL.Text = "Off"));
                isWorkingL.Invoke(new MethodInvoker(() => EnableSettingFields()));
            }
        }
        private void DoMouseClick(int x, int y)
        {
            if (this.run)
            {
                System.Windows.Forms.Cursor.Position = new Point(x, y);
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;
                Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN | Win32.MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }
        }
        //--------------------Aktualna pozycja kursora
        private void ContinuallyUpdateMouseCoordLabel(int precisionMilliseconds = 60)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(precisionMilliseconds); //Update every 60 milliseconds
                UpdateMouseCoordLabelsCallback updateMouseCoordInvoker = new UpdateMouseCoordLabelsCallback(SetMouseCoordLabels);
                string currentXCoord = Cursor.Position.X.ToString();
                string currentYCoord = Cursor.Position.Y.ToString();
                try
                {
                    this.Invoke(updateMouseCoordInvoker, new object[] { currentXCoord, currentYCoord });
                }
                catch (Exception) { };
            }
        }
        private void SetMouseCoordLabels(string xPos, string yPos)
        {
            this.xPosition.Text = xPos;
            this.yPosition.Text = yPos;
        }
        //--------------------Aktualna pozycja kursora END
        //Start end buttons
        private void startB_Click(object sender, EventArgs e)
        {
            if (!this.run)
                AutoClickOnNewThread();
            this.run = true;
            DisableSettingFields();
        }
        private void endB_Click(object sender, EventArgs e)
        {
            this.run = false;
            EnableSettingFields();
        }
        //Start end buttons END
        //----------------------------------------------------------------CORDS
        private void CordAddButton_Click(object sender, EventArgs e)
        {
            CordAdd(xCordAddTB.Text, yCordAddTB.Text, msCordAddTB.Text);
        }
        private void CordAdd(string x, string y, string m)
        {
            Parametr parametr = new Parametr() { xCord = x, yCord = y, ms = m, key = "-" };
            ListViewItem lista = new ListViewItem();
            lista.Text = parametr.xCord;
            lista.SubItems.Add(parametr.yCord);
            lista.SubItems.Add(parametr.ms);
            lista.SubItems.Add(parametr.key);
            CoordsLV.Items.Add(lista);
            LVI.Add(lista);
        }
        private void Klikacz_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    {
                        xCordAddTB.Text = Cursor.Position.X.ToString();
                        yCordAddTB.Text = Cursor.Position.Y.ToString();
                        CordAdd(Cursor.Position.X.ToString(), Cursor.Position.Y.ToString(), msCordAddTB.Text);
                        break;
                    }
                case Keys.X:
                    {
                        xCordAddTB.Text = Cursor.Position.X.ToString();
                        yCordAddTB.Text = Cursor.Position.Y.ToString();
                        break;
                    }
                case Keys.S:
                    {
                        if (!this.run)
                            AutoClickOnNewThread();
                        this.run = true;
                        DisableSettingFields();
                        break;
                    }
                case Keys.A:
                    {
                        this.run = false;
                        EnableSettingFields();
                        break;
                    }
                default:
                    break;
            }

        }
        private void CordClearButton_Click(object sender, EventArgs e)
        {
            CoordsLV.Items.Clear();
            LVI.Clear();
        }
        //----------------------------------------------------------------CORDS END
        private void EnableSettingFields()
        {
            this.startB.Enabled = true;
        }
        private void DisableSettingFields()
        {
            this.startB.Enabled = false;
        }

        private void Klikacz_MouseDown(object sender, MouseEventArgs e)
        {
            //msCordAddLabel.Focus();
        }
        //-------------------Blokada wpisywania literek do pól
#pragma warning disable CS8602
        private void msCordAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Prevent non-numeric input
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void xCordAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Prevent non-numeric input
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void yCordAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Prevent non-numeric input
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void loopCountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Prevent non-numeric input
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
#pragma warning restore CS8602
        private void keyAddButton_Click(object sender, EventArgs e)
        {
            addKeys(keyTB.Text);
        }
        private void addKeys(string k)
        {
            Parametr parametr = new Parametr() { xCord = "-", yCord = "-", ms = "-", key = k };
            ListViewItem lista = new ListViewItem();
            lista.Text = parametr.xCord;
            lista.SubItems.Add(parametr.yCord);
            lista.SubItems.Add(parametr.ms);
            lista.SubItems.Add(parametr.key);
            CoordsLV.Items.Add(lista);
            LVI.Add(lista);
        }
        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in CoordsLV.SelectedItems)
            {
                CoordsLV.Items.Remove(eachItem);
                LVI.Remove(eachItem);
            }
        }

        private void SaveConfig()
        {
            string exePath = Application.ExecutablePath;
            string fileName = "saved_config.txt";
            string fullPath = Path.Combine(Path.GetDirectoryName(exePath)!, fileName);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (ListViewItem item in LVI)
                {
                    writer.WriteLine(item.SubItems[0].Text + ";" + item.SubItems[1].Text + ";"
                        + item.SubItems[2].Text + ";" + item.SubItems[3].Text);
                }
            }
        }
        private void LoadConfig()
        {
            string exePath = Application.ExecutablePath;
            string fileName = "saved_config.txt";
            string fullPath = Path.Combine(Path.GetDirectoryName(exePath)!, fileName);
            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string line;
                    int counter = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        ListViewItem lista = new ListViewItem();
                        string[] splitParams = line.Split(';');
                        foreach (string param in splitParams)
                        {
                            if (counter == 0)
                            {
                                lista.Text = param;
                            }
                            else
                            {
                                lista.SubItems.Add(param);
                            }
                            counter++;
                        }
                        counter = 0;
                        CoordsLV.Items.Add(lista);
                        LVI.Add(lista);
                    }
                }
            }
        }
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }
    }
}
