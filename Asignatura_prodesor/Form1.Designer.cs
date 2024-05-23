namespace Asignatura_prodesor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_asignatura = new System.Windows.Forms.TextBox();
            this.txt_profesor = new System.Windows.Forms.TextBox();
            this.rdb_vistual = new System.Windows.Forms.RadioButton();
            this.rdb_presencial = new System.Windows.Forms.RadioButton();
            this.btn_prosesar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_informacion = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profesor";
            // 
            // txt_asignatura
            // 
            this.txt_asignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asignatura.Location = new System.Drawing.Point(189, 82);
            this.txt_asignatura.Name = "txt_asignatura";
            this.txt_asignatura.Size = new System.Drawing.Size(173, 26);
            this.txt_asignatura.TabIndex = 2;
            // 
            // txt_profesor
            // 
            this.txt_profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_profesor.Location = new System.Drawing.Point(189, 128);
            this.txt_profesor.Name = "txt_profesor";
            this.txt_profesor.Size = new System.Drawing.Size(173, 26);
            this.txt_profesor.TabIndex = 3;
            // 
            // rdb_vistual
            // 
            this.rdb_vistual.AutoSize = true;
            this.rdb_vistual.Location = new System.Drawing.Point(60, 220);
            this.rdb_vistual.Name = "rdb_vistual";
            this.rdb_vistual.Size = new System.Drawing.Size(54, 17);
            this.rdb_vistual.TabIndex = 4;
            this.rdb_vistual.TabStop = true;
            this.rdb_vistual.Text = "Virtual";
            this.rdb_vistual.UseVisualStyleBackColor = true;
            // 
            // rdb_presencial
            // 
            this.rdb_presencial.AutoSize = true;
            this.rdb_presencial.Location = new System.Drawing.Point(189, 220);
            this.rdb_presencial.Name = "rdb_presencial";
            this.rdb_presencial.Size = new System.Drawing.Size(74, 17);
            this.rdb_presencial.TabIndex = 5;
            this.rdb_presencial.TabStop = true;
            this.rdb_presencial.Text = "Presencial";
            this.rdb_presencial.UseVisualStyleBackColor = true;
            // 
            // btn_prosesar
            // 
            this.btn_prosesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prosesar.Location = new System.Drawing.Point(420, 81);
            this.btn_prosesar.Name = "btn_prosesar";
            this.btn_prosesar.Size = new System.Drawing.Size(109, 24);
            this.btn_prosesar.TabIndex = 6;
            this.btn_prosesar.Text = "Prosesar";
            this.btn_prosesar.UseVisualStyleBackColor = true;
            this.btn_prosesar.Click += new System.EventHandler(this.btn_prosesar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(420, 126);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(109, 24);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(420, 179);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(109, 24);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_informacion
            // 
            this.txt_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_informacion.Location = new System.Drawing.Point(67, 266);
            this.txt_informacion.Multiline = true;
            this.txt_informacion.Name = "txt_informacion";
            this.txt_informacion.Size = new System.Drawing.Size(295, 160);
            this.txt_informacion.TabIndex = 9;
            this.txt_informacion.TextChanged += new System.EventHandler(this.txt_informacion_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(321, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ambos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_informacion);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_prosesar);
            this.Controls.Add(this.rdb_presencial);
            this.Controls.Add(this.rdb_vistual);
            this.Controls.Add(this.txt_profesor);
            this.Controls.Add(this.txt_asignatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_asignatura;
        private System.Windows.Forms.TextBox txt_profesor;
        private System.Windows.Forms.RadioButton rdb_vistual;
        private System.Windows.Forms.RadioButton rdb_presencial;
        private System.Windows.Forms.Button btn_prosesar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_informacion;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

