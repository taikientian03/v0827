﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);
        int point = 100;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left=rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Width - label1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point--;
            label1.Left += vx;
            label1.Top += vy;

            // 2次元クラスPoint型の変数mpを宣言
            Point mp = MousePosition;

            // mpに、マウスのフォーム座標を取り出す。
            //// MousePositionにマウス座標のスクリーン左上からのX、Yが入っている。
            //// PointToClient()を使うと、スクリーン座標を、フォーム座標に変換できる。
            mp = PointToClient(mp);

            // ラベルに座標を表示
            //// 変換したフォーム座標は、mp.X、mp.Yで取り出せる。
            label2.Text = "" + mp.X + "," + mp.Y;

            if ((mp.X >= label1.Left)
                && (mp.X < label1.Right)
                && (mp.Y >= label1.Top)
                && (mp.Y < label1.Bottom)
                )
            {
                timer1.Enabled = false;
            }

        }
    }
}
