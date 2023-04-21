namespace Navegador
{
    partial class frmWeb
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
            this.wbNavegaor = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbNavegaor
            // 
            this.wbNavegaor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbNavegaor.Location = new System.Drawing.Point(0, 0);
            this.wbNavegaor.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNavegaor.Name = "wbNavegaor";
            this.wbNavegaor.Size = new System.Drawing.Size(800, 450);
            this.wbNavegaor.TabIndex = 0;
            this.wbNavegaor.Url = new System.Uri("https://www.google.com/webhp?hl=es-419&sa=X&ved=0ahUKEwjl25fvmaL-AhXyr4QIHXJtABsQ" +
        "PAgI", System.UriKind.Absolute);
            // 
            // frmWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbNavegaor);
            this.Name = "frmWeb";
            this.Text = "WWW";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbNavegaor;
    }
}

