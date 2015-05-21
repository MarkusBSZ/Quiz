namespace Quiz_1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPunkte = new System.Windows.Forms.TextBox();
            this.buttonPunkteSpeichern = new System.Windows.Forms.Button();
            this.radioButtonAntwort1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort4 = new System.Windows.Forms.RadioButton();
            this.progressBarZeit = new System.Windows.Forms.ProgressBar();
            this.richTextBoxFrage = new System.Windows.Forms.RichTextBox();
            this.timerFragen = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausDatenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonBestenliste = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(10, 80);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(140, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Nächste Frage";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Punktestand";
            // 
            // textBoxPunkte
            // 
            this.textBoxPunkte.Enabled = false;
            this.textBoxPunkte.Location = new System.Drawing.Point(604, 225);
            this.textBoxPunkte.Name = "textBoxPunkte";
            this.textBoxPunkte.Size = new System.Drawing.Size(100, 20);
            this.textBoxPunkte.TabIndex = 3;
            // 
            // buttonPunkteSpeichern
            // 
            this.buttonPunkteSpeichern.Location = new System.Drawing.Point(529, 251);
            this.buttonPunkteSpeichern.Name = "buttonPunkteSpeichern";
            this.buttonPunkteSpeichern.Size = new System.Drawing.Size(175, 23);
            this.buttonPunkteSpeichern.TabIndex = 4;
            this.buttonPunkteSpeichern.Text = "Punktestand speichern";
            this.buttonPunkteSpeichern.UseVisualStyleBackColor = true;
            this.buttonPunkteSpeichern.Click += new System.EventHandler(this.buttonPunkteSpeichern_Click);
            // 
            // radioButtonAntwort1
            // 
            this.radioButtonAntwort1.AutoSize = true;
            this.radioButtonAntwort1.Location = new System.Drawing.Point(10, 182);
            this.radioButtonAntwort1.Name = "radioButtonAntwort1";
            this.radioButtonAntwort1.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAntwort1.TabIndex = 6;
            this.radioButtonAntwort1.TabStop = true;
            this.radioButtonAntwort1.Text = "?";
            this.radioButtonAntwort1.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort2
            // 
            this.radioButtonAntwort2.AutoSize = true;
            this.radioButtonAntwort2.Location = new System.Drawing.Point(10, 205);
            this.radioButtonAntwort2.Name = "radioButtonAntwort2";
            this.radioButtonAntwort2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAntwort2.TabIndex = 7;
            this.radioButtonAntwort2.TabStop = true;
            this.radioButtonAntwort2.Text = "?";
            this.radioButtonAntwort2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort3
            // 
            this.radioButtonAntwort3.AutoSize = true;
            this.radioButtonAntwort3.Location = new System.Drawing.Point(10, 228);
            this.radioButtonAntwort3.Name = "radioButtonAntwort3";
            this.radioButtonAntwort3.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAntwort3.TabIndex = 8;
            this.radioButtonAntwort3.TabStop = true;
            this.radioButtonAntwort3.Text = "?";
            this.radioButtonAntwort3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort4
            // 
            this.radioButtonAntwort4.AutoSize = true;
            this.radioButtonAntwort4.Location = new System.Drawing.Point(10, 251);
            this.radioButtonAntwort4.Name = "radioButtonAntwort4";
            this.radioButtonAntwort4.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAntwort4.TabIndex = 9;
            this.radioButtonAntwort4.TabStop = true;
            this.radioButtonAntwort4.Text = "?";
            this.radioButtonAntwort4.UseVisualStyleBackColor = true;
            // 
            // progressBarZeit
            // 
            this.progressBarZeit.Location = new System.Drawing.Point(10, 51);
            this.progressBarZeit.Maximum = 1000;
            this.progressBarZeit.Name = "progressBarZeit";
            this.progressBarZeit.Size = new System.Drawing.Size(694, 23);
            this.progressBarZeit.TabIndex = 10;
            // 
            // richTextBoxFrage
            // 
            this.richTextBoxFrage.Location = new System.Drawing.Point(47, 131);
            this.richTextBoxFrage.Name = "richTextBoxFrage";
            this.richTextBoxFrage.Size = new System.Drawing.Size(657, 39);
            this.richTextBoxFrage.TabIndex = 11;
            this.richTextBoxFrage.Text = "";
            // 
            // timerFragen
            // 
            this.timerFragen.Interval = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausDatenbankToolStripMenuItem,
            this.ausXMLFileToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // ausDatenbankToolStripMenuItem
            // 
            this.ausDatenbankToolStripMenuItem.Name = "ausDatenbankToolStripMenuItem";
            this.ausDatenbankToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ausDatenbankToolStripMenuItem.Text = "Aus Datenbank";
            this.ausDatenbankToolStripMenuItem.Click += new System.EventHandler(this.ausDatenbankToolStripMenuItem_Click);
            // 
            // ausXMLFileToolStripMenuItem
            // 
            this.ausXMLFileToolStripMenuItem.Name = "ausXMLFileToolStripMenuItem";
            this.ausXMLFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ausXMLFileToolStripMenuItem.Text = "Aus XML-File";
            this.ausXMLFileToolStripMenuItem.Click += new System.EventHandler(this.ausXMLFileToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonBestenliste
            // 
            this.buttonBestenliste.Location = new System.Drawing.Point(529, 280);
            this.buttonBestenliste.Name = "buttonBestenliste";
            this.buttonBestenliste.Size = new System.Drawing.Size(174, 28);
            this.buttonBestenliste.TabIndex = 14;
            this.buttonBestenliste.Text = "zur Bestenliste";
            this.buttonBestenliste.UseVisualStyleBackColor = true;
            this.buttonBestenliste.Click += new System.EventHandler(this.buttonBestenliste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 333);
            this.Controls.Add(this.buttonBestenliste);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBoxFrage);
            this.Controls.Add(this.progressBarZeit);
            this.Controls.Add(this.radioButtonAntwort4);
            this.Controls.Add(this.radioButtonAntwort3);
            this.Controls.Add(this.radioButtonAntwort2);
            this.Controls.Add(this.radioButtonAntwort1);
            this.Controls.Add(this.buttonPunkteSpeichern);
            this.Controls.Add(this.textBoxPunkte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPunkte;
        private System.Windows.Forms.Button buttonPunkteSpeichern;
        private System.Windows.Forms.RadioButton radioButtonAntwort1;
        private System.Windows.Forms.RadioButton radioButtonAntwort2;
        private System.Windows.Forms.RadioButton radioButtonAntwort3;
        private System.Windows.Forms.RadioButton radioButtonAntwort4;
        private System.Windows.Forms.ProgressBar progressBarZeit;
        private System.Windows.Forms.RichTextBox richTextBoxFrage;
        private System.Windows.Forms.Timer timerFragen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausDatenbankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausXMLFileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button buttonBestenliste;
    }
}

