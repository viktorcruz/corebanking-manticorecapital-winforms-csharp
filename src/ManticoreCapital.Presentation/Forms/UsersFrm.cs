using ManticoreCapital.Application.Main.UserUseCsae.Queries;
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
    public partial class UsersFrm : Form
    {
        private readonly IMediator _mediator;
        private int _currentPage = 1;
        private int _pageSize = 100;
        private int _totalCount = 0;

        public UsersFrm(IMediator mediator)
        {
            InitializeComponent();

            _mediator = mediator;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            UserFrmLogad();
        }

        private async void UserFrmLogad()
        {
            var query = new GetUserPaginatedQuery { DatabaseAdapter = RepositoryType.ADO, PageNumber = _currentPage, PageSize = _pageSize, Search = "" };
            var users = await _mediator.Send(query);
            
        }
    }
}
