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

namespace _5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnDiceSum_Click(object sender, RoutedEventArgs e)
        {
            int d1 = rng.Next(1, 7);
            int d2 = rng.Next(1, 7);
            int d3 = rng.Next(1, 7);

            TxtDice1.Text = d1.ToString();
            TxtDice2.Text = d2.ToString();
            TxtDice3.Text = d3.ToString();

            int sum = d1 + d2 + d3;
            TxtDiceResult.Text = $"加總得分：{sum} 分";
        }

        private void BtnDiceGame_Click(object sender, RoutedEventArgs e)
        {
            int d1 = rng.Next(1, 7);
            int d2 = rng.Next(1, 7);
            int d3 = rng.Next(1, 7);

            TxtDice1.Text = d1.ToString();
            TxtDice2.Text = d2.ToString();
            TxtDice3.Text = d3.ToString();

            // 將三顆骰子放入陣列並由小到大排序
            int[] dice = { d1, d2, d3 };
            Array.Sort(dice);

            // 判斷邏輯
            if (dice[0] == dice[1] && dice[1] == dice[2])
            {
                TxtDiceResult.Text = "豹子 (一色)";
            }
            else if (dice[0] == 1 && dice[1] == 2 && dice[2] == 3)
            {
                TxtDiceResult.Text = "逼基";
            }
            else if (dice[0] != dice[1] && dice[1] != dice[2] && dice[0] != dice[2])
            {
                TxtDiceResult.Text = "得分：0 分";
            }
            else
            {
                if (dice[0] == dice[1])
                {
                    TxtDiceResult.Text = $"得分：{dice[2]} 分";
                }
                else if (dice[1] == dice[2])
                {
                    TxtDiceResult.Text = $"得分：{dice[0]} 分";
                }
            }
        }
    }
}