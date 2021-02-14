using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Drawing.Text;

namespace LeagueBinder
{
    public partial class Updater : MetroFramework.Forms.MetroForm
    {

        Methods Methods = new Methods();
        LCU LCU = new LCU();

        /// <summary>
        /// get client version
        /// download champion info from their api
        /// </summary>
        
        public Updater()
        {
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            Info.Font = new Font(Methods.Lato_Light(), Info.Font.Size);
            AppUpdateCheck();
        }

        async void AppUpdateCheck()
        {
            Info.Text = "Checking for updates.";
            await Task.Delay(1000);
            Info.Text = "Up to date!";
            await Task.Delay(1000);
            ClientOpenCheck();
        }
        async void ClientOpenCheck()
        {
            Info.Text = "Connecting to LCU.";
            if (LCU.Status == false)
            {
                await Task.Delay(1000);
                Info.Text = "Couldn't connect to LCU.";
            }
            else
            {
                await Task.Delay(1000);
                Info.Text = "Connected!";
            }

            await Task.Delay(1000);
            Done();

        }
        void Done()
        {
            this.Hide();
            var form = new Main();
            form.ShowDialog();
            this.Close();
        }
    }
}
