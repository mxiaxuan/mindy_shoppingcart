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
    public partial class FormOrderList : Form
    {
        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            lbl訂購人性名.Text = GlobalVar.訂購人姓名;
            lbl訂購人電話.Text = GlobalVar.訂購人電話;
            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項資料集合)
            {
                string 品項名稱 = (string)訂購單品[0];
                int 數量 = (int)訂購單品[1];
                int 單價 = (int)訂購單品[2];
                int 品項總價 = (int)訂購單品[3];
                string 衣服顏色 = (string)訂購單品[4];
                string 衣服尺寸 = (string)訂購單品[5];

                string strInfo = string.Format("{0} {1}件 {2}元 品項總價:{3}元 顏色:{4} 尺寸:{5}", 品項名稱, 數量, 單價, 品項總價, 衣服顏色, 衣服尺寸);

                listBox訂購品項列表.Items.Add(strInfo);
            }

            計算訂單總價();
            

        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購品項列表.SelectedIndex >= 0)
            {
                int selindex = listBox訂購品項列表.SelectedIndex;
                GlobalVar.list訂購品項資料集合.RemoveAt(selindex);
                listBox訂購品項列表.Items.RemoveAt(selindex );
                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選取要刪除的品項");
            }
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            listBox訂購品項列表.Items.Clear();
            GlobalVar.list訂購品項資料集合.Clear();
            listBox訂購品項列表.Items.Clear();
            計算訂單總價();
            
        }

        private void btn輸出訂購單資料_Click(object sender, EventArgs e)
        {
            string str檔案目錄 = @"C:\Users\User\Desktop\Mindy服飾購物車";
            Random myRnd = new Random();
            int rndNum = myRnd.Next(10000, 100000);
            string str檔名 = DateTime.Now.ToString("yyyyMMddttHHmmss") + rndNum + "訂購單.txt";
            //yyyy西元年四位數/MM月份兩位數/dd日期兩位數 dddd星期 HH 24小時制 mm 分鐘 ss秒數
            string str完整檔案路徑 = str檔案目錄 + @"\" + str檔名;

            Console.WriteLine(str完整檔案路徑);
            //輸出檔名格式

            SaveFileDialog sfd = new SaveFileDialog();//叫出儲存對話框
            sfd.InitialDirectory = str檔案目錄;
            sfd.FileName = str檔名;
            sfd.Filter = "文字檔|*.txt";//檔案過濾器，除了txt檔其他都過濾掉
            //存檔格式

            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;
            } else
            {
                return;//結束方法
            }

            //訂單內容輸出
            try { 
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("***********Mindy服飾購物車***********");
            list訂單資訊.Add("----------------------------------");
            list訂單資訊.Add($"訂購時間{DateTime.Now}");
            list訂單資訊.Add($"訂購人姓名{GlobalVar.訂購人姓名}");
            list訂單資訊.Add($"訂購人電話{GlobalVar.訂購人電話}");
            list訂單資訊.Add("**************訂購品項**************");
            foreach(ArrayList 訂購單品 in GlobalVar.list訂購品項資料集合)
            {
                string 品項名稱 = (string)訂購單品[0];
                int 數量 = (int)訂購單品[1];
                int 單價 = (int)訂購單品[2];
                int 品項總價 = (int)訂購單品[3];
                string 衣服顏色 = (string)訂購單品[4];
                string 衣服尺寸 = (string)訂購單品[5];

                string strInfo = string.Format("{0} {1}件 {2}元 品項總價:{3}元 顏色:{4} 尺寸:{5}", 品項名稱, 數量, 單價, 品項總價, 衣服顏色, 衣服尺寸);

                list訂單資訊.Add(strInfo);
            }
            list訂單資訊.Add("===================================");
            list訂單資訊.Add("-----------------------------------");
            list訂單資訊.Add($"{lbl訂單總價.Text}");
            list訂單資訊.Add("===================================");
            list訂單資訊.Add("**************謝謝光臨**************");

            System.IO.File.WriteAllLines(str完整檔案路徑,list訂單資訊, Encoding.UTF8);
                //指定輸出檔案的編碼方式
            }
            catch(Exception error) 
            {
                MessageBox.Show($"{error},訂單輸出失敗");
            }
            MessageBox.Show("訂單輸出成功");
        }

        private void btn繼續選購_Click(object sender, EventArgs e)
        {
            Close();
            //關閉form
        }

        void 計算訂單總價()
        {
            int 訂單總價 = 0;

            foreach(ArrayList 訂購單品 in GlobalVar.list訂購品項資料集合)
            {
                int 品項總價 = (int)訂購單品[3];

                訂單總價 += 品項總價;
            }
            lbl訂單總價.Text = string.Format("訂單總價: {0} 元", 訂單總價);
        }

        private void FormOrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要關閉表單?","關閉表單確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (R == DialogResult.Yes)
            {
                e.Cancel = false;
                //如果要關閉表單，那取消事件就會變成false
            }
            else
            {
                e.Cancel = true;
                //如果要關閉表單，那取消事件就會變成true
            }
        }
    }
}
