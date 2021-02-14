using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TagList.Models;
using TagList.Services;
using Xamarin.Forms;

namespace TagList.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                SetProperty(ref _description, value);
            }
        }

        public Command ClearCommand { get; set; }
        public Command SaveCommand { get; set; }

        public NewItemViewModel()
        {
            ClearCommand = new Command(async () => await ExecuteClearCommand());
            SaveCommand = new Command(async () => await ExecuteSaveCommand());

            Clear();
        }

        private async Task ExecuteClearCommand()
        {
            Clear();
        }
        private async Task ExecuteSaveCommand()
        {
            var item = new Item()
            {
                Text = Title,
                Description = Description
            };

            MessagingCenter.Send(this, MessagingCenterCommands.ADD_ITEM, item);

            Clear();
        }

        private void Clear()
        {
            Description = null;
            Title = null;
        }
    }
}
