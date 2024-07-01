namespace Parcial2
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
            this.btnRegistrarNuevo = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.btnVerExpedientesPorDNI = new System.Windows.Forms.Button();
            this.btnVerCausa = new System.Windows.Forms.Button();
            this.tbNumeroCausa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarNuevo
            // 
            this.btnRegistrarNuevo.Location = new System.Drawing.Point(8, 37);
            this.btnRegistrarNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarNuevo.Name = "btnRegistrarNuevo";
            this.btnRegistrarNuevo.Size = new System.Drawing.Size(146, 60);
            this.btnRegistrarNuevo.TabIndex = 0;
            this.btnRegistrarNuevo.Text = "Registrar Nuevo";
            this.btnRegistrarNuevo.UseVisualStyleBackColor = true;
            this.btnRegistrarNuevo.Click += new System.EventHandler(this.btnRegistrarNuevo_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(169, 37);
            this.btnVerTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(146, 60);
            this.btnVerTodos.TabIndex = 1;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ver Mayores al Promedio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(78, 60);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(166, 22);
            this.tbDNI.TabIndex = 3;
            this.tbDNI.Text = "tbDNI";
            // 
            // btnVerExpedientesPorDNI
            // 
            this.btnVerExpedientesPorDNI.Location = new System.Drawing.Point(326, 41);
            this.btnVerExpedientesPorDNI.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerExpedientesPorDNI.Name = "btnVerExpedientesPorDNI";
            this.btnVerExpedientesPorDNI.Size = new System.Drawing.Size(146, 60);
            this.btnVerExpedientesPorDNI.TabIndex = 4;
            this.btnVerExpedientesPorDNI.Text = "Ver Expedientes";
            this.btnVerExpedientesPorDNI.UseVisualStyleBackColor = true;
            this.btnVerExpedientesPorDNI.Click += new System.EventHandler(this.btnVerExpedientesPorDNI_Click);
            // 
            // btnVerCausa
            // 
            this.btnVerCausa.Location = new System.Drawing.Point(323, 23);
            this.btnVerCausa.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerCausa.Name = "btnVerCausa";
            this.btnVerCausa.Size = new System.Drawing.Size(146, 60);
            this.btnVerCausa.TabIndex = 5;
            this.btnVerCausa.Text = "Ver ";
            this.btnVerCausa.UseVisualStyleBackColor = true;
            this.btnVerCausa.Click += new System.EventHandler(this.btnVerCausa_Click);
            // 
            // tbNumeroCausa
            // 
            this.tbNumeroCausa.Location = new System.Drawing.Point(76, 42);
            this.tbNumeroCausa.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumeroCausa.Name = "tbNumeroCausa";
            this.tbNumeroCausa.Size = new System.Drawing.Size(165, 22);
            this.tbNumeroCausa.TabIndex = 6;
            this.tbNumeroCausa.Text = "tbNumeroCausa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarNuevo);
            this.groupBox1.Controls.Add(this.btnVerTodos);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(486, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expedientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerExpedientesPorDNI);
            this.groupBox2.Controls.Add(this.tbDNI);
            this.groupBox2.Location = new System.Drawing.Point(13, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(489, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Expedientes de una persona";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerCausa);
            this.groupBox3.Controls.Add(this.tbNumeroCausa);
            this.groupBox3.Location = new System.Drawing.Point(16, 264);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(486, 95);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ver Expediente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarNuevo;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button btnVerExpedientesPorDNI;
        private System.Windows.Forms.Button btnVerCausa;
        private System.Windows.Forms.TextBox tbNumeroCausa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

