using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DGVTest
{
    /// <summary>
    /// <see cref="DataGridView"/>の拡張クラス
    /// </summary>
    public static class DataGridViewExtension
    {
        /// <summary>
        /// 反復可能な列挙子を返します。
        /// </summary>
        /// <param name="collection"><see cref="DataGridView"/>の行コレクション</param>
        /// <returns><see cref="DataGridViewRow"/>の反復列挙子</returns>
        public static IEnumerable<DataGridViewRow> ToDGVRows(this DataGridViewRowCollection collection)
        {
            return collection.OfType<DataGridViewRow>();
        }

        /// <summary>
        /// 反復可能な列挙子を返します。
        /// </summary>
        /// <param name="collection"><see cref="DataGridView"/>が選択した行のコレクション</param>
        /// <returns><see cref="DataGridViewRow"/>の反復列挙子</returns>
        public static IEnumerable<DataGridViewRow> ToDGVRows(this DataGridViewSelectedRowCollection collection)
        {
            return collection.OfType<DataGridViewRow>();
        }
    }
}
