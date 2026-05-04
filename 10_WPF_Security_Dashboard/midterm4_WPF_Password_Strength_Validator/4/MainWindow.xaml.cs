using System.Linq;
using System.Windows;


namespace _4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCheckStrength_Click(object sender, RoutedEventArgs e)
        {
            string pwd = TxtPasswordInput.Text;

            // 條件 A: 至少 5 碼
            // 條件 B: 至少一個大寫
            // 條件 C: 至少一個小寫
            // 條件 D: 至少一個數字
            if (pwd.Length >= 5 &&
                pwd.Any(char.IsUpper) &&
                pwd.Any(char.IsLower) &&
                pwd.Any(char.IsDigit))
            {
                MessageBox.Show("通過", "驗證結果");
            }
            else
            {
                MessageBox.Show("密碼強度不足", "驗證結果", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}