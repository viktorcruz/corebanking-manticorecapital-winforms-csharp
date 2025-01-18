using ManticoreCapital.Presentation.Forms;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManticoreCapital.Presentation.Startup
{
    public partial class StartupFrm : Form
    {
        private readonly IMediator _mediator;
        private readonly Dictionary<Type, Form> _forms = new();
        private UsersFrm? _usersFrm = null;

        public StartupFrm(IMediator mediator)
        {
            InitializeComponent();

            _mediator = mediator;
        }

        private void OpenForm<T>(Func<Form> createForm) where T : Form
        {
            try
            {
                if (_forms.ContainsKey(typeof(T)))
                {
                    var frm = _forms[typeof(T)];
                    if (frm != null && !frm.IsDisposed)
                    {
                        frm.Activate();
                        return;
                    }
                }

                var newFrm = createForm();
                _forms[typeof(T)] = newFrm;

                if (this.IsMdiContainer)
                {
                    newFrm.MdiParent = this;
                }

                newFrm.FormClosed += new FormClosedEventHandler(Form_Closed);
                newFrm.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form frm)
            {
                _forms.Remove(frm.GetType());
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenForm<UsersFrm>(() => new UsersFrm(_mediator));
            }
            catch (Exception ex)
            {

            }
        }
    }
}
