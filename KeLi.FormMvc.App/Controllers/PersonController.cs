using System.Windows.Forms;

using KeLi.FormMvc.App.Models;
using KeLi.FormMvc.App.Views;

namespace KeLi.FormMvc.App.Controllers
{
    public class PersonController
    {
        public PersonController(PersonForm view)
        {
            View = view;
            Model = new PersonModel("001", "Max");
            View.Controller = this;
        }

        public PersonForm View { get; set; }

        public PersonModel Model { get; set; }

        public void UpdateItem()
        {
            MessageBox.Show($"Id: {Model.Id}\r\nName: {Model.Name}");
        }
    }
}