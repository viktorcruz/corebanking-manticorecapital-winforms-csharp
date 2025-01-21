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
    public partial class CustomersFrm : Form
    {
        private readonly IMediator _mediator;

        public CustomersFrm(IMediator mediator)
        {
            InitializeComponent();

            _mediator = mediator;
        }

        private void CustomersFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
