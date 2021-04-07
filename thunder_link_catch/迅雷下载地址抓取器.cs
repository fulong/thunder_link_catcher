using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Filters;
using Winista.Text.HtmlParser.Util;

namespace thunder_link_catch
{
    public partial class 迅雷下载地址抓取器 : Form
    {
        public 迅雷下载地址抓取器()
        {
            InitializeComponent();
        }
        public void html_parse(string html)
        {
            Parser parser = Parser.CreateParser(html, "utf-8");
            //筛选要查找的对象 这里查找td，封装成过滤器
            NodeFilter filter = new TagNameFilter("a");
            //将过滤器导入筛选，得到对象列表
            NodeList nodes = parser.Parse(filter);
            //遍历对象列表，进行取值
            global_list.Items.Clear();
            for (int i = 0,j; i < nodes.Size(); i++)
            {
                INode textnode = nodes[i];
                ITag tag = (ITag)textnode;
                String href = tag.GetAttribute("href");
                if (href == null)
                {
                    continue;
                }
                for(j = 0;j< global_list.Items.Count; j++)
                {
                    if(global_list.Items[j].SubItems[2].Text.Contains(href))
                    {
                        break;
                    }
                }
                if((href.Contains("thunder://") || href.Contains("magnet:?xt=") ||  href.Contains("ftp://") || href.Contains("ed2k://")) && j >= global_list.Items.Count)
                {
                    String plain_text_value = textnode.ToPlainTextString();
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(plain_text_value);
                    item.SubItems.Add(href);
                    global_list.BeginUpdate();
                    global_list.Items.Add(item);
                    global_list.EndUpdate();
                }
            }        
        }

        private void url_sure_Click(object sender, EventArgs e)
        {
            string html = Program.http_request(url.Text);
            html_parse(html);
        }
        private static ITag getTag(INode node)
        {
            if (node == null)
                return null;
            return node is ITag ? node as ITag : null;
}

        private void all_select_Click(object sender, EventArgs e)
        {
            int check_counter = 0;
            for (int j = 0; j < global_list.Items.Count; j++)
            {
                if (global_list.Items[j].Checked)
                {
                    check_counter++;
                }
            }
            if (check_counter >= global_list.Items.Count)
            {
                for (int j = 0; j < global_list.Items.Count; j++)
                {
                    global_list.Items[j].Checked = false;
                }
            }
            else
            {
                for (int j = 0; j < global_list.Items.Count; j++)
                {
                    global_list.Items[j].Checked = true;
                }
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            //复制到黏贴板
            string download_url = "";
            for(int j = 0;j< global_list.Items.Count; j++)
           {
                if(global_list.Items[j].Checked)
                {
                    download_url += "\r\n" + global_list.Items[j].SubItems[2].Text;
                }
           }
           Clipboard.SetDataObject(download_url);
            MessageBox.Show("已复制到剪贴板!");
        }

        private void only_select_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string select_str = "";
            switch(btn.Name)
            {
                case "only_magnet_select":
                    select_str = "magnet:?xt=";
                    break;
                case "only_thunder_select":
                    select_str = "thunder://";
                    break;
                case "only_ftp_select":
                    select_str = "ftp://";
                    break;
                case "only_ed2k_select":
                    select_str = "ed2k://";
                    break;
                default:
                    break;
            }
            List<int> index = new List<int>();
            int counter = 0;
            for(int j = 0;j< global_list.Items.Count; j++)
           {
                if(global_list.Items[j].SubItems[2].Text.Contains(select_str))
                {
                    index.Add(j);
                }else
                {
                    if(global_list.Items[j].Checked )
                    {
                        counter++;
                    }
                    global_list.Items[j].Checked = false;
                }
           }
            if(counter > 0)
            {
                for (int j = 0; j < index.Count; j++)
                {
                    global_list.Items[index[j]].Checked = true;
                }
            }else
            {
                for (int j = 0; j < index.Count; j++)
                {
                    global_list.Items[index[j]].Checked = !global_list.Items[index[j]].Checked;
                }
            }
        }

        private void html_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog=new OpenFileDialog();
            openFileDialog.Filter="html文件|*.html";
            openFileDialog.RestoreDirectory=true;
            openFileDialog.FilterIndex=1;
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string html;
                string fName=openFileDialog.FileName;
                html = File.ReadAllText(fName);
                html_parse(html);
            }
        }
    }
}
