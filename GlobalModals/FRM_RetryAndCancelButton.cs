using System;
using System.Threading.Tasks;
using GC.Library.Style;

namespace GC.GlobalModals
{
    public partial class FRM_RetryAndCancelButton : Forms.Bases.FRM_Default
    {
        internal event EventHandler OnChildCancel;

        Task Task;

        byte Counter = 0;

        public FRM_RetryAndCancelButton()
        {
            InitializeComponent();

            this.ReadyForm();

            this.UnableClose();
            this.UnableMinimize();

            lblText.Text = "Um erro está impedindo o programa de se conectar a internet! Por favor, aguarde enquanto o programa tenta fazer a conexão.";

            BackColor = ColorsPalette.GDE_Danger;
        }

        internal new void Show()
        {
            this.Task = new Task(() => ShowDialog());
            this.Task.Start();
        }

        internal void CustomClose()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.Close();
                }));
            }
            else
            {
                try
                {
                    this.Close();
                }
                catch (InvalidOperationException)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Close();
                    }));
                }
            }
        }

        internal void MoveCounter()
        {
            this.Counter++;
            lblCounter.Text = "Tentativa: " + Counter.ToString() + " de 10";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            OnChildCancel(this, new EventArgs());
        }

        private void FrmModal_RetryAndCancelButton_Shown(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.Activate();
                }));
            }
            else
            {
                try
                {
                    this.Activate();
                }
                catch (InvalidOperationException)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Activate();
                    }));
                }
            }
        }
    }
}
