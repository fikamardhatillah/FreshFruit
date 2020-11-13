using FreshFruit.Controller;
using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller fika;
        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(5);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            fika = new Seller("Fika", bucketController);
            listBoxBucket.ItemsSource = keranjangBuah.findAll();
        }
        public void onFailed(string massage)
        {
            MessageBox.Show(massage);
        }
        public void onSucceed(string massage)
        {
            listBoxBucket.Items.Refresh();
        }
        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("anggur");
            fika.addFruit(anggur);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            fika.addFruit(apple);

            listBoxBucket.Items.Refresh();

        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("banana");
            fika.addFruit(banana);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("orange");
            fika.addFruit(orange);

            listBoxBucket.Items.Refresh();
        }
    }
}