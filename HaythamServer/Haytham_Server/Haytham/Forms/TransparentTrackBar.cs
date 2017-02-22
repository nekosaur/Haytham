using System;
using System.Windows.Forms;

namespace Haytham.Forms
{
    public partial class TransparentTrackBar : TrackBar
    {
        public TransparentTrackBar()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            try
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);

                //if (Parent != null)
                //    BackColor = Parent.BackColor;

                //base.OnCreateControl();
            }
            catch (Exception e)
            {

            }
        }
    }
}
