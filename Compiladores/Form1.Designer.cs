namespace Compiladores
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.claseAFNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concatenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerraduraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerraduraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unionParaAnalizadorSintacticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirAFNAAFDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizarUnaCadenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisSintacticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.claseAFNToolStripMenuItem,
            this.analisisSintacticoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(799, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // claseAFNToolStripMenuItem
            // 
            this.claseAFNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicoToolStripMenuItem,
            this.unirToolStripMenuItem,
            this.concatenarToolStripMenuItem,
            this.cerraduraToolStripMenuItem,
            this.cerraduraToolStripMenuItem1,
            this.opcionalToolStripMenuItem,
            this.unionParaAnalizadorSintacticoToolStripMenuItem,
            this.convertirAFNAAFDToolStripMenuItem,
            this.analizarUnaCadenaToolStripMenuItem});
            this.claseAFNToolStripMenuItem.Name = "claseAFNToolStripMenuItem";
            this.claseAFNToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.claseAFNToolStripMenuItem.Text = "AFN\'S";
            this.claseAFNToolStripMenuItem.Click += new System.EventHandler(this.claseAFNToolStripMenuItem_Click);
            // 
            // basicoToolStripMenuItem
            // 
            this.basicoToolStripMenuItem.Name = "basicoToolStripMenuItem";
            this.basicoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.basicoToolStripMenuItem.Text = "Basico";
            this.basicoToolStripMenuItem.Click += new System.EventHandler(this.basicoToolStripMenuItem_Click);
            // 
            // unirToolStripMenuItem
            // 
            this.unirToolStripMenuItem.Name = "unirToolStripMenuItem";
            this.unirToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.unirToolStripMenuItem.Text = "Unir";
            this.unirToolStripMenuItem.Click += new System.EventHandler(this.unirToolStripMenuItem_Click);
            // 
            // concatenarToolStripMenuItem
            // 
            this.concatenarToolStripMenuItem.Name = "concatenarToolStripMenuItem";
            this.concatenarToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.concatenarToolStripMenuItem.Text = "Concatenar";
            this.concatenarToolStripMenuItem.Click += new System.EventHandler(this.concatenarToolStripMenuItem_Click);
            // 
            // cerraduraToolStripMenuItem
            // 
            this.cerraduraToolStripMenuItem.Name = "cerraduraToolStripMenuItem";
            this.cerraduraToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cerraduraToolStripMenuItem.Text = "Cerradura +";
            this.cerraduraToolStripMenuItem.Click += new System.EventHandler(this.cerraduraToolStripMenuItem_Click);
            // 
            // cerraduraToolStripMenuItem1
            // 
            this.cerraduraToolStripMenuItem1.Name = "cerraduraToolStripMenuItem1";
            this.cerraduraToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.cerraduraToolStripMenuItem1.Text = "Cerradura *";
            this.cerraduraToolStripMenuItem1.Click += new System.EventHandler(this.cerraduraToolStripMenuItem1_Click);
            // 
            // opcionalToolStripMenuItem
            // 
            this.opcionalToolStripMenuItem.Name = "opcionalToolStripMenuItem";
            this.opcionalToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.opcionalToolStripMenuItem.Text = "Opcional";
            this.opcionalToolStripMenuItem.Click += new System.EventHandler(this.opcionalToolStripMenuItem_Click);
            // 
            // unionParaAnalizadorSintacticoToolStripMenuItem
            // 
            this.unionParaAnalizadorSintacticoToolStripMenuItem.Name = "unionParaAnalizadorSintacticoToolStripMenuItem";
            this.unionParaAnalizadorSintacticoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.unionParaAnalizadorSintacticoToolStripMenuItem.Text = "Union para analizador sintactico";
            this.unionParaAnalizadorSintacticoToolStripMenuItem.Click += new System.EventHandler(this.unionParaAnalizadorSintacticoToolStripMenuItem_Click);
            // 
            // convertirAFNAAFDToolStripMenuItem
            // 
            this.convertirAFNAAFDToolStripMenuItem.Name = "convertirAFNAAFDToolStripMenuItem";
            this.convertirAFNAAFDToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.convertirAFNAAFDToolStripMenuItem.Text = "Convertir AFN a AFD";
            this.convertirAFNAAFDToolStripMenuItem.Click += new System.EventHandler(this.convertirAFNAAFDToolStripMenuItem_Click);
            // 
            // analizarUnaCadenaToolStripMenuItem
            // 
            this.analizarUnaCadenaToolStripMenuItem.Name = "analizarUnaCadenaToolStripMenuItem";
            this.analizarUnaCadenaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.analizarUnaCadenaToolStripMenuItem.Text = "Analizar una cadena";
            this.analizarUnaCadenaToolStripMenuItem.Click += new System.EventHandler(this.analizarUnaCadenaToolStripMenuItem_Click);
            // 
            // analisisSintacticoToolStripMenuItem
            // 
            this.analisisSintacticoToolStripMenuItem.Name = "analisisSintacticoToolStripMenuItem";
            this.analisisSintacticoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.analisisSintacticoToolStripMenuItem.Text = "Analisis sintactico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 487);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem claseAFNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concatenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraduraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraduraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unionParaAnalizadorSintacticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirAFNAAFDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizarUnaCadenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisSintacticoToolStripMenuItem;
    }
}

