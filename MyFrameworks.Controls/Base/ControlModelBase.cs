using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFrameworks.Controls.Base
{
    /// <summary>
    /// コントロール用 ViewModel のベースクラス
    /// </summary>
    public abstract class ControlModelBase
    {
        /// <summary>
        /// 本コントロールモデルのバインディングコレクションを構築する処理
        /// </summary>
        public Action<ControlBindingsCollection, object> BuildBindings { get; set; }

        /// <summary>
        /// データソース
        /// </summary>
        public object DataSource
        {
            get { return bsource.DataSource; }
            set { bsource.DataSource = value; }
        }

        private Control ctrl;
        private BindingSource bsource;

        // -------------------------------------------------------------------
        #region 抽象メソッド

        /// <summary>
        /// デフォルトのバインディングコレクション構築方法を定義
        /// </summary>
        /// <param name="bindings">制御中のコントロールの DataBindings</param>
        /// <param name="source">本モデルに指定した DataSource</param>
        public abstract void OnBuildBindingsDefault(ControlBindingsCollection bindings, object source);

        #endregion 抽象メソッド

        // -------------------------------------------------------------------
        #region イベントハンドラ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ctrl"></param>
        public ControlModelBase(Control _ctrl)
        {
            InitializeBase(_ctrl);
        }

        /// <summary>
        /// データソース変更時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bsource_DataSourceChanged(object sender, EventArgs e)
        {
            Bind();
        }

        #endregion イベントハンドラ

        // -------------------------------------------------------------------

        /// <summary>
        /// 本クラスの初期化
        /// </summary>
        /// <param name="_ctrl"></param>
        private void InitializeBase(Control _ctrl)
        {
            _ctrl.SuspendLayout();

            // プロパティ
            this.BuildBindings = OnBuildBindingsDefault;

            // フィールド
            this.ctrl = _ctrl;
            this.bsource = new BindingSource();

            // イベント
            bsource.DataSourceChanged += bsource_DataSourceChanged;

            _ctrl.ResumeLayout();
        }

        /// <summary>
        /// コントロールへのデータバインド
        /// </summary>
        private void Bind()
        {
            // ソースなし ⇒ ガード
            if (bsource.DataSource == null) return;

            ((ISupportInitialize)(bsource)).BeginInit();
            BuildBindings(ctrl.DataBindings, bsource.DataSource);
            ((ISupportInitialize)(bsource)).EndInit();
        }
    }
}
