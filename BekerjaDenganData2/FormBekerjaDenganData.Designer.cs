namespace BekerjaDenganData2
{
    partial class FormBekerjaDenganData
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInputJabatan = new System.Windows.Forms.Button();
            this.btnInputKaryawan = new System.Windows.Forms.Button();
            this.btnUpdateKaryawan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "DATABASE BEKERJA DENGAN DATA";
            // 
            // btnInputJabatan
            // 
            this.btnInputJabatan.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnInputJabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputJabatan.Location = new System.Drawing.Point(89, 101);
            this.btnInputJabatan.Name = "btnInputJabatan";
            this.btnInputJabatan.Size = new System.Drawing.Size(367, 33);
            this.btnInputJabatan.TabIndex = 36;
            this.btnInputJabatan.Text = "FORM INPUT DATA JABATAN";
            this.btnInputJabatan.UseVisualStyleBackColor = false;
            this.btnInputJabatan.Click += new System.EventHandler(this.btnInputJabatan_Click);
            // 
            // btnInputKaryawan
            // 
            this.btnInputKaryawan.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInputKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputKaryawan.Location = new System.Drawing.Point(89, 165);
            this.btnInputKaryawan.Name = "btnInputKaryawan";
            this.btnInputKaryawan.Size = new System.Drawing.Size(367, 33);
            this.btnInputKaryawan.TabIndex = 37;
            this.btnInputKaryawan.Text = "FORM INPUT DATA KARYAWAN";
            this.btnInputKaryawan.UseVisualStyleBackColor = false;
            this.btnInputKaryawan.Click += new System.EventHandler(this.btnInputKaryawan_Click);
            // 
            // btnUpdateKaryawan
            // 
            this.btnUpdateKaryawan.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKaryawan.Location = new System.Drawing.Point(89, 228);
            this.btnUpdateKaryawan.Name = "btnUpdateKaryawan";
            this.btnUpdateKaryawan.Size = new System.Drawing.Size(367, 33);
            this.btnUpdateKaryawan.TabIndex = 38;
            this.btnUpdateKaryawan.Text = "UPDATE DATA KARYAWAN";
            this.btnUpdateKaryawan.UseVisualStyleBackColor = false;
            this.btnUpdateKaryawan.Click += new System.EventHandler(this.btnUpdateKaryawan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 33);
            this.button1.TabIndex = 39;
            this.button1.Text = "DELETE DATA KARYAWAN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBekerjaDenganData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateKaryawan);
            this.Controls.Add(this.btnInputKaryawan);
            this.Controls.Add(this.btnInputJabatan);
            this.Controls.Add(this.label1);
            this.Name = "FormBekerjaDenganData";
            this.Text = "FormBekerjaDenganData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInputJabatan;
        private System.Windows.Forms.Button btnInputKaryawan;
        private System.Windows.Forms.Button btnUpdateKaryawan;
        private System.Windows.Forms.Button button1;
    }
}