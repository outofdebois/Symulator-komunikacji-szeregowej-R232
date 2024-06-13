
namespace WindowsFormsApp1
{
    partial class RS232
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input_in = new System.Windows.Forms.TextBox();
            this.Input_Out = new System.Windows.Forms.TextBox();
            this.Output_In = new System.Windows.Forms.TextBox();
            this.Output_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KonwIn = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.KonwOut = new System.Windows.Forms.Button();
            this.Blur = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Input_in
            // 
            this.Input_in.Location = new System.Drawing.Point(39, 79);
            this.Input_in.Multiline = true;
            this.Input_in.Name = "Input_in";
            this.Input_in.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Input_in.Size = new System.Drawing.Size(190, 70);
            this.Input_in.TabIndex = 0;
            this.Input_in.TextChanged += new System.EventHandler(this.Input_in_TextChanged);
            // 
            // Input_Out
            // 
            this.Input_Out.Location = new System.Drawing.Point(39, 242);
            this.Input_Out.Multiline = true;
            this.Input_Out.Name = "Input_Out";
            this.Input_Out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Input_Out.Size = new System.Drawing.Size(190, 70);
            this.Input_Out.TabIndex = 1;
            this.Input_Out.TextChanged += new System.EventHandler(this.Input_out_TextChanged);
            // 
            // Output_In
            // 
            this.Output_In.Location = new System.Drawing.Point(328, 79);
            this.Output_In.Multiline = true;
            this.Output_In.Name = "Output_In";
            this.Output_In.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_In.Size = new System.Drawing.Size(190, 70);
            this.Output_In.TabIndex = 2;
            this.Output_In.TextChanged += new System.EventHandler(this.Output_in_TextChanged);
            // 
            // Output_out
            // 
            this.Output_out.Location = new System.Drawing.Point(328, 242);
            this.Output_out.Multiline = true;
            this.Output_out.Name = "Output_out";
            this.Output_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_out.Size = new System.Drawing.Size(190, 70);
            this.Output_out.TabIndex = 3;
            this.Output_out.TextChanged += new System.EventHandler(this.Output_out_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Martina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "WEJŚCIE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Martina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(360, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "WYJŚCIE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // KonwIn
            // 
            this.KonwIn.Location = new System.Drawing.Point(88, 155);
            this.KonwIn.Name = "KonwIn";
            this.KonwIn.Size = new System.Drawing.Size(75, 23);
            this.KonwIn.TabIndex = 6;
            this.KonwIn.Text = "konwertuj";
            this.KonwIn.UseVisualStyleBackColor = true;
            this.KonwIn.Click += new System.EventHandler(this.KonwIn_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(88, 318);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 7;
            this.Send.Text = "wyślij";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // KonwOut
            // 
            this.KonwOut.Location = new System.Drawing.Point(384, 155);
            this.KonwOut.Name = "KonwOut";
            this.KonwOut.Size = new System.Drawing.Size(75, 23);
            this.KonwOut.TabIndex = 8;
            this.KonwOut.Text = "konwertuj";
            this.KonwOut.UseVisualStyleBackColor = true;
            this.KonwOut.Click += new System.EventHandler(this.KonwOut_Click);
            // 
            // Blur
            // 
            this.Blur.AutoSize = true;
            this.Blur.Location = new System.Drawing.Point(454, 318);
            this.Blur.Name = "Blur";
            this.Blur.Size = new System.Drawing.Size(64, 17);
            this.Blur.TabIndex = 9;
            this.Blur.Text = "cenzura";
            this.Blur.UseVisualStyleBackColor = true;
            this.Blur.CheckedChanged += new System.EventHandler(this.BlurCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RS232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(587, 416);
            this.Controls.Add(this.Blur);
            this.Controls.Add(this.KonwOut);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.KonwIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output_out);
            this.Controls.Add(this.Output_In);
            this.Controls.Add(this.Input_Out);
            this.Controls.Add(this.Input_in);
            this.Name = "RS232";
            this.Text = "RS232";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_in;
        private System.Windows.Forms.TextBox Input_Out;
        private System.Windows.Forms.TextBox Output_In;
        private System.Windows.Forms.TextBox Output_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KonwIn;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button KonwOut;
        private System.Windows.Forms.CheckBox Blur;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

