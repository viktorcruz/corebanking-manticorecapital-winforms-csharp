using ManticoreCapital.Application.Main.UserUseCsae.Commands;
using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Application.Main.UserUseCsae.Queries;
using ManticoreCapital.Presentation.UserControls;
using MediatR;
using QRCoder;
using System.Data;
using System.Drawing.Imaging;

namespace ManticoreCapital.Presentation.Forms
{
    public partial class UsersFrm : Form
    {
        #region Properties
        private readonly IMediator _mediator;
        private List<UserResponseDTO> _usersDto = new List<UserResponseDTO>();
        private DataTable _dataTable;
        private List<TextBox> _headerTextBoxes;
        private int _currentPage = 0;
        private int _pageSize = 100;
        private int _totalCount = 0;
        private const int _panelWidth = 1062;
        private const int _panelHeight = 670;
        public CancellationTokenSource _cancellationTokenSource;
        private ProgressBarUserControl _progressBarUserControl;
        #endregion

        #region Constructor
        public UsersFrm(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;

            this._progressBarUserControl = new ProgressBarUserControl();
            this._progressBarUserControl.Location = new System.Drawing.Point(0, 0);
            this._progressBarUserControl.Name = "_progressBarUserControl";
            this._progressBarUserControl.Size = new System.Drawing.Size(_panelWidth, 41);
            this._progressBarUserControl.TabIndex = 0;
            this._progressBarUserControl.Visible = false;
            this.Controls.Add(this._progressBarUserControl);
        }
        #endregion

        #region Configuration Methods
        private async void UsersFrm_Load(object sender, EventArgs e)
        {
            _currentPage = 1;
            this.Width = _panelWidth;
            this.Height = _panelHeight;

            lblCurrentDate.Text = DateTime.Now.ToString();
            GoToMainPanel();
            SetupDataGridView();
            SetupTableLayoutPanel();
            await RefreshData();

            InitializeProgressBarEvents();
        }

        private void SetupTableLayoutPanel()
        {
            tlpUsers.Dock = DockStyle.Fill;
            tlpUsers.Size = new System.Drawing.Size(_panelWidth, _panelHeight);

            tlpUserFrmInsert.Dock = DockStyle.Fill;
            tlpUserFrmInsert.Size = new System.Drawing.Size(_panelWidth, _panelHeight);

            tlpUserFrmEdit.Dock = DockStyle.Fill;
            tlpUserFrmEdit.Size = new System.Drawing.Size(_panelWidth, _panelHeight);

            var searchPanel = CreateSearchPanel();
            tlpUsers.Controls.Add(searchPanel, 0, 1);
        }

        private void SetupDataGridView()
        {
            dgvUsers.Width = 500;
            dgvUsers.Height = 500;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.DefaultCellStyle.BackColor = SystemColors.Control;
            dgvUsers.ReadOnly = true;
            dgvUsers.Columns.Clear();
            dgvUsers.DataSource = GetData();
            dgvUsers.RowHeadersVisible = false;

            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false,
            };
            dgvUsers.Columns.Add(idColumn);

            var nameColumn = new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                Visible = true,
                Width = 150
            };
            dgvUsers.Columns.Add(nameColumn);

            var lastNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "Last Name",
                DataPropertyName = "LastName",
                Visible = true,
                Width = 200
            };
            dgvUsers.Columns.Add(lastNameColumn);

            var emailColumn = new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                Visible = true,
                Width = 300
            };
            dgvUsers.Columns.Add(emailColumn);

            var passwordColumn = new DataGridViewTextBoxColumn
            {
                Name = "PasswordHash",
                DataPropertyName = "Password",
                Visible = false,
            };
            dgvUsers.Columns.Add(passwordColumn);

            var roleColumn = new DataGridViewTextBoxColumn
            {
                Name = "Role",
                DataPropertyName = "Role",
                Visible = true,
                Width = 100
            };
            dgvUsers.Columns.Add(roleColumn);

            var createdAtColumn = new DataGridViewTextBoxColumn
            {
                Name = "Created at",
                DataPropertyName = "CreatedAt",
                Visible = true,
                Width = 180
            };
            dgvUsers.Columns.Add(createdAtColumn);

            var isActiveColumn = new DataGridViewTextBoxColumn
            {
                Name = "Active",
                DataPropertyName = "IsActive",
                Visible = true,
                Width = 80,
            };
            dgvUsers.Columns.Add(isActiveColumn);

            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 226, 225);
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Black;

            _dataTable = GetData();
            dgvUsers.DataSource = _dataTable;

        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            //dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Role", typeof(string));
            dt.Columns.Add("CreatedAt", typeof(DateTime));
            dt.Columns.Add("IsActive", typeof(bool));

            return dt;
        }

        private DataGridView CreateDataGridView()
        {
            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true
            };

            dgv.DataSource = GetData();
            return dgv;
        }

        private async Task LoadPaginatedData(string search)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                await RunWithProgressAsync(async (cancellationToken) =>
                {
                    var query = new GetUserPaginatedQuery
                    {
                        DatabaseAdapter = RepositoryType.ADO,
                        PageNumber = _currentPage <= 0 ? 1 : _currentPage,
                        PageSize = _pageSize <= 0 ? 10 : _pageSize,
                        Search = string.IsNullOrWhiteSpace(search) ? string.Empty : search // Filtro seguro
                    };

                    var users = await _mediator.Send(query, cancellationToken);

                    if (users.Item2 == 0 || users.Item1 == null)
                    {
                        throw new InvalidOperationException("The query did not return any results.");
                    }

                    _usersDto = users.Item1;   // Lista de usuarios
                    _totalCount = users.Item2; // Total de registros
                    
                    UpdatedPaginationInfo();

                    Console.WriteLine($"Total Users: {_totalCount}");
                    foreach (var user in _usersDto)
                    {
                        Console.WriteLine($"User: {user.Name}, {user.Email}");
                    }

                    this.Invoke(new Action(() =>
                    {
                        dgvUsers.DataSource = null;
                        dgvUsers.DataSource = _usersDto;
                    }));

                    return users;
                }, "Loading users...");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("The operation was canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during data load: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData(string search = "")
        {
            await LoadPaginatedData(search);
        }
        #endregion

        #region Logic Methods
        private async void GoToMainPanel()
        {
            tlpUserFrmInsert.Visible = false;
            tlpUsers.Visible = true;
            tlpUsers.BringToFront();
            tlpUsers.Refresh();

            ClearControls(tlpUserFrmEdit);
            ClearControls(tlpUserFrmInsert);

            await RefreshData();
        }
        private void GoToNewPanel()
        {
            tlpUsers.Visible = false;
            tlpUserFrmInsert.Visible = true;
            tlpUserFrmInsert.BringToFront();
            tlpUserFrmInsert.Refresh();

        }
        private void GoToEditPanel()
        {
            tlpUsers.Visible = false;
            tlpUserFrmInsert.Visible = false;
            tlpUserFrmEdit.Visible = true;
            tlpUserFrmEdit.BringToFront();
            tlpUserFrmEdit.Refresh();
        }

        private void ClearControls(Control parentControl)
        {
            foreach (Control ctrl in parentControl.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (ctrl is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (ctrl.HasChildren)
                {
                    ClearControls(ctrl);
                }
            }
        }

        private FlowLayoutPanel CreateSearchPanel()
        {

            var panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(2)
            };

            int[] numbers = [147, 190, 290, 100, 170, 75];
            int visibleColumnIndex = 0;

            foreach (var column in dgvUsers.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible))
            {
                int columnWidth = numbers.Length > visibleColumnIndex ? numbers[visibleColumnIndex] : 100;
                if (column.Index == 6)
                {
                    var dateTimePicker = new DateTimePicker
                    {
                        Format = DateTimePickerFormat.Custom,
                        CustomFormat = "M/dd/yyyy",
                        Location = new System.Drawing.Point(50, 50),
                        Width = columnWidth
                    };
                    panel.Controls.Add(dateTimePicker);
                }
                else
                {
                    var textBox = new TextBox
                    {
                        Tag = column.DataPropertyName,
                        PlaceholderText = $"{column.HeaderText}...",
                        Width = columnWidth
                    };
                    textBox.TextChanged += (s, e) => ApplyFilter();
                    panel.Controls.Add(textBox);
                }
                visibleColumnIndex++;
            }

            return panel;
        }

        private void UpdatedPaginationInfo()
        {
            int totalPages = (int)Math.Ceiling((double)_totalCount / _pageSize);
            lblPage.Text = $"Page {_currentPage} of {totalPages} (Total Records: {_totalCount.ToString("###,###,###,###")})";
            lblTotalCount.Text = $"Total {_totalCount.ToString("###,###,###")}";
            lblCurrentRegisters.Text = $"Registers {_pageSize.ToString()}";
        }

        private void ApplyFilter()
        {
            var searchPanel = tlpUsers.GetControlFromPosition(0, 1) as FlowLayoutPanel;
            if (searchPanel == null)
            {
                return;
            }

            var allTextBoxes = searchPanel.Controls.OfType<TextBox>();

            if (allTextBoxes.All(txt => string.IsNullOrWhiteSpace(txt.Text)))
            {
                if (dgvUsers.DataSource is DataTable dt)
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else if (dgvUsers.DataSource is List<UserResponseDTO> myList)
                {
                    dgvUsers.DataSource = _usersDto;
                }

                return;
            }

            string filterExpression = string.Join(" AND ",
                searchPanel.Controls.OfType<TextBox>()
                .Where(txt => !string.IsNullOrWhiteSpace(txt.Text))
                .Select(txt =>
                {
                    string columnName = txt.Tag?.ToString();
                    if (string.IsNullOrEmpty(columnName))
                    {
                        return null;
                    }

                    string searchText = txt.Text.Replace("'", "''");
                    return $"{columnName} LIKE '%{searchText}%'";
                })
                .Where(condition => condition != null));

            if (dgvUsers.DataSource is DataTable dataTable)
            {
                dataTable.DefaultView.RowFilter = filterExpression;
            }
            else if (dgvUsers.DataSource is List<UserResponseDTO> myList)
            {
                var filteredList = myList.Where(item =>
                    searchPanel.Controls.OfType<TextBox>().All(txt =>
                    {
                        string columnName = txt.Tag?.ToString();
                        string searchText = txt.Text;

                        if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(searchText))
                            return true;

                        var propertyValue = item.GetType().GetProperty(columnName)?.GetValue(item)?.ToString();
                        return propertyValue?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
                    })
                ).ToList();

                dgvUsers.DataSource = filteredList;
            }
        }

        private async Task DeleteUser(string userId)
        {
            try
            {
                DeleteUserCommand query = new DeleteUserCommand { DatabaseAdapter = RepositoryType.ADO, UserId = userId };
                _ = await _mediator.Send(query);
                //LoadData();
                await RefreshData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private Bitmap GenerateQRCode(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData codeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(codeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(9);

            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = Path.Combine(folderPath, data + "_" + "QRCode.png");
            qrCodeImage.Save(fileName, ImageFormat.Png);

            return qrCodeImage;
        }

        private void SetupComboBoxCreate()
        {
            cbxCreateRole.Text = "Select a role..";
            cbxCreateRole.DataSource = Enum.GetValues(typeof(RoleType)).Cast<RoleType>();
        }

        private void SetupComboBoxEdit()
        {
            cbxEditRole.Text = "Select a role..";
            cbxEditRole.DataSource = Enum.GetValues(typeof(RoleType)).Cast<RoleType>();
        }

        private void FillData(string id)
        {
            var user = _usersDto.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                var qrCode = GenerateQRCode(user.Id);
                txtEditId.Text = user.Id;
                txtEditEmail.Text = user.Email;
                txtEditName.Text = user.Name;
                txtEditLastName.Text = user.LastName;
                ckbEditActive.Checked = user.IsActive;
                pbxEditQrCode.Visible = true;
                pbxEditQrCode.Image = qrCode;

                if (Enum.TryParse(user.Role.ToString(), out RoleType userRole))
                {
                    cbxEditRole.SelectedItem = userRole;
                }
            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowProgress(string message)
        {
            if (_progressBarUserControl == null)
            {
                throw new InvalidOperationException("The ProgressBarUserControl is not initialized.");
            }

            _progressBarUserControl.Show(message);
            _progressBarUserControl.BringToFront();
        }

        private void HideProgress()
        {
            if (_progressBarUserControl != null)
            {
                _progressBarUserControl.Hide();
            }
        }
        #endregion

        #region Event Methods
        private void InitializeProgressBarEvents()
        {
            _progressBarUserControl.CancelRequested += (s, e) =>
            {
                if (_cancellationTokenSource != null)
                {
                    _cancellationTokenSource.Cancel(); 
                }

                HideProgress();
                MessageBox.Show("Operation cancelled by the user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        private void dgvUsers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }

            var row = dgv.Rows[e.RowIndex];

            if (row.DataBoundItem is not null)
            {
                var roleValue = row.Cells["Role"].Value?.ToString();

                if (roleValue == "Customer")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
                else if (roleValue == "None")
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvUsers.Rows[e.RowIndex];
                var userId = selectedRow.Cells["Id"].Value?.ToString();
                txtId.Text = $"{userId}";
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)_totalCount / _pageSize);
            if (_currentPage < totalPage)
            {
                _currentPage++;
                Clean();
                await RefreshData();
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                Clean();
                await RefreshData();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GoToNewPanel();
            txtNewId.Text = Guid.NewGuid().ToString();
            var qrCode = GenerateQRCode(txtNewId.Text);
            pbxCreateQrCode.Visible = true;
            pbxCreateQrCode.Image = qrCode;
            SetupComboBoxCreate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GoToEditPanel();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var userId = dgvUsers.SelectedRows[0].Cells["Id"].Value?.ToString();
                var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    await DeleteUser(userId);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoToMainPanel();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var query = new CreateUserCommand
            {
                DatabaseAdapter = RepositoryType.ADO,
                Id = txtEditId.Text,
                Name = txtEditName.Text,
                LastName = txtEditLastName.Text,
                Email = txtEditEmail.Text,
                RFC = txtEditRFC.Text,
                IsActive = ckbEditActive.Checked,
                Role = (RoleType)cbxEditRole.SelectedIndex,
                CreatedAt = DateTime.Now
            };
            var users = await _mediator.Send(query);
            if (users != null)
            {
                MessageBox.Show("Ok", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GoToMainPanel();
        }

        private void btnEditBack_Click(object sender, EventArgs e)
        {
            GoToMainPanel();
        }

        private async void btnEditSave_Click(object sender, EventArgs e)
        {
            var query = new UpdateUserCommand
            {
                DatabaseAdapter = RepositoryType.ADO,
                Id = txtEditId.Text,
                Name = txtEditName.Text,
                LastName = txtEditLastName.Text,
                Email = txtEditEmail.Text,
                RFC = txtEditRFC.Text,
                IsActive = ckbEditActive.Checked,
                Role = (RoleType)cbxEditRole.SelectedIndex,
                LastUpdatedAt = DateTime.Now
            };
            var users = await _mediator.Send(query);
            if (users != null)
            {
                MessageBox.Show("Ok", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GoToMainPanel();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var userId = dgvUsers.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
                lblEditCurrentDate.Text = DateTime.Now.ToString();
                SetupComboBoxEdit();
                FillData(userId);
                GoToEditPanel();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await SearchUsers();
        }

        private async Task SearchUsers()
        {
            string? filter = txtSearch.Text?.Trim().ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                MessageBox.Show("Please enter a valid search term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource.Dispose();
            }

            await RunWithProgressAsync(async cancellationToken =>
            {
                var userFilter = await FilterUsers(filter, cancellationToken);

                if (userFilter.Any())
                {
                    dgvUsers.DataSource = userFilter;
                }
                else
                {
                    await RefreshData(filter);
                }

                return Task.CompletedTask;
            }, "Searching...");
        }


        private async Task<List<UserResponseDTO>> FilterUsers(string filter, CancellationToken cancellationToken)
        {
            var filteredUsers = new List<UserResponseDTO>();
            int steps = _usersDto.Count;
            int current = 0;

            foreach (var user in _usersDto)
            {
                cancellationToken.ThrowIfCancellationRequested();

                await Task.Delay(50, cancellationToken);

                bool matches = (!string.IsNullOrEmpty(user.Name) && user.Name.ToLower().Contains(filter)) ||
                               (!string.IsNullOrEmpty(user.Email) && user.Email.ToLower().Contains(filter)) ||
                               (!string.IsNullOrEmpty(user.LastName) && user.LastName.ToLower().Contains(filter)) ||
                               (!string.IsNullOrEmpty(user.Id) && user.Id.ToLower().Contains(filter));

                if (matches)
                {
                    filteredUsers.Add(user);
                }

                current++;
                int progress = (int)((double)current / steps * 100);

                this.Invoke(new Action(() =>
                {
                    _progressBarUserControl.Progress = progress;
                }));
            }

            return filteredUsers;
        }

        private void Clean()
        {
            txtSearch.Text = "";
            txtId.Text = "";
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            Clean();
            await RefreshData();
        }

        private async void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await SearchUsers();
            }
        }

        private async Task<T?> RunWithProgressAsync<T>(Func<CancellationToken, Task<T>> operation, string progressMessage)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                ShowProgress(progressMessage);
                var result = await operation(_cancellationTokenSource.Token);

                return result;
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Operation was cancelled by the user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
            finally
            {
                HideProgress();

                if (_cancellationTokenSource != null)
                {
                    _cancellationTokenSource.Dispose();
                    _cancellationTokenSource = null;
                }
            }
        }
        #endregion
    }
}
