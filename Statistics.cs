using System;
using System.Windows.Forms;

namespace MontyHall
{
    public partial class Statistics : Form
    {
        // フィールド
        #region Field
        private int winningCount;
        private int totalCount;
        private double winningRatio;

        #endregion
        // コンストラクタ
        #region Constructa
        public Statistics(int totalCount, int winningCount)
        {
            InitializeComponent();
            this.winningCount = 0;
            totalCount = 0;
            winningRatio = winningCount / totalCount * 100;
        }
        #endregion

        // メソッド
        #region Methods
        private void Statistics_Load(object sender, EventArgs e){}
        #endregion
        // ラベルのデータを更新する処理
        private void Update_Statistics(int winningCount, int totalCount)
        {
            GameCount.Text = totalCount.ToString();
            WinCount.Text = winningCount.ToString();
            WinRatio.Text = winningRatio.ToString("P2");
        }
    }
}
