using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Mindy服飾購物車
{
    public partial class Mindy服飾購物車 : Form
    {
        List<string> list衣服品項= new List<string> ();//key
        List<int> list衣服價格 = new List<int>();//value
        List<string> list衣服顏色 = new List<string>();//key
        List<string> list衣服尺寸 = new List<string>();//key
        int 數量 = 0;
        int 單價 = 0;
        int 品項總價 = 0;
        string 衣服品項 = "";
        string 衣服顏色 = "";
        string 衣服尺寸 = "";

        public Mindy服飾購物車()
        {
            InitializeComponent();
            this.Show();
        }
        private void Mindy服飾購物車_Load(object sender, EventArgs e)
        {
            list衣服品項.Add("削肩Bra背心");
            list衣服品項.Add("針織罩衫");
            list衣服品項.Add("綁帶蛋糕短洋");
            list衣服品項.Add("透膚襯衫");
            list衣服品項.Add("壓花一字領上衣");

            list衣服價格.Add(280);
            list衣服價格.Add(320);
            list衣服價格.Add(750);
            list衣服價格.Add(480);
            list衣服價格.Add(380);//key跟value會對應

            list衣服顏色.Add("紅");
            list衣服顏色.Add("黑");
            list衣服顏色.Add("淺藍");
            list衣服顏色.Add("淺灰");
            list衣服顏色.Add("可可");

            list衣服尺寸.Add("S");
            list衣服尺寸.Add("M");
            list衣服尺寸.Add("L");
            list衣服尺寸.Add("XL");
            list衣服尺寸.Add("XXL");

            for(int i=0; i< list衣服品項.Count; i++)
            {
                string strItem = string.Format("{0} {1}元", list衣服品項[i], list衣服價格[i]);
                listbox商品品項.Items.Add(strItem);
                //要把list飲料品項加進去要使用Item.Add
            }

            foreach(string str衣服顏色 in list衣服顏色) 
            {
                comboBox顏色.Items.Add(str衣服顏色);
            }

            foreach (string str衣服尺寸 in list衣服尺寸)
            {
                comboBox尺寸.Items.Add(str衣服尺寸);
            }

            //設定表單預設值(打開會先有預設選項)
            comboBox顏色.SelectedIndex = 0;//設為0會預設為第一個combox選項
            衣服顏色 = list衣服顏色[comboBox顏色.SelectedIndex];

            comboBox尺寸.SelectedIndex = 0;//設為0會預設為第一個combox選項
            衣服尺寸 = list衣服尺寸[comboBox尺寸.SelectedIndex];

            listbox商品品項.SelectedIndex = 0;
            衣服品項 = list衣服品項[listbox商品品項.SelectedIndex];

            數量 = 1;
            txt數量.Text = 數量.ToString();
        }
        

        private void txt杯數_TextChanged(object sender, EventArgs e)
        {
            if (txt數量.Text != "")
            {
                bool is輸入正確 = Int32.TryParse(txt數量.Text, out 數量);

                if ((is輸入正確 == false) || (數量 <= 0))
                {
                    MessageBox.Show("數量輸入錯誤，請重新輸入");
                    數量 = 1;
                    txt數量.Text = 數量.ToString();
                }
                輸出商品的總價();
            } 
                
        }

        private void comboBox顏色_SelectedIndexChanged(object sender, EventArgs e)
        {
            衣服顏色 = list衣服顏色[comboBox顏色.SelectedIndex];
        }

        private void comboBox尺寸_SelectedIndexChanged(object sender, EventArgs e)
        {
            衣服尺寸 = list衣服尺寸[comboBox尺寸.SelectedIndex];
        }

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt訂購人電話.Text) && IsNumeric(txt訂購人電話.Text) && !string.IsNullOrEmpty(txt訂購人姓名.Text))
            {
                if (listbox商品品項.SelectedIndex < 0)
                {
                    MessageBox.Show("請選擇商品品項");
                }
                else
                {
                    ArrayList 訂購單品資訊 = new ArrayList();
                    訂購單品資訊.Add(衣服品項);
                    訂購單品資訊.Add(數量);
                    訂購單品資訊.Add(單價);
                    訂購單品資訊.Add(品項總價);
                    訂購單品資訊.Add(衣服顏色);
                    訂購單品資訊.Add(衣服尺寸);

                    GlobalVar.訂購人姓名 = txt訂購人姓名.Text;
                    GlobalVar.訂購人電話 = txt訂購人電話.Text;
                    GlobalVar.list訂購品項資料集合.Add(訂購單品資訊);

                    MessageBox.Show("所選品項已加入購物車");
                }
            }
            else
            {
                MessageBox.Show("請輸入訂購人姓名或電話\n\n電話請輸入正確手機格式");
            }
        }
        private bool IsNumeric(string text)
        {
            return text.All(c => char.IsDigit(c));
        }

        void txt訂購人_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允許輸入的字元
            string allowedChars = "0123456789";

            // 檢查輸入的字元是否合法
            if (!allowedChars.Contains(e.KeyChar))
            {
                e.Handled = true; // 禁止輸入該字元
            }

            // 限制輸入字元的長度
            if (txt訂購人電話.Text.Length >= 10)
            {
                e.Handled = true; // 禁止輸入
            }
        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            FormOrderList MyFormOrderList = new FormOrderList();//先命名一個新的form宣告他為FormOrderList
            //MyFormOrderList.Show();將新的form顯示出來，但缺點為重複按click會跑出多個相同的form
            MyFormOrderList.ShowDialog();
            //此為獨佔開啟，用ShowDialog後除非關閉該視窗否則無法再原視窗做動作

        }

        void 輸出商品的總價()
        {
            if (listbox商品品項.SelectedIndex >= 0)
            {
                品項總價 = 單價 * 數量;
                lbl品項總價.Text = string.Format("{0}元", 品項總價);
            }
        }

        private void listbox飲料品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox商品品項.SelectedIndex >= 0)
            {
                衣服品項 = list衣服品項[listbox商品品項.SelectedIndex];
                單價 = list衣服價格[listbox商品品項.SelectedIndex];
                lbl單價.Text = string.Format("{0}元", 單價);
                輸出商品的總價();
            }
        }
    }
}
