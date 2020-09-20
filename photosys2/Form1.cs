using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace photosys2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            if (System.IO.Directory.Exists(tbxPath.Text))
            {
                dlg.SelectedPath = tbxPath.Text;
            }
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbxPath.Text = dlg.SelectedPath;
                refreshFiles(tbxPath.Text);
            }
        }

        private void tbxPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                refreshFiles(tbxPath.Text);
            }
        }

        void refreshFiles(string path)
        {
            splitContainer1.Enabled = false;
            try
            {
                lvwFiles.Items.Clear();
                pbxImage.Image = null;
                if (System.IO.Directory.Exists(path))
                {
                    var dir = new DirectoryInfo(path);
                    path = dir.FullName;
                    var files = System.IO.Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    var trimStart = path.Length;
                    int c = 0;
                    double filesSize = 0;
                    lvwFiles.Items.AddRange(
                        files.Select(file =>
                        {
                            var lvi = new System.Windows.Forms.ListViewItem();
                            lvi.Text = file.Substring(trimStart + 1);
                            lvi.Tag = file;
                            DateTime? dt;
                            string dtSrc;
                            getExifDate(file, out dt, out dtSrc);
                            var fdt = File.GetLastWriteTime(file);
                            if (dt.HasValue)
                            {
                                TimeSpan ts;
                                if (fdt > dt.Value)
                                {
                                    ts = fdt - dt.Value;
                                }
                                else
                                {
                                    ts = dt.Value - fdt;
                                }
                                if (ts > TimeSpan.FromSeconds(1))
                                {
                                    lvi.UseItemStyleForSubItems = false;
                                    lvi.SubItems.Add(fdt.ToString("yyyy-MM-dd HH:mm:ss"), System.Drawing.Color.Red, lvi.BackColor, lvi.Font).Tag = fdt;
                                }
                                else if (ts > TimeSpan.Zero)
                                {
                                    lvi.UseItemStyleForSubItems = false;
                                    lvi.SubItems.Add(fdt.ToString("yyyy-MM-dd HH:mm:ss"), System.Drawing.Color.Green, lvi.BackColor, lvi.Font).Tag = fdt;
                                }
                                else
                                {
                                    lvi.SubItems.Add(fdt.ToString("yyyy-MM-dd HH:mm:ss")).Tag = fdt;
                                }
                            }
                            else
                            {
                                lvi.SubItems.Add(fdt.ToString("yyyy-MM-dd HH:mm:ss")).Tag = fdt;
                            }
                            if (dt != null)
                                lvi.SubItems.Add(dt.Value.ToString("yyyy-MM-dd HH:mm:ss")).Tag = dt;
                            else
                                lvi.SubItems.Add("");
                            lvi.SubItems.Add(dtSrc);
                            var fi = new FileInfo(file);
                            filesSize += fi.Length / 1024.0;
                            lvi.SubItems.Add($"{fi.Length / 1024.0:N2}").Tag = fi.Length;
                            c++;
                            toolStripStatusLabel1.Text = $"{c}/{files.Length} = {c * 100 / files.Length}%";
                            Application.DoEvents();
                            return lvi;
                        }).ToArray()
                    );
                    var unit = "K";
                    if (filesSize > 1024)
                    {
                        filesSize /= 1024;
                        unit = "M";
                    }
                    if (filesSize > 1024)
                    {
                        filesSize /= 1024;
                        unit = "G";
                    }
                    toolStripStatusLabel1.Text += $" = {filesSize:N2} {unit}B";
                    lvwFiles.Columns[4].TextAlign = HorizontalAlignment.Right;
                    lvwFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    MessageBox.Show("Directory not exists");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                splitContainer1.Enabled = true;
            }
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        private const int SW_SHOW = 5;
        private const uint SEE_MASK_INVOKEIDLIST = 12;
        public static bool ShowFileProperties(string Filename)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = Filename;
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            return ShellExecuteEx(ref info);
        }

        private void lvwFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            if (lvwFiles.SelectedItems.Count == 1)
            {
                try
                {
                    pbxImage.Load(lvwFiles.SelectedItems[0].Tag as string);
                    pbxImage.Visible = true;
                    wpf.Visible = false;
                    (wpf.Child as MediaElement).Source = null;
                    //var date = getImageDate(pbxImage.Image);
                    //toolStripStatusLabel1.Text = $"OK Date:{date}";
                }
                catch (Exception err)
                {
                    toolStripStatusLabel1.Text = err.Message;
                    pbxImage.Image = null;

                    try
                    {
                        var me = wpf.Child as MediaElement;
                        me.Source = new Uri(lvwFiles.SelectedItems[0].Tag as string);
                        wpf.Visible = true;
                        pbxImage.Visible = false;
                        pbxImage.Image = null;
                        toolStripStatusLabel1.Text = "";
                        //me.Play();
                        //toolStripStatusLabel1.Text = $"OK Date:?";
                    }
                    catch (Exception err2)
                    {
                        toolStripStatusLabel1.Text += " " + err2.Message;
                        var me = wpf.Child as MediaElement;
                        me.Source = null;
                    }
                }

                DateTime? dt;
                string dtSrc;
                getExifDate(lvwFiles.SelectedItems[0].Tag as string, out dt, out dtSrc);
                if (dt != null)
                    toolStripStatusLabel1.Text += $" Date: {dt} {dtSrc}";

                toolStripStatusLabel1.Text += $" {((long)lvwFiles.SelectedItems[0].SubItems[4].Tag):N0} Bytes";
                toolStripStatusLabel1.Text = toolStripStatusLabel1.Text.Trim();
            }
            else
            {
                pbxImage.Image = null;
                (wpf.Child as MediaElement).Source = null;
                toolStripStatusLabel1.Text = $"Selected {lvwFiles.SelectedItems.Count}/{lvwFiles.Items.Count}";
            }
        }

        private void getExifDate(string file, out DateTime? dt, out string dtSrc)
        {
            dt = null;
            dtSrc = "";
            try
            {
                var directories = ImageMetadataReader.ReadMetadata(file);
                DateTime d;
                var dirs = directories.Where(x => x.Name == "Exif SubIFD");
                if (dt == null)
                    foreach (var dir in dirs)
                    {
                        try
                        {
                            if (dir != null && dir.ContainsTag(ExifDirectoryBase.TagDateTimeOriginal) && dir.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out d))
                            {
                                dt = d;
                                dtSrc = "EXIF Original";
                                break;
                            }
                            else if (dir != null && dir.ContainsTag(ExifDirectoryBase.TagDateTime) && dir.TryGetDateTime(ExifDirectoryBase.TagDateTime, out d))
                            {
                                dt = d;
                                dtSrc = "EXIF";
                            }

                        }
                        catch { }
                    }
                if (dt == null)
                {
                    dirs = directories.Where(x => x.Name == "Exif IFD0");
                    foreach (var dir in dirs)
                    {
                        try
                        {
                            if (dir != null && dir.ContainsTag(ExifDirectoryBase.TagDateTimeOriginal) && dir.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out d))
                            {
                                dt = d;
                                dtSrc = "EXIF Original";
                                break;
                            }
                            else if (dir != null && dir.ContainsTag(ExifDirectoryBase.TagDateTime) && dir.TryGetDateTime(ExifDirectoryBase.TagDateTime, out d))
                            {
                                dt = d;
                                dtSrc = "EXIF";
                            }
                        }
                        catch { }
                    }
                }
                if (dt == null)
                {
                    dirs = directories.Where(x => x.Name == "File");
                    foreach (var dir in dirs)
                    {
                        try
                        {
                            if (dir.ContainsTag(MetadataExtractor.Formats.FileSystem.FileMetadataDirectory.TagFileModifiedDate) && dir.TryGetDateTime(MetadataExtractor.Formats.FileSystem.FileMetadataDirectory.TagFileModifiedDate, out d))
                            {
                                dt = d;
                                dtSrc = "EXIF File";
                                break;
                            }
                        }
                        catch { }
                    }
                }
            }
            catch (Exception err) { }
            if (dt == null)
            {
                dt = File.GetLastWriteTime(file);
                dtSrc = "File";
            }
        }

        //string getImageDate(System.Drawing.Image img)
        //{
        //    var prop = img.PropertyItems.Where(x => x.Id == 0x9003).FirstOrDefault();
        //    if (prop != null)
        //    {
        //        ASCIIEncoding encoding = new ASCIIEncoding();
        //        var date = encoding.GetString(prop.Value);
        //        return date;
        //    }
        //    return "";
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            var me = new MediaElement();
            //me.LoadedBehavior = MediaState.Manual;
            wpf.Child = me;
        }

        private void lvwFiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (lvwFiles.SelectedItems.Count == 1)
                    ShowFileProperties(lvwFiles.SelectedItems[0].Tag as string);
                else
                {
                    splitContainer1.Enabled = false;
                    try
                    {
                        double filesSize = 0;
                        int c = 0;
                        foreach (System.Windows.Forms.ListViewItem i in lvwFiles.SelectedItems)
                        {
                            filesSize += ((long)i.SubItems[4].Tag) / 1024.0;
                            c++;
                            toolStripStatusLabel1.Text = $"Processing {c}/{lvwFiles.SelectedItems.Count} = {c * 100 / lvwFiles.SelectedItems.Count}%";
                            Application.DoEvents();
                        }
                        var unit = "K";
                        if (filesSize > 1024)
                        {
                            filesSize /= 1024;
                            unit = "M";
                        }
                        if (filesSize > 1024)
                        {
                            filesSize /= 1024;
                            unit = "G";
                        }
                        toolStripStatusLabel1.Text = $"Selected {lvwFiles.SelectedItems.Count}/{lvwFiles.Items.Count} = {filesSize:N2} {unit}B";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        splitContainer1.Enabled = true;
                    }
                }
            }
        }

        public enum FileExistsActions
        {
            Ask, Replace, Skip, SaveBoth
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileExistsActions fileExistsAction = FileExistsActions.Ask;
            var log = new List<string>();

            var frm = new FormCopy();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                splitContainer1.Enabled = false;
                try
                {
                    var pathsIsEqual = new DirectoryInfo(frm.tbxPath.Text).FullName == new DirectoryInfo(this.tbxPath.Text).FullName;
                    if (string.IsNullOrWhiteSpace(frm.tbxPath.Text) || (pathsIsEqual && !frm.chkRename.Checked))
                    {
                        MessageBox.Show("Путь не должен быть пустым.\nНельзя копировать (перемещать) в ту же папку.\nВ одной и той же папке можно только переименовать .");
                        return;
                    }
                    IEnumerable<System.Windows.Forms.ListViewItem> items = null;
                    int total = 0;
                    if (lvwFiles.SelectedItems.Count > 0)
                    {
                        items = lvwFiles.SelectedItems.Cast<System.Windows.Forms.ListViewItem>();
                        total = lvwFiles.SelectedItems.Count;
                    }
                    else
                    {
                        items = lvwFiles.Items.Cast<System.Windows.Forms.ListViewItem>();
                        total = lvwFiles.Items.Count;
                    }
                    int c = 0;
                    foreach (var item in items)
                    {
                        var desc = Path.GetDirectoryName(item.Text).Replace(Path.DirectorySeparatorChar.ToString(), " - ");
                        if (desc.Length > 0)
                            desc = " " + desc;
                        var dst = Path.Combine(frm.tbxPath.Text, ((DateTime)item.SubItems[2].Tag).ToString("yyyy"), ((DateTime)item.SubItems[2].Tag).ToString("yyyy-MMdd") + desc);
                        try
                        {
                            System.IO.Directory.CreateDirectory(dst);
                            var fn = Path.GetFileNameWithoutExtension(item.Tag as string);
                            var ext = Path.GetExtension(item.Tag as string);
                            if (frm.chkRename.Checked)
                            {
                                fn = ((DateTime)item.SubItems[2].Tag).ToString("yyyy-MM-dd_HH-mm-ss") + " " + fn;
                            }
                            if (File.Exists(Path.Combine(dst, fn + ext)))
                            {
                                var fea = fileExistsAction;
                                if (fea == FileExistsActions.Ask)
                                {
                                    var frmExists = new FormFileExistsAction();
                                    frmExists.lblFile.Text = Path.Combine(dst, fn + ext);
                                    if (frmExists.ShowDialog() == DialogResult.OK)
                                    {
                                        fea = frmExists.result;
                                        if (frmExists.chkAlways.Checked)
                                            fileExistsAction = fea;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (fea == FileExistsActions.Replace)
                                {
                                    try
                                    {
                                        File.Delete(Path.Combine(dst, fn + ext));
                                    }
                                    catch
                                    {
                                        log.Add("CAN'T REPLACE: " + Path.Combine(dst, fn + ext));
                                    }
                                }
                                else if (fea == FileExistsActions.SaveBoth)
                                {
                                    int n = 0;
                                    while (File.Exists(Path.Combine(dst, $"{fn} ({++n}){ext}")))
                                    {
                                        if (n == int.MaxValue)
                                        {
                                            log.Add("CAN'T SAVE BOTH: " + Path.Combine(dst, fn + ext));
                                            n = 0;
                                            break;
                                        }
                                    }
                                    if (n > 0)
                                    {
                                        fn = $"{fn} ({n})";
                                    }
                                }
                                else if (fea == FileExistsActions.Skip)
                                {
                                    log.Add("SKIP: " + Path.Combine(dst, fn + ext));
                                    continue;
                                }
                            }
                            if (frm.rbnMove.Checked || (pathsIsEqual && frm.chkRename.Checked))
                            {
                                File.Move(item.Tag as string, Path.Combine(dst, fn + ext));
                            }
                            else if (frm.rbnCopy.Checked)
                            {
                                File.Copy(item.Tag as string, Path.Combine(dst, fn + ext));
                            }
                            c++;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }
                        toolStripStatusLabel1.Text = $"{c}/{total} = {c * 100 / total}%";
                        Application.DoEvents();
                    }
                    toolStripStatusLabel1.Text = $"{c}/{total} = {c * 100 / total}%";
                    if (log.Count > 0)
                    {
                        var frmLog = new FormLog();
                        frmLog.tbxLog.Text = string.Join("\r\n", log);
                        frmLog.ShowDialog();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    splitContainer1.Enabled = true;
                }
            }
        }
    }
}
