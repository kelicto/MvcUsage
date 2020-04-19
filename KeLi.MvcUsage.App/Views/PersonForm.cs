using System;
using System.Windows.Forms;

using KeLi.MvcUsage.App.Controllers;

namespace KeLi.MvcUsage.App.Views
{
    public partial class PersonForm : Form
    {
        private PersonController _controller;

        public PersonForm()
        {
            InitializeComponent();
        }

        public PersonController Controller
        {
            get => _controller;

            set
            {
                _controller = value;

                tbId.DataBindings.Add("Text", Controller.Model, "Id");

                tbName.DataBindings.Add("Text", Controller.Model, "Name");
            }
        }

        private void BtnChangeFore_Click(object sender, EventArgs e)
        {
            var names = new[]
            {
                "Tom",
                "Jack",
                "John"
            };

            Controller.Model.Id = new Random().Next(100, 1000).ToString();

            Controller.Model.Name = names[new Random().Next(0, names.Length)];

            Controller.UpdateItem();
        }

        private void BtnChangeBack_Click(object sender, EventArgs e)
        {
            Controller.UpdateItem();
        }
    }
}