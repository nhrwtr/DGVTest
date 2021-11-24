using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGVTest
{
    /// <summary>
    /// フォーム描画を抑制するクラスです
    /// </summary>
    internal class FormDrawingSuppression : IDisposable
    {
        // <参考> WinForms向け、(安全に)画面描画を抑制するためのサンプル - Qiita https://qiita.com/otagaisama-1/items/9e776469f93a3697d55e

        /// <summary>
        /// ネイティブコードを実行するクラスです
        /// </summary>
        private static class NativeMethods
        {
            // https://docs.microsoft.com/ja-jp/visualstudio/code-quality/ca1060-move-p-invokes-to-nativemethods-class
            
            /// <summary>
            /// 再描画メッセージコード
            /// </summary>
            internal const UInt32 WM_SETREDRAW = 11;

            /// <summary>
            /// メッセージをウィンドウに送信する
            /// </summary>
            /// <param name="hWnd">フォームのハンドル</param>
            /// <param name="dwMsg">メッセージ</param>
            /// <param name="wParam">パラメーター</param>
            /// <param name="lParam">このパラメーターは使用されません。</param>
            /// <returns>処理結果</returns>
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 dwMsg, IntPtr wParam, IntPtr lParam);
        }

        /// <summary>
        /// 描画抑制するフォーム
        /// </summary>
        private readonly Form _form;
        /// <summary>
        /// 破棄フラグ。trueで破棄済
        /// </summary>
        private bool disposedValue;

        /// <summary>
        /// オブジェクト生成し画面描画を抑制します。オブジェクトが破棄されると描画の抑制状態が解除されます。using句が使用可能です。
        /// </summary>
        /// <param name="form">抑制するフォーム</param>
        public FormDrawingSuppression(Form form)
        {
            _form = form;
            SendSetRedrawMessage(false);
        }

        /// <summary>
        /// 再描画メッセージ（WM_SETREDRAW）をコールする
        /// </summary>
        /// <param name="enableRedraw">trueの場合：描画開始，falseの場合：描画停止</param>
        private void SendSetRedrawMessage(bool enableRedraw)
        {
            NativeMethods.SendMessage(_form.Handle, NativeMethods.WM_SETREDRAW, enableRedraw ? new IntPtr(1) : IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 画面描画抑制を解除して、オブジェクトを破棄します。
        /// </summary>
        /// <param name="disposing">オブジェクトを破棄する場合はtrueを指定します。</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    SendSetRedrawMessage(true);
                    _form.Refresh();
                }

                disposedValue = true;
            }
        }

        /// <summary>
        /// 画面描画抑制を解除して、オブジェクトを破棄します。
        /// </summary>
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを 'Dispose(bool disposing)' メソッドに記述します
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
