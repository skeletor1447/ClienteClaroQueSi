namespace ClaroQueSi
{
    partial class DashboardForm
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
            this.panelArriba = new System.Windows.Forms.Panel();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.panelUno = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDos = new System.Windows.Forms.Panel();
            this.panelCuatro = new System.Windows.Forms.Panel();
            this.panelTres = new System.Windows.Forms.Panel();
            this.btnYaSoyCliente = new System.Windows.Forms.Button();
            this.panelArribaPanelArriba = new System.Windows.Forms.Panel();
            this.panelArribaPanelAbajo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCuatroPanelArriba = new System.Windows.Forms.Panel();
            this.panelCuatroPanelAbajo = new System.Windows.Forms.Panel();
            this.panelArriba.SuspendLayout();
            this.panelUno.SuspendLayout();
            this.panelDos.SuspendLayout();
            this.panelCuatro.SuspendLayout();
            this.panelTres.SuspendLayout();
            this.panelArribaPanelAbajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelArriba
            // 
            this.panelArriba.Controls.Add(this.panelArribaPanelAbajo);
            this.panelArriba.Controls.Add(this.panelArribaPanelArriba);
            this.panelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArriba.Location = new System.Drawing.Point(0, 0);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(1000, 60);
            this.panelArriba.TabIndex = 0;
            // 
            // panelAbajo
            // 
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(0, 441);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(1000, 59);
            this.panelAbajo.TabIndex = 1;
            // 
            // panelUno
            // 
            this.panelUno.Controls.Add(this.label1);
            this.panelUno.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUno.Location = new System.Drawing.Point(0, 60);
            this.panelUno.Name = "panelUno";
            this.panelUno.Size = new System.Drawing.Size(227, 381);
            this.panelUno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beneficios";
            // 
            // panelDos
            // 
            this.panelDos.Controls.Add(this.label2);
            this.panelDos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDos.Location = new System.Drawing.Point(227, 60);
            this.panelDos.Name = "panelDos";
            this.panelDos.Size = new System.Drawing.Size(300, 381);
            this.panelDos.TabIndex = 3;
            // 
            // panelCuatro
            // 
            this.panelCuatro.Controls.Add(this.panelCuatroPanelAbajo);
            this.panelCuatro.Controls.Add(this.panelCuatroPanelArriba);
            this.panelCuatro.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCuatro.Location = new System.Drawing.Point(782, 60);
            this.panelCuatro.Name = "panelCuatro";
            this.panelCuatro.Size = new System.Drawing.Size(218, 381);
            this.panelCuatro.TabIndex = 4;
            // 
            // panelTres
            // 
            this.panelTres.Controls.Add(this.label3);
            this.panelTres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTres.Location = new System.Drawing.Point(527, 60);
            this.panelTres.Name = "panelTres";
            this.panelTres.Size = new System.Drawing.Size(255, 381);
            this.panelTres.TabIndex = 5;
            // 
            // btnYaSoyCliente
            // 
            this.btnYaSoyCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYaSoyCliente.Location = new System.Drawing.Point(858, 0);
            this.btnYaSoyCliente.Name = "btnYaSoyCliente";
            this.btnYaSoyCliente.Size = new System.Drawing.Size(142, 29);
            this.btnYaSoyCliente.TabIndex = 0;
            this.btnYaSoyCliente.Text = "Ya soy cliente";
            this.btnYaSoyCliente.UseVisualStyleBackColor = true;
            this.btnYaSoyCliente.Click += new System.EventHandler(this.btnYaSoyCliente_Click);
            // 
            // panelArribaPanelArriba
            // 
            this.panelArribaPanelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArribaPanelArriba.Location = new System.Drawing.Point(0, 0);
            this.panelArribaPanelArriba.Name = "panelArribaPanelArriba";
            this.panelArribaPanelArriba.Size = new System.Drawing.Size(1000, 31);
            this.panelArribaPanelArriba.TabIndex = 1;
            // 
            // panelArribaPanelAbajo
            // 
            this.panelArribaPanelAbajo.Controls.Add(this.btnYaSoyCliente);
            this.panelArribaPanelAbajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArribaPanelAbajo.Location = new System.Drawing.Point(0, 31);
            this.panelArribaPanelAbajo.Name = "panelArribaPanelAbajo";
            this.panelArribaPanelAbajo.Size = new System.Drawing.Size(1000, 29);
            this.panelArribaPanelAbajo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quieres un prestamo de $500 a $1000?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Requisitos";
            // 
            // panelCuatroPanelArriba
            // 
            this.panelCuatroPanelArriba.AutoSize = true;
            this.panelCuatroPanelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCuatroPanelArriba.Location = new System.Drawing.Point(0, 0);
            this.panelCuatroPanelArriba.Name = "panelCuatroPanelArriba";
            this.panelCuatroPanelArriba.Size = new System.Drawing.Size(218, 0);
            this.panelCuatroPanelArriba.TabIndex = 0;
            this.panelCuatroPanelArriba.Visible = false;
            // 
            // panelCuatroPanelAbajo
            // 
            this.panelCuatroPanelAbajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuatroPanelAbajo.Location = new System.Drawing.Point(0, 0);
            this.panelCuatroPanelAbajo.Name = "panelCuatroPanelAbajo";
            this.panelCuatroPanelAbajo.Size = new System.Drawing.Size(218, 381);
            this.panelCuatroPanelAbajo.TabIndex = 1;
            this.panelCuatroPanelAbajo.Visible = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelTres);
            this.Controls.Add(this.panelCuatro);
            this.Controls.Add(this.panelDos);
            this.Controls.Add(this.panelUno);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panelArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "Form1";
            this.panelArriba.ResumeLayout(false);
            this.panelUno.ResumeLayout(false);
            this.panelUno.PerformLayout();
            this.panelDos.ResumeLayout(false);
            this.panelDos.PerformLayout();
            this.panelCuatro.ResumeLayout(false);
            this.panelCuatro.PerformLayout();
            this.panelTres.ResumeLayout(false);
            this.panelTres.PerformLayout();
            this.panelArribaPanelAbajo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelArriba;
        private System.Windows.Forms.Panel panelAbajo;
        private System.Windows.Forms.Panel panelUno;
        private System.Windows.Forms.Panel panelDos;
        private System.Windows.Forms.Panel panelCuatro;
        private System.Windows.Forms.Panel panelTres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYaSoyCliente;
        private System.Windows.Forms.Panel panelArribaPanelAbajo;
        private System.Windows.Forms.Panel panelArribaPanelArriba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCuatroPanelAbajo;
        private System.Windows.Forms.Panel panelCuatroPanelArriba;
    }
}

