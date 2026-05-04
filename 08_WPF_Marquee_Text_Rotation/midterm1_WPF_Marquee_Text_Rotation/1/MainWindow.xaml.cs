using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] texts = { "北", "東", "南", "西" };
        private Brush[] colors = { Brushes.Black, Brushes.Red, Brushes.Green, Brushes.Blue };
        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }
        private void BtnLeft_Click(object sender, RoutedEventArgs e)
        {
            // 逆時鐘代表：上面的資料要變成右邊的，右邊變成下面的...
            // 所以我們先把 [0] (上) 的資料先備份起來
            string tempText = texts[0];
            Brush tempColor = colors[0];

            // 把後面的資料往前擠 (1給0, 2給1, 3給2)
            for (int i = 0; i < 3; i++)
            {
                texts[i] = texts[i + 1];
                colors[i] = colors[i + 1];
            }

            // 最後把原本備份的 [0] 塞到最後面 [3] (左)
            texts[3] = tempText;
            colors[3] = tempColor;

            // 資料大風吹完了，叫畫面更新
            UpdateUI();
        }
        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            // 順時鐘代表：上面的資料要變成左邊的，左邊變成下面的...
            // 所以這次我們先備份 [3] (左) 的資料
            string tempText = texts[3];
            Brush tempColor = colors[3];

            // 把前面的資料往後擠 (2給3, 1給2, 0給1)
            for (int i = 3; i > 0; i--)
            {
                texts[i] = texts[i - 1];
                colors[i] = colors[i - 1];
            }

            // 把備份的 [3] 塞回最前面 [0] (上)
            texts[0] = tempText;
            colors[0] = tempColor;

            // 資料大風吹完了，叫畫面更新
            UpdateUI();
        }
        private void UpdateUI()
        {
            TxtTop.Text = texts[0];
            TxtTop.Foreground = colors[0];

            TxtRight.Text = texts[1];
            TxtRight.Foreground = colors[1];

            TxtBottom.Text = texts[2];
            TxtBottom.Foreground = colors[2];

            TxtLeft.Text = texts[3];
            TxtLeft.Foreground = colors[3];
        }
    }
}