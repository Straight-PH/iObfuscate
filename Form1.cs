using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iObfuscate
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Data = textBox1.Text;
            string Name = maskedTextBox1.Text;

            StartObfuscation(Data, Name);
        }

      
        static void StartObfuscation(string Content, string Name)
        {
            string j = "码表示成不同的二进制格式的编码规则";
            char[] Salt = j.ToCharArray();
            Random r = new Random();
            string Junk = "ⓛஐ→あⓛⓞⓥⓔ｡°ºⓛஐ→あⓛⓞⓥⓔ｡°ºஐ→あⓛⓞⓥⓔ｡°º｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°｡°";
            string UTF16arrow = "→好→处→在→于→大→部→分→字→符→都→以→固→定→长→度→的→字→节→";
            string UTF16 = "然后从 \"中\" 字的最后一个二进制位开始，按照从后向前的顺序依次填入格式中的 x 字符，多出的二进制补为 0， 具体如上图 步骤2、步骤3 所示然后从 \"中\" 字的最后一个二进制位开始，按照从后向前的顺序依次填入格式中的 x 字符，多出的二进制补为 0， 具体如上图 步骤2、步骤3 所示然后从 \"中\" 字的最后一个二进制位开始，按照从后向前的顺序依次填入格式中的 x 字符，多出的二进制补为 0， 具体如上图 步骤2、步骤3 所示然后从 \"中\" 字的最后一个二进制位开始，按照从后向前的顺序依次填入格式中的 x 字符，多出的二进制补为 0， 具体如上图 步骤2、步骤3 所示";
            string Alphabets = "abcdefghijklmnopqrstuvwxyz";
            char[] AlphArray = Alphabets.ToCharArray();

            foreach (char letter in Content)
            {
                if (letter == ':')
                {
                    Content.Replace(letter, '\n');
                }
            }

            File.WriteAllText($"Obfuscated_{Name}", ":: Obfuscated By iobfuscate\n@echo off\n:: %?%@%?%e%?%c%?%h%?%o o%?%f%?%f");

            for (int x = 0; x <= 100; x++)
            {
                var buildere = new StringBuilder();
                int counted = 0;
                foreach (var c in UTF16)
                {
                    buildere.Append(c);
                    if ((++counted % 1) == 0)
                    {
                        buildere.Append("%?%");
                    }
                }

                File.AppendAllText($"Obfuscated_{Name}", $":: " + buildere.ToString());
            }
            for (int x = 0; x <= 100; x++)
            {
                string ContentOB = File.ReadAllText($"Obfuscated_{Name}");
                string RandValue = RandomStringer();
                string RandomVar = RandomVariabler();

                if (!ContentOB.Contains(RandValue))
                {
                    File.AppendAllText($"Obfuscated_{Name}", $"\n:: set {RandomVar.ToLower()}={RandValue.ToLower()}");
                }
            }
            File.AppendAllText($"Obfuscated_{Name}", "%?%@%?%e%?%c%?%h%?%o o%?%f%?%f");

            Content = Content.Replace("@echo off", "");
            var builder = new StringBuilder();
            int count = 0;
            foreach(char letter in Salt)
            {
                foreach (var c in Content)
                {
                    builder.Append(c);
                    if ((++count % 1) == 0)
                    {
                        builder.Append("%" + letter.ToString() + "%");
                    }
                }
            }
            Content = builder.ToString();
            File.AppendAllText($"Obfuscated_{Name}", Content);
            File.AppendAllText($"Obfuscated_{Name}", "\n\n");

            for (int x = 0; x <= 100; x++)
            {
                string ContentOB = File.ReadAllText($"Obfuscated_{Name}");
                string RandValue = RandomStringer();
                string RandomVar = RandomVariabler();

                if (!ContentOB.Contains(RandValue))
                {
                    File.AppendAllText($"Obfuscated_{Name}", $"\n:: set {RandomVar.ToLower()}={RandValue.ToLower()}");
                }
            }
            Content = Junk;
            var buildered = new StringBuilder();
            int counte = 0;
            foreach (var c in Content)
            {
                builder.Append(c);
                if ((++counte % 1) == 0)
                {
                    builder.Append("→后→");
                }
            }

            for (int y = 0; y <= 25; y++)
            {
                File.AppendAllText($"Obfuscated_{Name}", ":: " + Junk + "\n:: " + Junk);
            }

            for (int xe = 0; xe <= 50; xe++)
            {
                File.AppendAllText($"Obfuscated_{Name}", ":: " + UTF16arrow + "\n:: " + UTF16arrow);
            }
            Console.Beep();
            MessageBox.Show($"{Name} Has Been Successfully Obfuscated!", "iObfuscator");
        }

        public static string RandomStringer()
        {
            Random r = new Random();
            string Final = "";
            string Alphabets = "abcdefghijklmnopqrstuvwxyz";
            char[] AlphArray = Alphabets.ToCharArray();

            for (int x = 0; x <= 200; x++)
            {
                Final = Final + AlphArray[r.Next(0, AlphArray.Length)];
            }

            return Final;
        }

        public static string RandomVariabler()
        {
            int Length = 1;
            string Final = "";
            Random r = new Random();
            int[] Selecter = { 1, 2, 3, 4, 5 };

            string e = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] Chars = e.ToCharArray();
            int Decider = Selecter[r.Next(0, Selecter.Length)];

            if (Decider == 0)
            {
                Length = 9;
            }
            if (Decider == 1)
            {
                Length = 8;
            }
            if (Decider == 2)
            {
                Length = 12;
            }
            if (Decider == 3)
            {
                Length = 13;
            }
            if (Decider == 4)
            {
                Length = 25;
            }
            if (Decider == 5)
            {
                Length = 15;
            }

            for (int x = 0; x <= Length; x++)
            {
                Final = Final + Chars[r.Next(0, Chars.Length)];
            }

            return Final;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.ShowIcon = false;
            Console.Beep();
            MessageBox.Show("The Program Might Freeze While Obfuscating, Which Can Take Some Time...", "iObfuscate");
        }
    }
}
