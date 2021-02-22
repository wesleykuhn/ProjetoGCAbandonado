namespace GC.Components
{
    partial class CMP_BtnTopMinimize
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            //The BACK of panel
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImage = global::GC.Properties.Resources.icon_minimizar_18x18;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "pnlMinimize";
            this.Size = new System.Drawing.Size(50, 30);
        }

        #endregion
    }
}
