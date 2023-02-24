using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MangaView.Classes;

namespace MangaView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Manga> NewMangaArr { get; set; }
        public MainWindow()
        {
            this.NewMangaArr = new ObservableCollection<Manga>();
            // Create 5 fake Manga
            // Todo : Replace with db or api for new
            for (int i = 0; i <= 4; i++)
            {
                this.NewMangaArr.Add(new Manga(i, "one Piece-" + i));
                Trace.WriteLine(this.NewMangaArr[i].Name);
            }
            DataContext = this;

            InitializeComponent();
        }
    }
}
