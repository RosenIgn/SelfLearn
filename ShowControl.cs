using System.Windows.Forms;

namespace Self_Learn
{
    class ShowControl
    {
        public static void showControl(Control control, Control panel1) /* Показване на друг UserControl от UserControl */
        {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel1.Controls.Add(control);
        }
    }
}
