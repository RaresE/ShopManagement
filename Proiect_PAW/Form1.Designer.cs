namespace Proiect_PAW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cliențiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzacțiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem,
            this.ieșireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.tranzactieToolStripMenuItem});
            this.adaugaToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources._8922789;
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            // 
            // produsToolStripMenuItem
            // 
            this.produsToolStripMenuItem.Name = "produsToolStripMenuItem";
            this.produsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.produsToolStripMenuItem.Text = "Produs";
            this.produsToolStripMenuItem.Click += new System.EventHandler(this.produsToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // tranzactieToolStripMenuItem
            // 
            this.tranzactieToolStripMenuItem.Name = "tranzactieToolStripMenuItem";
            this.tranzactieToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.tranzactieToolStripMenuItem.Text = "Tranzacție";
            this.tranzactieToolStripMenuItem.Click += new System.EventHandler(this.tranzactieToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.cliențiToolStripMenuItem,
            this.tranzacțiiToolStripMenuItem});
            this.vizualizareToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources._1502185_200;
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // cliențiToolStripMenuItem
            // 
            this.cliențiToolStripMenuItem.Name = "cliențiToolStripMenuItem";
            this.cliențiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cliențiToolStripMenuItem.Text = "Clienți";
            this.cliențiToolStripMenuItem.Click += new System.EventHandler(this.cliențiToolStripMenuItem_Click);
            // 
            // tranzacțiiToolStripMenuItem
            // 
            this.tranzacțiiToolStripMenuItem.Name = "tranzacțiiToolStripMenuItem";
            this.tranzacțiiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.tranzacțiiToolStripMenuItem.Text = "Tranzacții";
            this.tranzacțiiToolStripMenuItem.Click += new System.EventHandler(this.tranzacțiiToolStripMenuItem_Click);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.binary_code_icon_2048x1667_zc4tgx6k;
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources._5333073;
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.Exit;
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ieșireToolStripMenuItem.Text = "Ieșire";
            this.ieșireToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_PAW.Properties.Resources.cartoon_style_cafe_front_shop_view_134830_697;
            this.ClientSize = new System.Drawing.Size(688, 399);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cliențiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzacțiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
    }
}

