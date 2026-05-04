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

namespace _3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentInput = "";
        private readonly string defaultPassword = "0542";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LockPad_Click(object sender, RoutedEventArgs e)
        {
            // 如果已經輸入滿 4 碼（或顯示了成功/失敗），就不再接收輸入
            if (currentInput.Length >= 4 || TxtLockDisplay.Text == "success" || TxtLockDisplay.Text == "error")
                return;

            Button btn = sender as Button;
            currentInput += btn.Content.ToString();

            if (currentInput.Length < 4)
            {
                // 右邊補齊米字號
                TxtLockDisplay.Text = currentInput.PadRight(4, '*');
            }
            else
            {
                if (currentInput == defaultPassword)
                {
                    TxtLockDisplay.Text = "success";
                }
                else
                {
                    TxtLockDisplay.Text = "error";
                }
            }
        }

        private void BtnLockClear_Click(object sender, RoutedEventArgs e)
        {
            currentInput = "";
            TxtLockDisplay.Text = "****";
        }
    }
}