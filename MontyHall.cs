using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MontyHall
{
    public partial class MontyHall : Form
    {
        // フィールド
        #region Field

        private int winningDoor; // 当たりのドアの番号
        private int selectedDoor; // 選択したドアの番号
        private int openedDoor; // ホストに開かれたハズレのドアの番号
        private int changedDoor; // 変更されたドアの番号
        Random doorChoice = new Random(); // 乱数変数

        #endregion
        // コンストラクタ
        #region Construct
        public MontyHall()
        {
            InitializeComponent();
            winningDoor = doorChoice.Next(1, 4);
        }
        #endregion

        // メソッド
        #region Methods
        private void Form1_Load(object sender, EventArgs e)
        {
            Changing.Visible = false;
            Reset.Visible = false;
        }
        
        //ドアを最初に選ぶ処理
        private void Door_Clicked(object sender, EventArgs e)
        {
            Button clickedDoor = (Button)sender;
            selectedDoor = int.Parse(clickedDoor.Name.Replace("Door", "")); // 選択されたドアの番号を格納する

            clickedDoor.Enabled = false; // 最初に選んだボタンが分かるように二度押せないようにする

            //ホストがハズレのドアを開ける
            OpenGoatDoor();

            //ドアの変更の意向を確認
            Result.Text = "Change the door?";
            Changing.Visible = true;
            
        }

        //選択したドアと当たりのドアではないドアを開く処理
        private void OpenGoatDoor()
        {
            // ジェネリックコレクションを利用
            // 三つのドアをリストに格納して、選択されたドアと当たりのドアを除外する
            // RemoveメソッドはStringクラスのではなく、List＜T＞クラスのメソッド
            List<int> remainingDoor = new List<int> { 1, 2, 3 };
            remainingDoor.Remove(winningDoor);
            remainingDoor.Remove(selectedDoor);

            // 残ったドア（リストの一つ目の要素）を代入
            openedDoor = remainingDoor[0];

            if (openedDoor == 1)
            {
                DoorResult1.Text = "Goat!";
            }
            else if (openedDoor == 2)
            {
                DoorResult2.Text = "Goat!";
            }
            else if (openedDoor == 3)
            {
                DoorResult3.Text = "Goat!";
            }
        }

        // ドアを変更する処理
        private void Changing_Click(object sender, EventArgs e)
        {
            List<int> ChangedDoor = new List<int> { 1, 2, 3 };
            ChangedDoor.Remove(selectedDoor);
            ChangedDoor.Remove(openedDoor);

            changedDoor = ChangedDoor[0];
            FinalDoor_Clicked(changedDoor);
        }

        // 最終的にドアを選択する処理
        private void FinalDoor_Clicked(int changedDoor)
        {
            if (changedDoor == winningDoor)
            {
                Result.Text = "You are Winner!";
                Title.Text = "Congratulation!!";
            }
            else
            {
                Result.Text = "You are Loser!";
                Title.Text = "Don't Mind!!";
            }
            Reset.Visible = true;

        }

        // Resetボタンで初期状態に戻る処理
        private void Reset_Click(object sender, EventArgs e)
        {
            // 全てを初期化
            winningDoor = doorChoice.Next(1, 4);
            selectedDoor = 0;
            changedDoor = 0;
            openedDoor = 0;

            Title.Text = "Try again MontyHall!!";
            Result.Text = "";

            Door1.Enabled = true;
            Door2.Enabled = true;
            Door3.Enabled = true;
            Reset.Visible= false;
            Changing.Visible = false;
            DoorResult1.Text = "";
            DoorResult2.Text = "";
            DoorResult3.Text = "";
        }


        #endregion
    }
}
