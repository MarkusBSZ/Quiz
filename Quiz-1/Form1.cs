using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Xml;

namespace Quiz_1
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = null;


        public OleDbConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        OleDbDataAdapter adapter = null;
        DataSet dataSet = null;
        DataTableReader reader;
        int richtigeAntwort;
        List<RadioButton> radiobutton = new List<RadioButton>();
        int punktestand = 0;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {

            dataSet = new DataSet();
            radiobutton = new List<RadioButton>();
            radiobutton.Add(radioButtonAntwort1);
            radiobutton.Add(radioButtonAntwort2);
            radiobutton.Add(radioButtonAntwort3);
            radiobutton.Add(radioButtonAntwort4);
            textBoxPunkte.Text = punktestand.ToString();
            timerFragen.Tick += new EventHandler(runProgressBar);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            timerFragen.Start();
              
            if (radiobutton[richtigeAntwort].Checked == true)
            {

                punktestand += 10;
                progressBarZeit.Value = 0;
            }
            else
            {
                progressBarZeit.Value = 0;
                punktestand = 0;
            }
            textBoxPunkte.Text = punktestand.ToString();

            reader = dataSet.Tables["Fragen"].CreateDataReader();
            
            Random random = new Random();
            int zufallszahl = random.Next(500);
            while(reader.Read())
            {
                if(zufallszahl == Convert.ToInt16(reader.GetValue(0)))
                {
                    richTextBoxFrage.Text = reader.GetValue(1).ToString();
                    int x = random.Next(4)+2;
                    for(int i = 0; i <= 3; i++)
                    {
                        if (x > 5) x = 2;
                        radiobutton[i].Text = reader.GetValue(x).ToString();
                        if(x == 2)
                        {
                            richtigeAntwort = i;
                        }
                        x++;
                    }

                }
            }

            
            

            //timerFragen.Interval = 100;
            //einThread.Start();
            //progressBarZeit.Value += 1;
        }

        private void runProgressBar(object sender, EventArgs e)
        {
            try
            {
                 progressBarZeit.Value += 1;
                
            }
            catch (Exception)
            {
                punktestand = 0;
                textBoxPunkte.Text = "0";
            }
        }

        private void ausDatenbankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new OleDbConnection();
                connection.ConnectionString = Properties.Settings.Default.DbVerbindung;
                adapter = new OleDbDataAdapter("Select * FROM tFrage", connection);
                adapter.Fill(dataSet);
                adapter.FillSchema(dataSet, SchemaType.Source, "Fragen");
                adapter.Fill(dataSet, "Fragen");
                dataSet.WriteXmlSchema("Fragen.xsd");
                dataSet.WriteXml("Fragen.xml");
                statusLabel.Text = "Erfolgreich aus Datenbank gelesen und XML-File geschrieben.";
            }
            catch (Exception)
            {
                statusLabel.Text = "Fehler beim Lesen aus der Datenbank und Schreiben des XML-Files"; 
            }

            
        }

        private void ausXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
            dataSet.ReadXmlSchema("Fragen.xsd");
            dataSet.ReadXml("Fragen.xml");
            statusLabel.Text = "DataSet erfolgreich geladen.";
            }
            catch (Exception)
            {
                statusLabel.Text = "Fehler beim auslesen.";
            }

            
        }

        private void buttonPunkteSpeichern_Click(object sender, EventArgs e)
        {
            //LELELELELELLL
        }

        private void buttonBestenliste_Click(object sender, EventArgs e)
        {
            Form bestenliste = new Bestenliste();
            bestenliste.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

    }
}
