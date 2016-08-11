# XamarinFormsListViewXamlImage
Sample: Using Xamarin.Forms.ListView on XAML, with outside custom ContentView.

## Pickuped code
### Page1.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamarinFormsListViewXamlImage.Page1"
             xmlns:local="clr-namespace:XamarinFormsListViewXamlImage;assembly=XamarinFormsListViewXamlImage"
             >
    <ListView x:Name="mylist" ItemsSource="{Binding}" VerticalOptions="FillAndExpand" RowHeight="200" HasUnevenRows="True">
        <ListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <local:MyListItemView />
                </ViewCell>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</ContentPage>
```

### MyListItemView.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentView xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamarinFormsListViewXamlImage.MyListItemView">
    <ContentView.Content>
        <StackLayout Orientation="Horizontal" Padding="10" VerticalOptions="Start"> <!-- BackgroundColor="#444" -->
            <Image Source="{Binding Image}" WidthRequest="50" VerticalOptions="Start" />
            <StackLayout Orientation="Vertical" Padding="10, 0, 0, 0">
                <Label Text="{Binding Name}" />
                <Label Text="{Binding State}" />
            </StackLayout>
        </StackLayout>
    </ContentView.Content>
</ContentView>
```

### Page1.xaml.cs
```
public Page1()
{
    InitializeComponent();

    // Make data list
    List<ItemInfo> list = new List<ItemInfo>();
    list.Add(
        new ItemInfo
        {
            Image = "https://avatars0.githubusercontent.com/u/20608487?v=3&s=200",
            Name = "John",
            State = RandomDup("Hello")
        }
    );
    list.Add(
        new ItemInfo
        {
            Image = "https://avatars0.githubusercontent.com/u/20608487?v=3&s=200",
            Name = "Kei",
            State = RandomDup("こんにちは")
        }
    );
    list.Add(
        new ItemInfo
        {
            Image = "https://avatars0.githubusercontent.com/u/20608487?v=3&s=200",
            Name = "Tama",
            State = RandomDup("(◔౪◔)!!!")
        }
    );

    // Bind
    this.BindingContext = list;
}
```

## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsListViewXamlImage/master/screenshots/screenshot.png)
