using System;
using System.Collections.Generic;
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

namespace MangaView.Components
{
    /// <summary>
    /// Logique d'interaction pour AnimeCard.xaml
    /// </summary>
    public partial class AnimeCard : UserControl
    {
        public static readonly DependencyProperty MangaProperty =
            DependencyProperty.Register("Manga", typeof(Manga), typeof(AnimeCard));

        public Manga Manga
        {
            get { return (Manga)GetValue(MangaProperty); }
            set { SetValue(MangaProperty, value); }
        }

        public AnimeCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }

    }
}
