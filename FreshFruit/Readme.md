# Fresh Fruit
Merupakan aplikasi keranjang buah sederhana yang dapat memasukkan dan menghapus item berupa buah dari sebuah keranjang.

## Fungsionalities
-dapat memasukkan buah kedalam keranjang 

-dapat menghapus buah yang tidak diinginkan

-medapat info keranjang penuh jika buah melebihi batas keranjang.

## How does it works?
Terdapat method pada folder model yaitu class 

```Bucket.cs``` ```BucketEventListener.cs``` ```Fruit.cs``` dan ```Seller.cs```

Konsep view pada ```MainWindow.xaml```

Dan folder Controller yaitu class ```BucketController.cs```

Untuk menambahkan dan mengurangi isi keranjang dapat dilakukan pada ```MainWindow.xaml.cs```

``` public MainWindow()
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
```

