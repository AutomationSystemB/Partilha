using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace _192168 {
    public partial class Form1 : Form {
        String[] msgsOK = {
                "Desta vez correu bem",
                "Pronto tá bem, eu faço isso",
                "Não foi fácil, mas tá feito",
                "Aquilo que me pediste, já está pronto",
                "Não falha",

            };
        String[] msgsNOK = {
                "Não sei o que queres dizer com isso",
                "Nao correu bem",
                "Assim não tenho condições",
                "Isso não faz sentido",

            };

        public Form1() {
            InitializeComponent();

            // Carregar as interfaces disponiveis
            List<String> nets = refreshNetworks();
            comboBoxInterface.DataSource = nets;
            int index1 = nets.FindIndex(x => x.Contains("ethernet"));   // Prioritario pois provavelmente foi modificado pelo utilizador
            int index2 = nets.FindIndex(x => x.Contains("Ethernet"));

            if (index1 != -1) {
                comboBoxInterface.SelectedIndex = index1;
            }
            else if (index2 != -1) {
                comboBoxInterface.SelectedIndex = index2;
            }
            
            // Selecionar logo o 3º byte do IP
            textBoxIP.Select();     // Preciso fazer assim duas vezes
            textBoxIP.Select(8, 1); // para conseguir selecionar
        }

        #region Methods
        private bool comando(String cmd, bool runFromShell = false) {
            int result = 0;
            Process p = new Process();  // Start the child process
            p.StartInfo.Verb = "runas";
            p.StartInfo.UseShellExecute = runFromShell;
            p.StartInfo.RedirectStandardOutput = !runFromShell;

            int tok = cmd.IndexOf(' ');
            p.StartInfo.FileName = cmd.Substring(0, tok);// ping ou netsh como comando principal
            p.StartInfo.Arguments = cmd.Substring(tok + 1);// argumentos do comando

            p.Start();
            p.WaitForExit();    // Read the output stream first and then wait.
            result = p.ExitCode;
            p.Close();

            return result == 0 ? true : false;
        }

        private bool comando(String cmd, out String output, bool runFromShell = false) {
            Random rand = new Random();
            int result = 0;
            Process p = new Process();  // Start the child process
            p.StartInfo.Verb = "runas";
            p.StartInfo.UseShellExecute = runFromShell;
            p.StartInfo.RedirectStandardOutput = !runFromShell;

            int tok = cmd.IndexOf(' ');
            p.StartInfo.FileName = cmd.Substring(0, tok);   // ping ou netsh como comando principal
            p.StartInfo.Arguments = cmd.Substring(tok + 1); // argumentos do comando

            p.Start();
            p.WaitForExit();
            result = p.ExitCode;
            output = p.StandardOutput.ReadToEnd();  // Guardar o output do comando
            p.Close();

            return result == 0 ? true : false;
        }

        public void confIP() {
            String nomeRede = comboBoxInterface.Text.Equals("") ? "ethernet" : comboBoxInterface.Text;
            Random rand = new Random();
            
            if (comando("netsh interface ipv4 set address name=\"" + nomeRede + "\" static " + textBoxIP.Text)) {
                labelMsg.ForeColor = Color.Green;
                labelMsg.Text = msgsOK[rand.Next(msgsOK.Length)];
            }
            else {
                labelMsg.ForeColor = Color.Red;
                labelMsg.Text = msgsNOK[rand.Next(msgsNOK.Length)];
            }
        }

        public List<String> refreshNetworks() {
            List<String> allNetworks = new List<String>();
            List<String> allNetworksIP = new List<String>();
            string aux;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces()) {
                
                allNetworks.Add(nic.Name);


                //TODO get IP from interface
                IPInterfaceProperties properties = nic.GetIPProperties();
                foreach (IPAddressInformation uniCast in properties.UnicastAddresses)
                {
                    if (!IPAddress.IsLoopback(uniCast.Address) && uniCast.Address.AddressFamily != AddressFamily.InterNetworkV6)
                    {
                        allNetworksIP.Add(uniCast.Address.ToString());
                    }
                }
            }

            allNetworksIP.Sort();


            allNetworks.Sort();
            return allNetworks;
        }

        #endregion Methods

        // Events
        private void buttonConf_Click(object sender, EventArgs e) {
            confIP();
        }

        private void buttonDHCP_Click(object sender, EventArgs e) {
            String nomeRede = comboBoxInterface.Text.Equals("") ? "ethernet" : comboBoxInterface.Text;
            Random rand = new Random();

            if (comando("netsh interface ip set address \"" + nomeRede + "\" dhcp")) {
                labelMsg.ForeColor = Color.Green;
                labelMsg.Text = msgsOK[rand.Next(msgsOK.Length)];
            }
            else {
                labelMsg.ForeColor = Color.Red;
                labelMsg.Text = msgsNOK[rand.Next(msgsNOK.Length)];
            }
        }

        private void buttonPing_Click(object sender, EventArgs e) {
            comando("ping " + textBoxIP.Text, true);
        }

        private void textBoxIP_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                confIP();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e) {
            comboBoxInterface.DataSource = refreshNetworks();
        }

        private void comboBoxInterface_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
