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
        public Item Item { get; set; }

        public Command ClearCommand { get; set; }
        public Command SaveCommand { get; set; }

        public NewItemViewModel()
        {
            ClearCommand = new Command(async () => await ExecuteClearCommand());
            SaveCommand = new Command(async () => await ExecuteSaveCommand());

            Item = new Item();
        }

        private async Task ExecuteClearCommand()
        {
            Item = new Item();
        }
        private async Task ExecuteSaveCommand()
        {
            MessagingCenter.Send(this, MessagingCenterCommands.ADD_ITEM, Item);

        }
    }
}
