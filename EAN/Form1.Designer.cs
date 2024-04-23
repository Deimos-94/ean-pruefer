namespace EAN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lb_ean = new Label();
            tb_ean = new TextBox();
            lb_ergebnis = new Label();
            btn_prüfen = new Button();
            rtb_ausgabe = new RichTextBox();
            SuspendLayout();
            // 
            // lb_ean
            // 
            lb_ean.AutoSize = true;
            lb_ean.Font = new Font("Segoe UI", 12F);
            lb_ean.Location = new Point(8, 9);
            lb_ean.Margin = new Padding(2, 0, 2, 0);
            lb_ean.Name = "lb_ean";
            lb_ean.Size = new Size(43, 21);
            lb_ean.TabIndex = 0;
            lb_ean.Text = "EAN:";
            // 
            // tb_ean
            // 
            tb_ean.Font = new Font("Segoe UI", 12F);
            tb_ean.Location = new Point(57, 7);
            tb_ean.Margin = new Padding(2);
            tb_ean.Name = "tb_ean";
            tb_ean.Size = new Size(260, 29);
            tb_ean.TabIndex = 1;
            tb_ean.TextChanged += tb_ean_TextChanged;
            // 
            // lb_ergebnis
            // 
            lb_ergebnis.AutoSize = true;
            lb_ergebnis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_ergebnis.Location = new Point(57, 38);
            lb_ergebnis.Margin = new Padding(2, 0, 2, 0);
            lb_ergebnis.Name = "lb_ergebnis";
            lb_ergebnis.Size = new Size(85, 25);
            lb_ergebnis.TabIndex = 2;
            lb_ergebnis.Text = "Ergebnis";
            // 
            // btn_prüfen
            // 
            btn_prüfen.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_prüfen.Location = new Point(57, 65);
            btn_prüfen.Margin = new Padding(2);
            btn_prüfen.Name = "btn_prüfen";
            btn_prüfen.Size = new Size(258, 38);
            btn_prüfen.TabIndex = 3;
            btn_prüfen.Text = "Prüfen  →";
            btn_prüfen.UseVisualStyleBackColor = true;
            btn_prüfen.Click += btn_prüfen_Click;
            // 
            // rtb_ausgabe
            // 
            rtb_ausgabe.Enabled = false;
            rtb_ausgabe.Location = new Point(57, 107);
            rtb_ausgabe.Margin = new Padding(2);
            rtb_ausgabe.Name = "rtb_ausgabe";
            rtb_ausgabe.Size = new Size(0, 0);
            rtb_ausgabe.TabIndex = 4;
            rtb_ausgabe.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 110);
            Controls.Add(rtb_ausgabe);
            Controls.Add(btn_prüfen);
            Controls.Add(lb_ergebnis);
            Controls.Add(tb_ean);
            Controls.Add(lb_ean);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "EAN Prüfer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_ean;
        private TextBox tb_ean;
        private Label lb_ergebnis;
        private Button btn_prüfen;
        private RichTextBox rtb_ausgabe;
    }
}
