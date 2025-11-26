using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「取得國家」按鈕時，會隨機排列南美洲的國家並顯示在 countriesListBox 中。
        // 實作要點：
        // - 使用繁體中文的國家名稱陣列。
        // - 使用 Fisher–Yates 演算法亂數洗牌以產生隨機順序。
        // - 清除現有項目並加入新的隨機順序項目。
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 南美洲國家（使用繁體中文名稱）。可視需求增減或改成從外部資源讀取。
            var countries = new List<string>
            {
                "阿根廷",
                "玻利維亞",
                "巴西",
                "智利",
                "哥倫比亞",
                "厄瓜多",
                "圭亞那",
                "巴拉圭",
                "秘魯",
                "蘇里南",
                "烏拉圭",
                "委內瑞拉",
                "法屬圭亞那"
            };

            // 使用隨機數與 Fisher–Yates 演算法來洗牌。
            var rng = new Random();
            for (int i = countries.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                var tmp = countries[i];
                countries[i] = countries[j];
                countries[j] = tmp;
            }

            // 將 ListBox 清空並加入洗牌後的國家列表。
            countriesListBox.BeginUpdate();
            countriesListBox.Items.Clear();
            foreach (var country in countries)
            {
                countriesListBox.Items.Add(country);
            }
            countriesListBox.EndUpdate();

            // 若希望自動選取第一項可以啟用下列程式碼：
            if (countriesListBox.Items.Count > 0)
            {
                countriesListBox.SelectedIndex = 0;
            }
        }

        // 離開按鈕的點擊事件處理程式：關閉目前表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}