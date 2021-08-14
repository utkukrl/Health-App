
namespace acilis
{
    partial class GKİForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GKİForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxGender2 = new System.Windows.Forms.ComboBox();
            this.tbxGKIboy = new System.Windows.Forms.TextBox();
            this.tbxGKIkilo = new System.Windows.Forms.TextBox();
            this.nudYas = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCalculate2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.btnIleri = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.ger = new System.Windows.Forms.ImageList(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbxGender2
            // 
            this.cbxGender2.FormattingEnabled = true;
            this.cbxGender2.Location = new System.Drawing.Point(227, 112);
            this.cbxGender2.Name = "cbxGender2";
            this.cbxGender2.Size = new System.Drawing.Size(311, 21);
            this.cbxGender2.TabIndex = 0;
            this.cbxGender2.Validating += new System.ComponentModel.CancelEventHandler(this.cbxGender2_Validating);
            // 
            // tbxGKIboy
            // 
            this.tbxGKIboy.Location = new System.Drawing.Point(227, 159);
            this.tbxGKIboy.Name = "tbxGKIboy";
            this.tbxGKIboy.Size = new System.Drawing.Size(311, 20);
            this.tbxGKIboy.TabIndex = 1;
            this.tbxGKIboy.Validated += new System.EventHandler(this.tbxGKIboy_Validated);
            // 
            // tbxGKIkilo
            // 
            this.tbxGKIkilo.Location = new System.Drawing.Point(227, 206);
            this.tbxGKIkilo.Name = "tbxGKIkilo";
            this.tbxGKIkilo.Size = new System.Drawing.Size(311, 20);
            this.tbxGKIkilo.TabIndex = 2;
            this.tbxGKIkilo.Validating += new System.ComponentModel.CancelEventHandler(this.tbxGKIkilo_Validating);
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(227, 253);
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(311, 20);
            this.nudYas.TabIndex = 3;
            this.nudYas.Validated += new System.EventHandler(this.nudYas_Validated);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(178, 115);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(43, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Cinsiyet";
            // 
            // btnCalculate2
            // 
            this.btnCalculate2.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate2.ForeColor = System.Drawing.Color.White;
            this.btnCalculate2.ImageKey = "utk.ico";
            this.btnCalculate2.ImageList = this.ımageList1;
            this.btnCalculate2.Location = new System.Drawing.Point(447, 279);
            this.btnCalculate2.Name = "btnCalculate2";
            this.btnCalculate2.Size = new System.Drawing.Size(91, 77);
            this.btnCalculate2.TabIndex = 8;
            this.btnCalculate2.UseVisualStyleBackColor = false;
            this.btnCalculate2.Click += new System.EventHandler(this.btnCalculate2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(236, 293);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sporcuyum";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.BackColor = System.Drawing.Color.Transparent;
            this.lblBoy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBoy.Location = new System.Drawing.Point(196, 162);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(25, 13);
            this.lblBoy.TabIndex = 10;
            this.lblBoy.Text = "Boy";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.BackColor = System.Drawing.Color.Transparent;
            this.lblKilo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKilo.Location = new System.Drawing.Point(197, 209);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(24, 13);
            this.lblKilo.TabIndex = 11;
            this.lblKilo.Text = "Kilo";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Transparent;
            this.lblYas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYas.Location = new System.Drawing.Point(196, 256);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(25, 13);
            this.lblYas.TabIndex = 12;
            this.lblYas.Text = "Yaş";
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.Transparent;
            this.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIleri.ImageKey = "asd.ico";
            this.btnIleri.ImageList = this.ileri;
            this.btnIleri.Location = new System.Drawing.Point(654, 341);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(118, 58);
            this.btnIleri.TabIndex = 13;
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click_1);
            // 
            // ileri
            // 
            this.ileri.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ileri.ImageStream")));
            this.ileri.TransparentColor = System.Drawing.Color.Transparent;
            this.ileri.Images.SetKeyName(0, "asd.ico");
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.ImageKey = "abc.ico";
            this.btnGeri.ImageList = this.ger;
            this.btnGeri.Location = new System.Drawing.Point(12, 341);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(121, 58);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click_1);
            // 
            // ger
            // 
            this.ger.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ger.ImageStream")));
            this.ger.TransparentColor = System.Drawing.Color.Transparent;
            this.ger.Images.SetKeyName(0, "abc.ico");
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "utk.ico");
            // 
            // GKİForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnCalculate2);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.nudYas);
            this.Controls.Add(this.tbxGKIkilo);
            this.Controls.Add(this.tbxGKIboy);
            this.Controls.Add(this.cbxGender2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GKİForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vücut-Kitle İndeski Hesaplamaya Geç";
            this.Load += new System.EventHandler(this.GKİForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCalculate2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox nudYas;
        private System.Windows.Forms.TextBox tbxGKIkilo;
        private System.Windows.Forms.TextBox tbxGKIboy;
        private System.Windows.Forms.ComboBox cbxGender2;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.ImageList ger;
        private System.Windows.Forms.ImageList ileri;
        private System.Windows.Forms.ImageList ımageList1;
    }
}