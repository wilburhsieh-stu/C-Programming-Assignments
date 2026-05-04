using System;
using System.Windows;
using System.Windows.Media.Imaging; // 處理圖片必須引用這個命名空間

namespace Dice_Game
{
    public partial class MainWindow : Window
    {
        // 宣告亂數產生器
        private Random rng = new Random();

        public MainWindow()
        {
            InitializeComponent();
            // 任務 A 的另一種做法：你也可以在這裡用程式碼設定初始圖片
            // 但我們已經在 XAML 裡設定 Source="/Images/1.png" 了，所以這裡留空即可
        }

        // 點擊擲骰子按鈕
        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {
            // 1. 產生 1 到 6 的隨機數
            int p1Score = rng.Next(1, 7);
            int p2Score = rng.Next(1, 7);

            // 2. 任務 B: 動態載入圖片
            // 運用字串插值 ($"...") 將隨機數字組合進路徑中
            // "pack://application:,,,/Images/檔案名" 是 WPF 讀取專案內資源的標準語法
            string p1ImagePath = $"pack://application:,,,/Images/{p1Score}.png";
            string p2ImagePath = $"pack://application:,,,/Images/{p2Score}.png";

            // 將路徑轉換為 Uri，並指派給 Image 控制項的 Source
            ImgPlayer1.Source = new BitmapImage(new Uri(p1ImagePath));
            ImgPlayer2.Source = new BitmapImage(new Uri(p2ImagePath));

            // 3. 任務 C: 勝負判定
            if (p1Score > p2Score)
            {
                TxtResult.Text = "player1 win";
            }
            else if (p1Score < p2Score)
            {
                TxtResult.Text = "player2 win";
            }
            else
            {
                TxtResult.Text = "Tie";
            }
        }
    }
}