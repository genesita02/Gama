namespace impuesto_sobre_larenta
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
            btn_Calcular = new Button();
            Limpiar = new Button();
            btn_Salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Sueldo = new TextBox();
            txt_isr = new TextBox();
            txt_afp = new TextBox();
            txt_sfs = new TextBox();
            txt_Status = new TextBox();
            SuspendLayout();
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Sitka Heading", 10F, FontStyle.Bold);
            btn_Calcular.Location = new Point(338, 169);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(112, 34);
            btn_Calcular.TabIndex = 0;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // Limpiar
            // 
            Limpiar.Font = new Font("Sitka Heading", 10F, FontStyle.Bold);
            Limpiar.Location = new Point(338, 209);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(112, 34);
            Limpiar.TabIndex = 1;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Sitka Heading", 10F, FontStyle.Bold);
            btn_Salir.Location = new Point(338, 251);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(112, 34);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 42);
            label1.Name = "label1";
            label1.Size = new Size(366, 47);
            label1.TabIndex = 3;
            label1.Text = "Impuesto Sobre la Renta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 10F);
            label2.Location = new Point(33, 136);
            label2.Name = "label2";
            label2.Size = new Size(113, 29);
            label2.TabIndex = 4;
            label2.Text = "Sueldo Neto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 10F);
            label3.Location = new Point(80, 198);
            label3.Name = "label3";
            label3.Size = new Size(41, 29);
            label3.TabIndex = 5;
            label3.Text = "ISR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 10F);
            label4.Location = new Point(75, 256);
            label4.Name = "label4";
            label4.Size = new Size(46, 29);
            label4.TabIndex = 6;
            label4.Text = "AFP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 10F);
            label5.Location = new Point(78, 323);
            label5.Name = "label5";
            label5.Size = new Size(43, 29);
            label5.TabIndex = 7;
            label5.Text = "SFS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 10F);
            label6.Location = new Point(56, 401);
            label6.Name = "label6";
            label6.Size = new Size(65, 29);
            label6.TabIndex = 8;
            label6.Text = "Status";
            // 
            // txt_Sueldo
            // 
            txt_Sueldo.Location = new Point(161, 134);
            txt_Sueldo.Name = "txt_Sueldo";
            txt_Sueldo.Size = new Size(101, 31);
            txt_Sueldo.TabIndex = 9;
            // 
            // txt_isr
            // 
            txt_isr.Location = new Point(161, 196);
            txt_isr.Name = "txt_isr";
            txt_isr.Size = new Size(101, 31);
            txt_isr.TabIndex = 10;
            // 
            // txt_afp
            // 
            txt_afp.Location = new Point(161, 254);
            txt_afp.Name = "txt_afp";
            txt_afp.Size = new Size(101, 31);
            txt_afp.TabIndex = 11;
            // 
            // txt_sfs
            // 
            txt_sfs.Location = new Point(161, 323);
            txt_sfs.Name = "txt_sfs";
            txt_sfs.Size = new Size(101, 31);
            txt_sfs.TabIndex = 12;
            // 
            // txt_Status
            // 
            txt_Status.Location = new Point(161, 401);
            txt_Status.Name = "txt_Status";
            txt_Status.Size = new Size(150, 31);
            txt_Status.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(549, 466);
            Controls.Add(txt_Status);
            Controls.Add(txt_sfs);
            Controls.Add(txt_afp);
            Controls.Add(txt_isr);
            Controls.Add(txt_Sueldo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(Limpiar);
            Controls.Add(btn_Calcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calcular;
        private Button Limpiar;
        private Button btn_Salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Sueldo;
        private TextBox txt_isr;
        private TextBox txt_afp;
        private TextBox txt_sfs;
        private TextBox txt_Status;
    }
}
