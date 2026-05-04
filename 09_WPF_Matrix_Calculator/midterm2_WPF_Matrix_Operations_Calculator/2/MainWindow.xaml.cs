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

namespace _2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // 1. 取得四個輸入框的值 (若輸入非數字會跳到 catch 區塊)
                double a = double.Parse(txtA.Text); // 左上
                double b = double.Parse(txtB.Text); // 左下
                double c = double.Parse(txtC.Text); // 右下
                double d = double.Parse(txtD.Text); // 向量下

                // 2. 檢查作業要求的條件：輸入數字範圍為 -1000 ~ 1000 之間
                if (a < -1000 || a > 1000 || b < -1000 || b > 1000 ||
                    c < -1000 || c > 1000 || d < -1000 || d > 1000)
                {
                    MessageBox.Show("請確保所有輸入的數字都在 -1000 到 1000 之間！", "範圍錯誤");
                    return; // 終止計算
                }

                // 3. 進行矩陣乘法運算
                // 計算 x: (左上 * 上) + (右上 * 下)
                // Math.Pow(a, 1.0/4.0) 就是 a 的 4 次方根
                double x = (Math.Pow(a, 1.0 / 4.0) * 3) + (8 * Math.Pow(d, 1.0 / 2.0));

                // 計算 y: (左下 * 上) + (右下 * 下)
                // Math.Pow(c, 3) 就是 c 的 3 次方
                double y = (b * 3) + (Math.Pow(c, 3) * Math.Pow(d, 1.0 / 2.0));

                // 4. 將結果顯示在畫面上 (取小數點後兩位讓畫面看起來乾淨)
                txtResultX.Text = Math.Round(x, 2).ToString();
                txtResultY.Text = Math.Round(y, 2).ToString();
            }
            catch (System.FormatException)
            {
                // 防呆機制：如果使用者沒有輸入數字（或是輸入英文字母）
                MessageBox.Show("請在所有的格子中輸入正確的數字格式！", "格式錯誤");
            }
        }
    }
}