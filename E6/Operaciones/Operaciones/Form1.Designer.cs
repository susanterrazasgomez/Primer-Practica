namespace Operaciones
{
    partial class frm_principal
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.comboBox_opciones = new System.Windows.Forms.ComboBox();
            this.listBox_resultado = new System.Windows.Forms.ListBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(242, 37);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(216, 40);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "PROGRAMA";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.Location = new System.Drawing.Point(75, 111);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(151, 23);
            this.lbl_num.TabIndex = 1;
            this.lbl_num.Text = "Ingresar Valor:";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res.Location = new System.Drawing.Point(53, 153);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(173, 23);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "Los numeros son:";
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(529, 100);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(127, 47);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "GENERAR";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // comboBox_opciones
            // 
            this.comboBox_opciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_opciones.FormattingEnabled = true;
            this.comboBox_opciones.Location = new System.Drawing.Point(339, 108);
            this.comboBox_opciones.Name = "comboBox_opciones";
            this.comboBox_opciones.Size = new System.Drawing.Size(173, 31);
            this.comboBox_opciones.TabIndex = 4;
            // 
            // listBox_resultado
            // 
            this.listBox_resultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_resultado.FormattingEnabled = true;
            this.listBox_resultado.ItemHeight = 23;
            this.listBox_resultado.Location = new System.Drawing.Point(253, 185);
            this.listBox_resultado.Name = "listBox_resultado";
            this.listBox_resultado.Size = new System.Drawing.Size(205, 234);
            this.listBox_resultado.TabIndex = 5;
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(232, 107);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(78, 32);
            this.txt_num.TabIndex = 6;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.listBox_resultado);
            this.Controls.Add(this.comboBox_opciones);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_principal";
            this.Text = "Operacion";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ComboBox comboBox_opciones;
        private System.Windows.Forms.ListBox listBox_resultado;
        private System.Windows.Forms.TextBox txt_num;
    }
}

