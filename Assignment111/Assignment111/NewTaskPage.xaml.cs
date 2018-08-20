using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment111
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewTaskPage : ContentPage
	{
		public NewTaskPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            Task task = new Task() {

                taskName = taskEntry.Text,
                taskNote = noteEntry.Text,
                taskTime = timeEntry.Text

            };

            // Database Connection
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                //Generate Table
                conn.CreateTable<Task>();
                //Instert Values Into DB
                var numberOfRows = conn.Insert(task);

                if (numberOfRows > 0)
                    DisplayAlert("Success", "Success", "Success");
                else
                    DisplayAlert("error", "error", "error");
            }

            
    }

        
    }
}