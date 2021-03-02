using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;
using Excel = Microsoft.Office.Interop.Excel;

namespace AutoMatchPic
{
    public partial class AutoPic : Form
    {
        private Excel.Workbook _workbook;
        private Excel.Worksheet _worksheet;
        private readonly Dictionary<String, int> _dic;

        public AutoPic()
        {
            InitializeComponent();
            _dic = new Dictionary<string, int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filepath = GetFilePath();
            if (string.IsNullOrWhiteSpace(filepath))
            {
                return;
            }
            tb_filePath.Text = filepath;
            var application = new Excel.Application();
            _workbook = application.Workbooks.Open(filepath);
            _worksheet = _workbook.Sheets[1];
            //GetTitle();
        }
        private string GetFilePath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.Description = "请选择图片所在文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    return;
                }
                tb_picFolder.Text = dialog.SelectedPath;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_filePath.Text))
            {
                MessageBox.Show("选择文件");
                return;
            }
            if (cb_colPicName.SelectedItem == null)
            {
                return;
            }
            var itemCob = cb_colPicName.SelectedItem.ToString();
            var curline = 2;
            try
            {
                while (true)
                {
                    var range = $"{itemCob}{curline}";
                    var r0 = (Excel.Range)_worksheet.Range[range];
                    if (r0.Value2 == null || string.IsNullOrWhiteSpace(r0.Value2.ToString()))
                    {
                        break;
                    }
                    _dic.Add(r0.Value2.ToUpper(), curline);
                    curline++;
                }
            }
            finally { _workbook.Close(); }
        }
        private string GetSaveFilePath()
        {
            SaveFileDialog saveFileDig = new SaveFileDialog();
            saveFileDig.Filter = "Excel Office97-2003(*.xls)|.xls|Excel Office2007及以上(*.xlsx)|*.xlsx";
            saveFileDig.FilterIndex = 0;
            saveFileDig.OverwritePrompt = true;
            saveFileDig.InitialDirectory = Environment.GetFolderPath(SpecialFolder.Desktop);
            string filePath = null;
            if (saveFileDig.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDig.FileName;
            }

            return filePath;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (cb_colPicName.SelectedItem == null)
            {
                MessageBox.Show("选择名称列");
                return;
            }
            if (cb_picAddCol.SelectedItem == null)
            {
                MessageBox.Show("选择插入图片列");
                return;
            }
            if (tb_picFolder.Text == null || string.IsNullOrWhiteSpace(tb_picFolder.Text))
            {
                MessageBox.Show("选择图片路径");
                return;
            }
            PictureToExcel ipt = new PictureToExcel();
            ipt.Open(tb_filePath.Text);
            var folder = tb_picFolder.Text;
            var str = "{0}\\{1}";
            var range = cb_picAddCol.SelectedItem.ToString();
            foreach (var item in _dic)
            {
                var picStr = string.Format(str, folder, item.Key);
                ipt.InsertPicture($"{range}{item.Value}", picStr, 80, 100);
                ipt.CellHeigh($"{range}{item.Value}", 50, 100);
            }
            var filepath = GetSaveFilePath();
            if (string.IsNullOrWhiteSpace(filepath))
            {
                return;
            }
            ipt.SaveFile(filepath);
            ipt.Dispose();

        }
        //private void GetTitle()
        //{
        //    _worksheet.
        //    comboBox1.DisplayMember = "Key";
        //    comboBox1.ValueMember = "Value";
        //    var rowHead = _worksheet.Rows[1];  //读取当前行数据
        //    //while (rowHead.)
        //    //{
        //    //    ICell cell = rowHead.GetCell(k);  //当前表格
        //    //    if (cell != null)
        //    //    {
        //    //        comboBox1.Items.Add(new ComboItem(cell.StringCellValue, cell.Address.ToString(), k));
        //    //    }
        //    //}
        //    comboBox1.SelectedIndex = 0;
        //}
    }
}
