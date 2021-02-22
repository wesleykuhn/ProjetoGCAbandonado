namespace GC.Components
{
    partial class CMP_BtnDelete
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
            this.SuspendLayout();
            this.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "btnRegular";
            this.Size = new System.Drawing.Size(130, 40);
            this.Text = "Mudar Texto";
            this.UseVisualStyleBackColor = true;
            this.ResumeLayout(false);
        }

        #endregion
    }
}
