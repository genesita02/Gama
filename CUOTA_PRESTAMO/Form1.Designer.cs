﻿namespace CUOTA_PRESTAMO
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_taza_interes = new System.Windows.Forms.TextBox();
            this.txt_cuota = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_años = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_cuota_prestamo = new System.Windows.Forms.DataGridView();
            this.cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dlg_guardar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuota_prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAZA_INTERES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CUOTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "AÑOS";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(192, 60);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 5;
            // 
            // txt_taza_interes
            // 
            this.txt_taza_interes.Location = new System.Drawing.Point(192, 243);
            this.txt_taza_interes.Name = "txt_taza_interes";
            this.txt_taza_interes.Size = new System.Drawing.Size(100, 20);
            this.txt_taza_interes.TabIndex = 6;
            // 
            // txt_cuota
            // 
            this.txt_cuota.Location = new System.Drawing.Point(192, 158);
            this.txt_cuota.Name = "txt_cuota";
            this.txt_cuota.Size = new System.Drawing.Size(100, 20);
            this.txt_cuota.TabIndex = 7;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(192, 199);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 8;
            // 
            // txt_años
            // 
            this.txt_años.Location = new System.Drawing.Point(192, 105);
            this.txt_años.Name = "txt_años";
            this.txt_años.Size = new System.Drawing.Size(100, 20);
            this.txt_años.TabIndex = 9;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(864, 57);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(107, 23);
            this.btn_calcular.TabIndex = 10;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(864, 104);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(107, 23);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(864, 155);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 23);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_cuota_prestamo
            // 
            this.dgv_cuota_prestamo.AllowUserToAddRows = false;
            this.dgv_cuota_prestamo.AllowUserToDeleteRows = false;
            this.dgv_cuota_prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuota_prestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuota,
            this.capital,
            this.interes,
            this.saldo});
            this.dgv_cuota_prestamo.Location = new System.Drawing.Point(343, 69);
            this.dgv_cuota_prestamo.Name = "dgv_cuota_prestamo";
            this.dgv_cuota_prestamo.ReadOnly = true;
            this.dgv_cuota_prestamo.Size = new System.Drawing.Size(429, 150);
            this.dgv_cuota_prestamo.TabIndex = 13;
            this.dgv_cuota_prestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cuota_prestamo_CellContentClick);
            // 
            // cuota
            // 
            this.cuota.HeaderText = "Cuota";
            this.cuota.Name = "cuota";
            this.cuota.ReadOnly = true;
            // 
            // capital
            // 
            this.capital.HeaderText = "Capital";
            this.capital.Name = "capital";
            this.capital.ReadOnly = true;
            // 
            // interes
            // 
            this.interes.HeaderText = "Interes";
            this.interes.Name = "interes";
            this.interes.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(864, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_cuota_prestamo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_años);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_cuota);
            this.Controls.Add(this.txt_taza_interes);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuota_prestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.TextBox txt_taza_interes;
        private System.Windows.Forms.TextBox txt_cuota;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_años;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_cuota_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog dlg_guardar;
    }
}

