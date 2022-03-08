using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_MVVM_PATTERN.View
{
    public partial class PesonForm : Form
    {
        public PesonForm(Object viewmodel)
        {
            InitializeComponent();

            this.ViewModelBindingSource = 
                new BindingSource();

            this.ViewModelBindingSource
                .DataSource = viewmodel;

            this.InitializeDataBindings();

            firstNameTextBox.Leave += FirstNameTextBox_Leave;    
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            dataGridView.DataSource =
                ViewModelBindingSource.DataSource;
        }

        private void InitializeDataBindings()
        {
            this.firstNameTextBox
                .DataBindings
                .Add(
                propertyName: nameof(firstNameTextBox.Text),
                dataSource: this.ViewModelBindingSource,
                dataMember: nameof(Model.Person.FirstName),
                formattingEnabled: true)
                ;

            this.lastNameTextBox
                .DataBindings
                .Add(
                propertyName: nameof(lastNameTextBox.Text),
                dataSource: this.ViewModelBindingSource,
                dataMember: nameof(Model.Person.LastName),
                formattingEnabled: true)
                ;

            this.fullNameTextBox
                .DataBindings
                .Add(
                propertyName: nameof(fullNameTextBox.Text),
                dataSource: this.ViewModelBindingSource,
                dataMember: nameof(ViewModel.PersonViewModel.FullName),
                formattingEnabled: true)
                ;
        }
    }
}
