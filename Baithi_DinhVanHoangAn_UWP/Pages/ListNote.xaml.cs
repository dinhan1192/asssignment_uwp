using Baithi_DinhVanHoangAn_UWP.Entity;
using Baithi_DinhVanHoangAn_UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class ListNote : Page
    {
        static ObservableCollection<Note> ListAllNote;
        private NoteModel noteModel;

        public ListNote()
        {
            this.InitializeComponent();
            this.noteModel = new NoteModel();
            this.Loaded += LoadNote;
        }

        private void LoadNote(object sender, RoutedEventArgs e)
        {
            var list = this.noteModel.Select();
            ListAllNote = new ObservableCollection<Note>(list);
            ListViewNote.ItemsSource = ListAllNote;
        }

        private void CreateNote_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateNote));
        }
    }
}
