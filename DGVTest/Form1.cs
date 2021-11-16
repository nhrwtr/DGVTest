using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DGVTest
{
    public partial class Form1 : Form
    {
        private BindingList<UserColumn> _userLists = new BindingList<UserColumn>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開始イベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateData(_userLists);

            userColumnBindingSource.DataSource = _userLists;
            UserListDataGridView.DataSource = userColumnBindingSource;
            UserListDataGridView.Refresh();
            UserListDataGridView.ClearSelection();
        }

        /// <summary>
        /// 更新ボタンを押した時のイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void ReflashButton_Click(object sender, EventArgs e)
        {
            CreateData(_userLists);
        }

        /// <summary>
        /// リセット（DGVを作り直す）ボタンを押した時のイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            UserListDataGridView.DataSource = null;

            _userLists = new BindingList<UserColumn>();
            CreateData(_userLists);
            userColumnBindingSource.DataSource = _userLists;
            UserListDataGridView.DataSource = userColumnBindingSource;
            UserListDataGridView.Refresh();
            UserListDataGridView.ClearSelection();
        }

        /// <summary>
        /// 選択箇所とスクロール位置を保持しつつ更新するボタンを押した時のイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void ReflashButton2_Click(object sender, EventArgs e)
        {
            // 選択位置とスクロール位置を保存する
            var selrow = UserListDataGridView.SelectedRows.ToDGVRows().FirstOrDefault();
            int ind = selrow?.Index ?? 0;
            var scrollPoint = UserListDataGridView.FirstDisplayedScrollingRowIndex;

            CreateData(_userLists);

            // 選択位置とスクロール位置を設定する
            UserListDataGridView.ClearSelection();
            UserListDataGridView.Rows[ind].Selected = true;
            UserListDataGridView.FirstDisplayedScrollingRowIndex = scrollPoint;
        }

        /// <summary>
        /// 選択箇所とスクロール位置を保持しつつリセット（DGVを作り直す）するボタンを押した時のイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void ResetButton2_Click(object sender, EventArgs e)
        {
            // 選択位置とスクロール位置を保存する
            var selrow = UserListDataGridView.SelectedRows.ToDGVRows().FirstOrDefault();
            int ind = selrow?.Index ?? 0;
            var scrollPoint = UserListDataGridView.FirstDisplayedScrollingRowIndex;

            UserListDataGridView.DataSource = null;
            _userLists = new BindingList<UserColumn>();
            CreateData(_userLists);
            userColumnBindingSource.DataSource = _userLists;
            UserListDataGridView.DataSource = userColumnBindingSource;
            UserListDataGridView.Refresh();

            // 選択位置とスクロール位置を設定する
            UserListDataGridView.ClearSelection();
            UserListDataGridView.Rows[ind].Selected = true;
            UserListDataGridView.FirstDisplayedScrollingRowIndex = scrollPoint;
        }

        /// <summary>
        /// データ生成
        /// </summary>
        /// <param name="list">バインディングリスト</param>
        private void CreateData(BindingList<UserColumn> list)
        {
            list.Clear();
            for (var i = 0; i < 2000; i++)
            {
                list.Add(new UserColumn { Id = i.ToString(), Name = "Name" + (i + 1), Note = "Note" + i });
            }
        }
    }
}
