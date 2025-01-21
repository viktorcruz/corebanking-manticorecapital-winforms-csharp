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

namespace ManticoreCapital.Presentation.Forms
{
    public partial class AccountsFrm : Form
    {
        private readonly IMediator _mediator;

        public AccountsFrm(IMediator mediatro)
        {
            InitializeComponent();

            _mediator = mediatro;
        }

        private void AccountsFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
