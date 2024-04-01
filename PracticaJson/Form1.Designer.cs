namespace PracticaJson
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNota = new System.Windows.Forms.TextBox();
            this.buttonAgregarNota = new System.Windows.Forms.Button();
            this.buttonGuardarAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(195, 33);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 22);
            this.textNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textNota
            // 
            this.textNota.Location = new System.Drawing.Point(195, 86);
            this.textNota.Name = "textNota";
            this.textNota.Size = new System.Drawing.Size(100, 22);
            this.textNota.TabIndex = 3;
            // 
            // buttonAgregarNota
            // 
            this.buttonAgregarNota.Location = new System.Drawing.Point(397, 86);
            this.buttonAgregarNota.Name = "buttonAgregarNota";
            this.buttonAgregarNota.Size = new System.Drawing.Size(113, 23);
            this.buttonAgregarNota.TabIndex = 4;
            this.buttonAgregarNota.Text = "Guardar nota";
            this.buttonAgregarNota.UseVisualStyleBackColor = true;
            this.buttonAgregarNota.Click += new System.EventHandler(this.buttonAgregarNota_Click);
            // 
            // buttonGuardarAlumno
            // 
            this.buttonGuardarAlumno.Location = new System.Drawing.Point(248, 160);
            this.buttonGuardarAlumno.Name = "buttonGuardarAlumno";
            this.buttonGuardarAlumno.Size = new System.Drawing.Size(126, 60);
            this.buttonGuardarAlumno.TabIndex = 5;
            this.buttonGuardarAlumno.Text = "Guardar datos";
            this.buttonGuardarAlumno.UseVisualStyleBackColor = true;
            this.buttonGuardarAlumno.Click += new System.EventHandler(this.buttonGuardarAlumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 308);
            this.Controls.Add(this.buttonGuardarAlumno);
            this.Controls.Add(this.buttonAgregarNota);
            this.Controls.Add(this.textNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNota;
        private System.Windows.Forms.Button buttonAgregarNota;
        private System.Windows.Forms.Button buttonGuardarAlumno;
    }
}

