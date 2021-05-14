using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isIpValid(string address)
        {
            if (address.Replace(".", "").All(Char.IsDigit) && address.Split('.').Length == 4 && address.Split('.').All(element => int.Parse(element) < 256 && int.Parse(element) >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        byte isNetmaskValid(string netmask)
        {
            if(netmask != String.Empty && netmask.Replace("/", "").All(Char.IsDigit) && int.Parse(netmask.Replace("/", "")) >= 0 && int.Parse(netmask.Replace("/", "")) < 32)
            {
                return 0;
            }
            else if (netmask.Replace(".", "").All(Char.IsDigit) && netmask.Split('.').Length == 4 && netmask.Split('.').All(element => int.Parse(element) < 256 && int.Parse(element) >= 0) && int.Parse(netmask.Split('.')[3]) != 255)
            {
                string netmaskElements = string.Join("", netmask.Split('.').Select(x => decToBin(int.Parse(x)).ToString().PadLeft(8, '0')).ToArray());
                if (!netmaskElements.Contains("01"))
                {
                    return 1;

                }
                else
                {
                    return 2;
                }
            } else
            {
                return 2;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            byte nmtype = isNetmaskValid(MaskTextBox.Text);
            if (!isIpValid(IPAddressTextBox.Text))
            {
                MessageBox.Show("IP Address is invalid");
            }
            else if (nmtype == 2)
            {
                MessageBox.Show("Netmask is invalid");
            }
            else
            {
                string[] ipArray = IPAddressTextBox.Text.Split('.');
                string[] maskArray, networkArray, broadcastArray, hostMinArray, hostMaxArray;
                char netclass = '-';
                double hostsNet;
                
                if (nmtype == 0)
                {
                    string temp = new string('1', int.Parse(MaskTextBox.Text.Replace("/", ""))) + new string('0', 32 - int.Parse(MaskTextBox.Text.Replace("/", "")));
                    
                    maskArray = new string[] { binToDec(temp.Substring(0, 8)).ToString(), binToDec(temp.Substring(8, 8)).ToString(), binToDec(temp.Substring(16, 8)).ToString(), binToDec(temp.Substring(24, 8)).ToString() };
                }
                else
                {
                    maskArray = MaskTextBox.Text.Split('.');
                }
                networkArray = new string[] { (int.Parse(ipArray[0]) & int.Parse(maskArray[0])).ToString(), (int.Parse(ipArray[1]) & int.Parse(maskArray[1])).ToString(), (int.Parse(ipArray[2]) & int.Parse(maskArray[2])).ToString(), (int.Parse(ipArray[3]) & int.Parse(maskArray[3])).ToString() };
                NetworkLabel.Text = networkArray[0] + "." + networkArray[1] + "." + networkArray[2] + "." + networkArray[3];
                NetworkBinLabel.Text = decToBin(int.Parse(networkArray[0])).PadLeft(8, '0') + "." + decToBin(int.Parse(networkArray[1])).PadLeft(8, '0') + "." + decToBin(int.Parse(networkArray[2])).PadLeft(8, '0') + "." + decToBin(int.Parse(networkArray[3])).PadLeft(8, '0');
                if (int.Parse(ipArray[0]) >= 0 && int.Parse(ipArray[0]) <= 127)
                {
                    netclass = 'A';
                }
                else if (int.Parse(ipArray[0]) >= 128 && int.Parse(ipArray[0]) <= 191)
                {
                    netclass = 'B';
                }
                else if (int.Parse(ipArray[0]) >= 192 && int.Parse(ipArray[0]) <= 223)
                {
                    netclass = 'C';
                }
                else if (int.Parse(ipArray[0]) >= 224 && int.Parse(ipArray[0]) <= 239)
                {
                    netclass = 'D';
                }
                else if (int.Parse(ipArray[0]) >= 240 && int.Parse(ipArray[0]) <= 255)
                {
                    netclass = 'E';
                }
                ClassLabel.Text = netclass.ToString();
                broadcastArray = new string[] { (~Convert.ToByte(maskArray[0]) + 256 + int.Parse(networkArray[0])).ToString(), (~Convert.ToByte(maskArray[1]) + 256 + int.Parse(networkArray[1])).ToString(), (~Convert.ToByte(maskArray[2]) + 256 + int.Parse(networkArray[2])).ToString(), (~Convert.ToByte(maskArray[3]) + 256 + int.Parse(networkArray[3])).ToString() };
                BroadcastLabel.Text = broadcastArray[0] + "." + broadcastArray[1] + "." + broadcastArray[2] + "." + broadcastArray[3];
                BroadcastBinLabel.Text = decToBin(int.Parse(broadcastArray[0])).PadLeft(8, '0') + "." + decToBin(int.Parse(broadcastArray[1])).PadLeft(8, '0') + "." + decToBin(int.Parse(broadcastArray[2])).PadLeft(8, '0') + "." + decToBin(int.Parse(broadcastArray[3])).PadLeft(8, '0');
                hostMinArray = new string[] { networkArray[0], networkArray[1], networkArray[2], (int.Parse(networkArray[3]) + 1).ToString() };
                HostMinLabel.Text = hostMinArray[0] + "." + hostMinArray[1] + "." + hostMinArray[2] + "." + hostMinArray[3];
                HostMinBinLabel.Text = decToBin(int.Parse(hostMinArray[0])).PadLeft(8, '0') + "." + decToBin(int.Parse(hostMinArray[1])).PadLeft(8, '0') + "." + decToBin(int.Parse(hostMinArray[2])).PadLeft(8, '0') + "." + decToBin(int.Parse(hostMinArray[3])).PadLeft(8, '0');
                hostMaxArray = new string[] { broadcastArray[0], broadcastArray[1], broadcastArray[2], (int.Parse(broadcastArray[3]) - 1).ToString() };
                HostMaxLabel.Text = hostMaxArray[0] + "." + hostMaxArray[1] + "." + hostMaxArray[2] + "." + hostMaxArray[3];
                HostMaxBinLabel.Text = decToBin(int.Parse(hostMaxArray[0])).PadLeft(8, '0') + "." + decToBin(int.Parse(hostMaxArray[1])).PadLeft(8, '0') + "." + decToBin(int.Parse(hostMaxArray[2])).PadLeft(8, '0') + "." + decToBin(int.Parse(hostMaxArray[3])).PadLeft(8, '0');               
                hostsNet = Math.Pow(2, 32 - (decToBin(int.Parse(maskArray[0])).PadLeft(8, '0') + decToBin(int.Parse(maskArray[1])).PadLeft(8, '0') + decToBin(int.Parse(maskArray[2])).PadLeft(8, '0') + decToBin(int.Parse(maskArray[3])).PadLeft(8, '0')).Replace("0", "").Length) - 2;                
                HostsAmountLabel.Text = hostsNet.ToString();
                NoteLabel.Text = GenerateNote(ipArray, netclass);
            }         
        }

        string decToBin(int num)
        {
            return Convert.ToString(num, 2);
        }

        int binToDec(string num)
        {
            return Convert.ToInt32(num, 2);
        }

        string GenerateNote(string[] ip, char netclass)
        {
            MessageBox.Show(ip[0] + "." + ip[1] + "." + ip[2] + "." + ip[3]);
            string note = "Note:";
            if (netclass == 'D')
            {
                note += " This address belongs to class D. Class D addresses are reserved for multicast\ngroups.";
            } 
            else if (netclass == 'E')
            {
                note += " This address belongs to class E. Class E addresses are reserved for future use,\nor research and development purposes.";
            }
            if ((int.Parse(ip[0]) == 10) || (int.Parse(ip[0]) == 172 && int.Parse(ip[1]) >= 16 && int.Parse(ip[1]) <= 31) || (int.Parse(ip[0]) == 192 && int.Parse(ip[1]) == 168))
            {
                note += " This address belongs to class " + netclass.ToString() + " private IP addresses space.";
            }
            if (int.Parse(ip[0]) == 169 && int.Parse(ip[1]) == 254)
            {
                note += " This address belongs to APIPA addresses space.";
            }
            if (int.Parse(ip[0]) == 127)
            {
                note += " This is localhost address. It refers to current computer used to access it.";
            }
            else if (int.Parse(ip[0]) == 8 && int.Parse(ip[1]) == 8 && ((int.Parse(ip[2]) == 8 && int.Parse(ip[3]) == 8) || (int.Parse(ip[2]) == 4 && int.Parse(ip[3]) == 4)))
            {
                note += " This is the address of the public dns server. The server provider is Google.";
            }
            else if ((int.Parse(ip[0]) == 9 && int.Parse(ip[1]) == 9 && int.Parse(ip[2]) == 9 && int.Parse(ip[3]) == 9) || (int.Parse(ip[0]) == 149 && int.Parse(ip[1]) == 112 && int.Parse(ip[2]) == 112 && int.Parse(ip[3]) == 112))
            {
                note += " This is the address of the public dns server. The server provider is Quad9.";
            }
            else if ((int.Parse(ip[0]) == 208 && int.Parse(ip[1]) == 67 && int.Parse(ip[2]) == 222 && int.Parse(ip[3]) == 222) || (int.Parse(ip[0]) == 208 && int.Parse(ip[1]) == 67 && int.Parse(ip[2]) == 220 && int.Parse(ip[3]) == 220))
            {
                note += " This is the address of the public dns server. The server provider is OpenDNS Home.";
            }
            else if ((int.Parse(ip[0]) == 1 && int.Parse(ip[1]) == 1 && int.Parse(ip[2]) == 1 && int.Parse(ip[3]) == 1) || (int.Parse(ip[0]) == 1 && int.Parse(ip[1]) == 0 && int.Parse(ip[2]) == 0 && int.Parse(ip[3]) == 1))
            {
                note += " This is the address of the public dns server. The server provider is Cloudflare.";
            }
            else if ((int.Parse(ip[0]) == 185 && int.Parse(ip[1]) == 228 && int.Parse(ip[2]) == 168 && int.Parse(ip[3]) == 9) || (int.Parse(ip[0]) == 185 && int.Parse(ip[1]) == 228 && int.Parse(ip[2]) == 169 && int.Parse(ip[3]) == 9))
            {
                note += " This is the address of the public dns server. The server provider is CleanBrowsing.";
            }
            else if ((int.Parse(ip[0]) == 76 && int.Parse(ip[1]) == 76 && int.Parse(ip[2]) == 19 && int.Parse(ip[3]) == 19) || (int.Parse(ip[0]) == 76 && int.Parse(ip[1]) == 223 && int.Parse(ip[2]) == 122 && int.Parse(ip[3]) == 150))
            {
                note += " This is the address of the public dns server. The server provider is Alternate DNS.";
            }
            else if ((int.Parse(ip[0]) == 94 && int.Parse(ip[1]) == 140 && int.Parse(ip[2]) == 14 && int.Parse(ip[3]) == 14) || (int.Parse(ip[0]) == 94 && int.Parse(ip[1]) == 140 && int.Parse(ip[2]) == 15 && int.Parse(ip[3]) == 15))
            {
                note += " This is the address of the public dns server. The server provider is AdGuard DNS.";
            }
            else if (int.Parse(ip[0]) == 0)
            {
                note += " This address is a non-routable meta-address used to designate an invalid,\nunknown or non-applicable target.";
            }
            else if (int.Parse(ip[0]) == 100 && int.Parse(ip[1]) >= 64 && int.Parse(ip[1]) <= 127)
            {
                note += " This address belongs to shared address space that is used for communications\nbetween a service provider and its subscribers when using a carrier-grade NAT.";
            }
            else if (int.Parse(ip[0]) == 192 && int.Parse(ip[1]) == 0 && int.Parse(ip[2]) == 0)
            {
                note += " This address belongs to IETF Protocol Assignments addresses space.";
            }
            else if (int.Parse(ip[0]) == 192 && int.Parse(ip[1]) == 0 && int.Parse(ip[2]) == 2)
            {
                note += " This address is assigned as TEST-NET-1, and it's used for documentation and\nexamples.";
            }
            else if (int.Parse(ip[0]) == 192 && int.Parse(ip[1]) == 88 && int.Parse(ip[2]) == 99)
            {
                note += " This address is reserved. Formerly was used for IPv6 to IPv4 relay(included\nIPv6 address block 2002::/16).";
            }
            else if (int.Parse(ip[0]) == 198 && int.Parse(ip[1]) >= 18 && int.Parse(ip[1]) <= 19)
            {
                note += " This address is used for benchmark testing of inter-network communications\nbetween two separate subnets.";
            }
            else if (int.Parse(ip[0]) == 198 && int.Parse(ip[1]) == 51 && int.Parse(ip[2]) == 100)
            {
                note += " This address is assigned as TEST-NET-2, and it's used for documentation and\nexamples.";
            }
            else if (int.Parse(ip[0]) == 203 && int.Parse(ip[1]) == 0 && int.Parse(ip[2]) == 113)
            {
                note += " This address is assigned as TEST-NET-3, and it's used for documentation and\nexamples.";
            }
            else if (int.Parse(ip[0]) == 233 && int.Parse(ip[1]) == 252 && int.Parse(ip[2]) == 0)
            {
                note += " This address is assigned as MCAST-TEST-NET, and it's used for documentation\nand examples.";
            }
            else if (int.Parse(ip[0]) == 255 && int.Parse(ip[1]) == 255 && int.Parse(ip[2]) == 255 && int.Parse(ip[3]) == 255)
            {
                note += " This address is reserved for the \"limited broadcast\" destination address.";
            }
            if (note == "Note:")
            {
                return "Note: None";
            }
            else
            {
                return note;
            }
            
        }
    }
}
