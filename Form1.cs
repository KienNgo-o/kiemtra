using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Xceed.Words.NET;
using GemBox.Document;
namespace DOAN_LAPTRINHMANG
{

    public partial class Form1 : Form
    {
        private const int LinesPerPage = 30;
        public Form1()
        {
            InitializeComponent();
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            // Chuyển sang chế độ Trial khi đạt giới hạn miễn phí
            ComponentInfo.FreeLimitReached += (sender, e) => e.FreeLimitReachedAction = FreeLimitReachedAction.ContinueAsTrial;

            nhap.KeyDown += new KeyEventHandler(nhap_KeyDown);
            nhap.KeyPress += new KeyPressEventHandler(nhap_KeyPress);
 
            // nhap.VScroll += new EventHandler(nhap_VScroll);
        }
        /*        private void nhap_VScroll(object sender, EventArgs e)
                {
                    UpdatePageNumber();
                }*/
        /*        private void UpdatePageNumber()
                {
                    int firstVisibleLine = nhap.GetLineFromCharIndex(nhap.GetCharIndexFromPosition(new Point(0, 0)));
                    int currentPage = (firstVisibleLine / LinesPerPage) + 1;
                    int totalPages = (nhap.Lines.Length / LinesPerPage) + 1;

                    lblPageNumber.Text = $"Page {currentPage} of {totalPages}";
                }*/
        private void button1_docfile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word Documents (*.docx)|*.docx";  // Lọc hiển thị file .docx
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    string extension = Path.GetExtension(fileName).ToLower();
                    if (extension == ".docx")
                    {
                        string rtfContent = ConvertDocxToRtf(fileName);
                        nhap.Rtf = rtfContent;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn file văn bản (.docx).");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn file để mở.");
                }
            }
        }

        private string ConvertDocxToRtf(string filePath)
        {
            var document = DocumentModel.Load(filePath);
            using (var stream = new MemoryStream())
            {
                document.Save(stream, SaveOptions.RtfDefault);
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        private void button_ghifile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document (*.docx)|*.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    SaveRichTextBoxContentToDocx(fileName);
                    MessageBox.Show("File đã được lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn tên tệp để lưu.");
                }
            }
        }

        private void SaveRichTextBoxContentToDocx(string filePath)
        {
            // Lấy nội dung RTF từ RichTextBox
            string rtfContent = nhap.Rtf;

            // Tạo một tài liệu mới
            var document = new DocumentModel();
            var section = new Section(document);
            document.Sections.Add(section);

            // Chèn nội dung RTF vào tài liệu
            var rtfLoadOptions = new RtfLoadOptions();
            var rtfDocument = DocumentModel.Load(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(rtfContent)), rtfLoadOptions);
            foreach (var element in rtfDocument.Sections[0].Blocks)
            {
                section.Blocks.Add(document.Import(element, true));
            }

            // Lưu tài liệu
            document.Save(filePath);
        }
        private void indam_click(object sender, EventArgs e)
        {
            if (nhap.SelectionLength > 0)
            {
                int selectionStart = nhap.SelectionStart;
                int selectionLength = nhap.SelectionLength;
                string selectedFont = comboBoxFont.SelectedItem.ToString();

                for (int i = 0; i < selectionLength; i++)
                {
                    nhap.Select(selectionStart + i, 1);
                    if (nhap.SelectionFont != null)
                    {
                        System.Drawing.Font currentFont = nhap.SelectionFont;
                        System.Drawing.FontStyle newFontStyle = nhap.SelectionFont.Style ^ System.Drawing.FontStyle.Bold;
                        nhap.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    }
                    nhap.Select(selectionStart, selectionLength);
                }
            }
        }
        private void innghieng_click(object sender, EventArgs e)
        {
            if (nhap.SelectionLength > 0)
            {
                int selectionStart = nhap.SelectionStart;
                int selectionLength = nhap.SelectionLength;
                string selectedFont = comboBoxFont.SelectedItem.ToString();

                for (int i = 0; i < selectionLength; i++)
                {
                    nhap.Select(selectionStart + i, 1);
                    if (nhap.SelectionFont != null)
                    {
                        System.Drawing.Font currentFont = nhap.SelectionFont;
                        System.Drawing.FontStyle newFontStyle = nhap.SelectionFont.Style ^ System.Drawing.FontStyle.Italic;
                        nhap.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    }
                    nhap.Select(selectionStart, selectionLength);
                }
            }
        }
        private void gachchan_click(object sender, EventArgs e)
        {
            if (nhap.SelectionLength > 0)
            {
                int selectionStart = nhap.SelectionStart;
                int selectionLength = nhap.SelectionLength;
                string selectedFont = comboBoxFont.SelectedItem.ToString();

                for (int i = 0; i < selectionLength; i++)
                {
                    nhap.Select(selectionStart + i, 1);
                    if (nhap.SelectionFont != null)
                    {
                        System.Drawing.Font currentFont = nhap.SelectionFont;
                        System.Drawing.FontStyle newFontStyle = nhap.SelectionFont.Style ^ System.Drawing.FontStyle.Underline;
                        nhap.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    }
                    nhap.Select(selectionStart, selectionLength);
                }
            }
        }
        private void gachbo_Click(object sender, EventArgs e)
        {
            if (nhap.SelectionLength > 0)
            {
                int selectionStart = nhap.SelectionStart;
                int selectionLength = nhap.SelectionLength;
                string selectedFont = comboBoxFont.SelectedItem.ToString();

                for (int i = 0; i < selectionLength; i++)
                {
                    nhap.Select(selectionStart + i, 1);
                    if (nhap.SelectionFont != null)
                    {
                        System.Drawing.Font currentFont = nhap.SelectionFont;
                        System.Drawing.FontStyle newFontStyle = nhap.SelectionFont.Style ^ System.Drawing.FontStyle.Strikeout;
                        nhap.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    }
                    nhap.Select(selectionStart, selectionLength);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Điền danh sách các kiểu chữ vào ComboBox
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name);
            }

            // Điền danh sách các cỡ chữ vào ComboBox (ví dụ từ 8 đến 72)
            for (int i = 8; i <= 72; i++)
            {
                comboBoxFontSize.Items.Add(i);
            }

            // Đặt giá trị mặc định cho ComboBox
            comboBoxFont.SelectedIndex = comboBoxFont.FindString("Arial");
            comboBoxFontSize.SelectedIndex = comboBoxFontSize.FindString("12");
        }
        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhap.SelectionLength > 0)
            {
                int selectionStart = nhap.SelectionStart;
                int selectionLength = nhap.SelectionLength;
                string selectedFont = comboBoxFont.SelectedItem.ToString();

                for (int i = 0; i < selectionLength; i++)
                {
                    nhap.Select(selectionStart + i, 1);
                    if (nhap.SelectionFont != null)
                    {
                        System.Drawing.Font currentFont = nhap.SelectionFont;
                        nhap.SelectionFont = new System.Drawing.Font(selectedFont, currentFont.Size, currentFont.Style);
                    }
                }

                nhap.Select(selectionStart, selectionLength);
            }
        }

        private void comboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhap.SelectionLength > 0)
            {
                int selectionStart = nhap.SelectionStart;
                int selectionLength = nhap.SelectionLength;
                string selectedFont = comboBoxFont.SelectedItem.ToString();

                for (int i = 0; i < selectionLength; i++)
                {
                    nhap.Select(selectionStart + i, 1);
                    if (nhap.SelectionFont != null)
                    {
                        System.Drawing.Font currentFont = nhap.SelectionFont;
                        float newSize = float.Parse(comboBoxFontSize.SelectedItem.ToString());
                        nhap.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, newSize, currentFont.Style);
                    }
                }
                nhap.Select(selectionStart, selectionLength);
            }

        }
        private void nhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                int selectionStart = nhap.SelectionStart;
                nhap.Text = nhap.Text.Insert(selectionStart, "\t");
                nhap.SelectionStart = selectionStart + 1;
            }
        }
        private void nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                int selectionStart = nhap.SelectionStart;
                if (selectionStart > 0 && nhap.Text[selectionStart - 1] == '-')
                {
                    e.Handled = true;
                    nhap.Text = nhap.Text.Insert(selectionStart-1, "  ");
                    nhap.Text = nhap.Text.Insert(selectionStart , "  ");
                    nhap.SelectionStart = selectionStart + 4;
                }
            }
        }
        private void kocan_click(object sender, EventArgs e)
        {
            nhap.Text= nhap.Text;
        }
        private void cangiua_click(object sender, EventArgs e)
        {
            nhap.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
        }

        private void cantrai_click(object sender, EventArgs e)
        {
            nhap.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void canphai_click(object sender, EventArgs e)
        {
            nhap.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;
        }

        private void highlight_click(object sender, EventArgs e)
        {
            if (nhap.SelectionLength > 0)
            {
                nhap.SelectionBackColor = System.Drawing.Color.Yellow; // Màu nền bạn muốn tô
            }
        }

        private void button_newfile_Click(object sender, EventArgs e)
        {

        }
    }
}


