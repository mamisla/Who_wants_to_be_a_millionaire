using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;



namespace Who_wants_to_be_a_millionaire
{
    
   
    public partial class Form1 : Form
    {
        
        public string toc = "";
        public int trenp = 1;
        public static string jsonString1 = File.ReadAllText("1.txt");
        public static string jsonString2 = File.ReadAllText("2.txt");
        public static string jsonString3 = File.ReadAllText("3.txt");
        public static string jsonString4 = File.ReadAllText("4.txt");
        public static string jsonString5 = File.ReadAllText("5.txt");
        public static string jsonString6 = File.ReadAllText("6.txt");
        public static string jsonString7 = File.ReadAllText("7.txt");
        public static string jsonString8 = File.ReadAllText("8.txt");
        public static string jsonString9 = File.ReadAllText("9.txt");
        public static string jsonString10 = File.ReadAllText("10.txt");
        public static string jsonString11 = File.ReadAllText("11.txt");
        public static string jsonString12 = File.ReadAllText("12.txt");
        public static string jsonString13 = File.ReadAllText("13.txt");
        public static string jsonString14 = File.ReadAllText("14.txt");
        public static string jsonString15 = File.ReadAllText("15.txt");

        public class pitodg
        {
            public string pit { get; set; }
            public string a { get; set; }
            public string b { get; set; }
            public string c { get; set; }
            public string d { get; set; }
            public string t { get; set; }
        }
        public Form1()
        { 
            InitializeComponent();
            Random rnd = new Random();

            var pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString1);

            int p = rnd.Next(pitanje.Count());

            this.pit.Text = pitanje[p].pit;
            this.a.Text = pitanje[p].a;
            this.b.Text = pitanje[p].b;
            this.c.Text = pitanje[p].c;
            this.d.Text = pitanje[p].d;
            toc = pitanje[p].t;

            this.redni.Text = trenp.ToString();

            potrosen_joker_50.Visible = false;
            potrosen_joker_zovi.Visible = false;
            potrosen_joker_publika.Visible = false;

            splitContainer1.SplitterDistance = 800;
            splitContainer1.BackColor = Color.Black;

            obojaj();

            

        }

        private void obojaj()
        {
            flowLayoutPanel1.Controls.Clear();
            var j = 15;

            for (int i = 0; i < 15; ++i)
            {
                var kontrola = new TextBox()
                {
                    Text = j.ToString()

                };
                kontrola.Margin = new Padding(0, 1, 0, 1);
                kontrola.Width = 230;
                kontrola.Height = 100;
                kontrola.ForeColor = Color.Orange;
                kontrola.BackColor = Color.Black;
                kontrola.Font = new Font(Font.FontFamily, 11);
                kontrola.ReadOnly = true;
                kontrola.BorderStyle = System.Windows.Forms.BorderStyle.None;
                --j;

                flowLayoutPanel1.Controls.Add(kontrola);


            }
            flowLayoutPanel1.Controls[0].Text += "    " + "1.000.000 KN";
            flowLayoutPanel1.Controls[0].ForeColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls[1].Text += "    " + "500.000 KN";
            flowLayoutPanel1.Controls[2].Text += "    " + "250.000 KN";
            flowLayoutPanel1.Controls[3].Text += "    " + "125.000 KN";
            flowLayoutPanel1.Controls[4].Text += "    " + "64.000 KN";
            flowLayoutPanel1.Controls[5].Text += "    " + "32.000 KN";
            flowLayoutPanel1.Controls[5].ForeColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls[6].Text += "    " + "16.000 KN";
            flowLayoutPanel1.Controls[7].Text += "    " + "8.000 KN";
            flowLayoutPanel1.Controls[8].Text += "    " + "4.000 KN";
            flowLayoutPanel1.Controls[9].Text += "    " + "2.000 KN";
            flowLayoutPanel1.Controls[10].Text += "    " + "1.000 KN";
            flowLayoutPanel1.Controls[10].ForeColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls[11].Text += "    " + "500 KN";
            flowLayoutPanel1.Controls[12].Text += "    " + "300 KN";
            flowLayoutPanel1.Controls[13].Text += "    " + "200 KN";
            flowLayoutPanel1.Controls[14].Text += "    " + "100 KN";
            flowLayoutPanel1.Controls[14].ForeColor = Color.WhiteSmoke;


            if (redni.Text.ToString() == "1")
            {
                flowLayoutPanel1.Controls[14].BackColor = Color.Orange;
                flowLayoutPanel1.Controls[14].ForeColor = Color.Black;
            }



        }


        private void pit_Click(object sender, EventArgs e)
        {

        }
        private void a_Click(object sender, EventArgs e)
        {
            if (this.a.Text == "") return;
            if (toc == "a")
            {
                obradi_tocan();
            }
            else
            {
                obradi_krivi();
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            if (this.b.Text == "") return;
            if (toc == "b")
            {
                obradi_tocan();
            }
            else
            {
                obradi_krivi();
            }

           
        }

        private void c_Click(object sender, EventArgs e)
        {
            if (this.c.Text == "") return;
            if (toc == "c") { 
                obradi_tocan();
            }
            else
            {
                obradi_krivi();
            }
            
        }

        private void d_Click(object sender, EventArgs e)
        {
            if (this.d.Text == "") return;
            if (toc == "d")
            {
                obradi_tocan();
            }
            else
            {
                obradi_krivi();
            }
        }

        public void obradi_tocan()
        {
            trenp++;

            if (trenp == 16) { MessageBox.Show("Ti si osvojio milju."); obradi_krivi(); return; }

            Random rnd = new Random();

            List<pitodg> pitanje = null;
            switch (trenp)
            {
                case 1:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString1);
                    break;
                case 2:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString2);
                    break;
                case 3:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString3);
                    break;
                case 4:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString4);
                    break;
                case 5:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString5);
                    break;
                case 6:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString6);
                    break;
                case 7:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString7);
                    break;
                case 8:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString8);
                    break;
                case 9:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString9);
                    break;
                case 10:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString10);
                    break;
                case 11:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString11);
                    break;
                case 12:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString12);
                    break;
                case 13:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString13);
                    break;
                case 14:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString14);
                    break;
                case 15:
                    pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString15);
                    break;
                default:
                    break;
            }
            int p = rnd.Next(pitanje.Count());

            this.pit.Text = pitanje[p].pit;
            this.a.Text = pitanje[p].a;
            this.b.Text = pitanje[p].b;
            this.c.Text = pitanje[p].c;
            this.d.Text = pitanje[p].d;
            toc = pitanje[p].t;

            this.redni.Text = trenp.ToString();


            obojaj();
            flowLayoutPanel1.Controls[15 - int.Parse(redni.Text)].BackColor = Color.Orange;
            flowLayoutPanel1.Controls[15 - int.Parse(redni.Text)].ForeColor = Color.Black;
        }

        public void obradi_krivi()
        {
            Random rnd = new Random();

            trenp = 1;
            var pitanje = JsonSerializer.Deserialize<List<pitodg>>(jsonString1);

            int p = rnd.Next(pitanje.Count());

            this.pit.Text = pitanje[p].pit;
            this.a.Text = pitanje[p].a;
            this.b.Text = pitanje[p].b;
            this.c.Text = pitanje[p].c;
            this.d.Text = pitanje[p].d;
            toc = pitanje[p].t;

            potrosen_joker_50.Visible = false;
            potrosen_joker_zovi.Visible = false;
            potrosen_joker_publika.Visible = false;

            this.redni.Text = trenp.ToString();
            obojaj();
        }

        private void joker50_Click(object sender, EventArgs e)
        {
            potrosen_joker_50.Visible = true;
            int p;
            int k = 0;
            Random rnd = new Random();


            while (k < 2)
            {
                p = rnd.Next(4);
                switch (p)
                {
                    case 0:
                        if (toc != "a" && this.a.Text != "") { this.a.Text = ""; k++; }
                        break;
                    case 1:
                        if (toc != "b" && this.b.Text != "") { this.b.Text = ""; k++; }
                        break;
                    case 2:
                        if (toc != "c" && this.c.Text != "") { this.c.Text = ""; k++; }
                        break;
                    case 3:
                        if (toc != "d" && this.d.Text != "") { this.d.Text = ""; k++; }
                        break;
                }
            }
        }

        public void Obradi_joker_zovi(int p, int p1)
        {
            Random rnd = new Random();
            if (p < p1)
            {
                MessageBox.Show(string.Format("Odgovor je {0}.", toc));
            }
            else
            {
                int r;
                int k = 0;

                while (k == 0)
                {
                    r = rnd.Next(4);
                    switch (r)
                    {
                        case 0:
                            if (toc != "a") { MessageBox.Show("Odgovor je a."); k++; }
                            break;
                        case 1:
                            if (toc != "b") { MessageBox.Show("Odgovor je b."); k++; }
                            break;
                        case 2:
                            if (toc != "c") { MessageBox.Show("Odgovor je c."); k++; }
                            break;
                        case 3:
                            if (toc != "d") { MessageBox.Show("Odgovor je d."); k++; }
                            break;
                    }
                }
            }
        }

        public void Obradi_joker_publika(int p, int p1, ref int a, ref int b, ref int c, ref int d)
        {
            Random rnd = new Random();

            a = rnd.Next(100 - 3) + 1;
            b = rnd.Next(100 - 3 - a) + 1;
            c = rnd.Next(100 - 3 - a - b) + 1;
            d = 100 - a - b - c;

            var max = new[] { a, b, c, d }.Max();

            if (p < p1)
            {
                if (toc == "a")
                {
                    int temp = a;
                    a = max;
                    if (b == max) b = temp;
                    if (c == max) c = temp;
                    if (d == max) d = temp;

                }
                if (toc == "b")
                {
                    int temp = b;
                    b = max;
                    if (a == max) a = temp;
                    if (c == max) c = temp;
                    if (d == max) d = temp;

                }
                if (toc == "c")
                {
                    int temp = c;
                    c = max;
                    if (b == max) b = temp;
                    if (a == max) a = temp;
                    if (d == max) d = temp;

                }
                if (toc == "d")
                {
                    int temp = d;
                    d = max;
                    if (b == max) b = temp;
                    if (c == max) c = temp;
                    if (a == max) a = temp;

                }
            }
        }
        private void joker_zovi_Click(object sender, EventArgs e)
        {
            potrosen_joker_zovi.Visible = true;
            Random rnd = new Random();
            int p = rnd.Next(100);
            switch (trenp)
            {
                case 1:
                    Obradi_joker_zovi(p, 99);
                    break;
                case 2:
                    Obradi_joker_zovi(p, 99);
                    break;
                case 3:
                    Obradi_joker_zovi(p, 99);
                    break;
                case 4:
                    Obradi_joker_zovi(p, 99);
                    break;
                case 5:
                    Obradi_joker_zovi(p, 95);
                    break;
                case 6:
                    Obradi_joker_zovi(p, 90);
                    break;
                case 7:
                    Obradi_joker_zovi(p, 85);
                    break;
                case 8:
                    Obradi_joker_zovi(p, 80);
                    break;
                case 9:
                    Obradi_joker_zovi(p, 70);
                    break;
                case 10:
                    Obradi_joker_zovi(p, 60);
                    break;
                case 11:
                    Obradi_joker_zovi(p, 50);
                    break;
                case 12:
                    Obradi_joker_zovi(p, 40);
                    break;
                case 13:
                    Obradi_joker_zovi(p, 30);
                    break;
                case 14:
                    Obradi_joker_zovi(p, 20);
                    break;
                case 15:
                    Obradi_joker_zovi(p, 10);
                    break;
                default:
                    break;
            }
        }

        private void joker_publika_Click(object sender, EventArgs e)
        {
            potrosen_joker_publika.Visible = true;
            int a=0, b=0, c=0, d=0;
            Random rnd = new Random();
            int p = rnd.Next(100);
            switch (trenp)
            {
                case 1:
                    Obradi_joker_publika(p, 99, ref a, ref b, ref c, ref d);
                    break;
                case 2:
                    Obradi_joker_publika(p, 99, ref a, ref b, ref c, ref d);
                    break;
                case 3:
                    Obradi_joker_publika(p, 99, ref a, ref b, ref c, ref d);
                    break;
                case 4:
                    Obradi_joker_publika(p, 99, ref a, ref b, ref c, ref d);
                    break;
                case 5:
                    Obradi_joker_publika(p, 95, ref a, ref b, ref c, ref d);
                    break;
                case 6:
                    Obradi_joker_publika(p, 90, ref a, ref b, ref c, ref d);
                    break;
                case 7:
                    Obradi_joker_publika(p, 85, ref a, ref b, ref c, ref d);
                    break;
                case 8:
                    Obradi_joker_publika(p, 80, ref a, ref b, ref c, ref d);
                    break;
                case 9:
                    Obradi_joker_publika(p, 70, ref a, ref b, ref c, ref d);
                    break;
                case 10:
                    Obradi_joker_publika(p, 60, ref a, ref b, ref c, ref d);
                    break;
                case 11:
                    Obradi_joker_publika(p, 50, ref a, ref b, ref c, ref d);
                    break;
                case 12:
                    Obradi_joker_publika(p, 40, ref a, ref b, ref c, ref d);
                    break;
                case 13:
                    Obradi_joker_publika(p, 30, ref a, ref b, ref c, ref d);
                    break;
                case 14:
                    Obradi_joker_publika(p, 20, ref a, ref b, ref c, ref d);
                    break;
                case 15:
                    Obradi_joker_publika(p, 10, ref a, ref b, ref c, ref d);
                    break;
                default:
                    break;
            }


            var publika = new Publika(a,b,c,d);
            publika.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panela_txt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
