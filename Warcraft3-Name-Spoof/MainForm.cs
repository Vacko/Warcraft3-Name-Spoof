using System;
using System.Drawing;
using System.Windows.Forms;
using Warcraft3_Name_Spoof.Infrastructure;

namespace Warcraft3_Name_Spoof
{
    public partial class MainForm : Form
    {
        #region Fields

        private readonly IManager m_game;
        private readonly IProcess m_process;

        private bool m_colorSelected;
        private bool m_isGameRunning;
        private bool m_isSelecting;

        #endregion

        #region Constructors

        public MainForm(IManager game, IProcess process)
        {
            m_game = game;
            m_process = process;

            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!m_isGameRunning) return;

            if (m_colorSelected)
            {
                m_game.WriteName("|c" + txtNewName.ForeColor.Name + txtNewName.Text);
                txtCurrentName.Text = txtNewName.Text;
                txtCurrentName.ForeColor = txtNewName.ForeColor;
            }
            else
            {
                m_game.WriteName(txtNewName.Text);
                txtCurrentName.Text = txtNewName.Text;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!m_isGameRunning) return;

            m_game.WriteName(txtOriginalName.Text);
            txtCurrentName.Text = txtOriginalName.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void pbxColor_MouseDown(object sender, MouseEventArgs e) => m_isSelecting = true;

        private void pbxColor_MouseMove(object sender, MouseEventArgs e)
        {
            Color clr = Color.White;

            if (!m_isSelecting) return;

            Bitmap bmpImage = (Bitmap) pbxColor.Image;

            if (e.Y > 0 && e.X > 0 && e.Y < pbxColor.Size.Height - 2 && e.X < pbxColor.Size.Width - 2)
                clr = bmpImage.GetPixel(e.X, e.Y);

            SetColor(clr);
        }

        private void pbxColor_MouseUp(object sender, MouseEventArgs e) => m_isSelecting = false;

        private void Refresh_Tick(object sender, EventArgs e)
        {
            if (m_process.IsProcessRunning() && m_isGameRunning == false)
            {
                m_isGameRunning = true;

                string readbuild = m_game.ReadBuild();

                if (readbuild != string.Empty)
                {
                    lblBuild.Text = readbuild;
                    txtOriginalName.Text = m_game.ReadName();
                    lblStatus.Text = "Running";
                    gbName.Enabled = true;
                    gbColor.Enabled = true;
                }
                else
                {
                    lblBuild.Text = "Not Supported";
                    lblStatus.Text = "Running";
                }
            }
            else if (!m_process.IsProcessRunning() && m_isGameRunning)
            {
                m_isGameRunning = false;

                lblStatus.Text = "Not Running";
                lblBuild.Text = "None";

                gbName.Enabled = false;
                gbColor.Enabled = false;
            }
        }

        private void SetColor(Color c)
        {
            txtRed.Text = c.R.ToString();
            txtGreen.Text = c.G.ToString();
            txtBlue.Text = c.B.ToString();

            txtNewName.ForeColor = c;
            m_colorSelected = true;

            pnlPreview.BackColor = c;
        }

        private void txtOriginalName_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void txtRed_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void txtRed_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (int.Parse(txt.Text) < 256)
            {
                SetColor(Color.FromArgb(Convert.ToInt32(txtRed.Text), Convert.ToInt32(txtGreen.Text),
                    Convert.ToInt32(txtBlue.Text)));
            }
            else
            {
                txt.Text = "0";
                MessageBox.Show("Wrong Color!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}