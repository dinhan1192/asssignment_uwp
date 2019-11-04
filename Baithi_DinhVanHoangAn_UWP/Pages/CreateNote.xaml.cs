using Baithi_DinhVanHoangAn_UWP.Entity;
using Baithi_DinhVanHoangAn_UWP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Baithi_DinhVanHoangAn_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateNote : Page
    {
        private NoteModel noteModel;

        public CreateNote()
        {
            this.InitializeComponent();
            this.noteModel = new NoteModel();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Note note = new Note()
            {
                Title = Title.Text,
                Content = Content.Text,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            noteModel.Insert(note);
            this.Frame.Navigate(typeof(ListNote));
        }
    }
}
