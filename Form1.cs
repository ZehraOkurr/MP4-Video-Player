using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using FFmpeg.AutoGen;
using TagLib;


namespace VideoPlayer
{
    public partial class Form1 : Form
    {

        private string videoPath;
        private Thread videoThread;
        private volatile bool isPlaying;
        private AxWindowsMediaPlayer mediaPlayer;
        private bool isLooping = false; // Döngü özelliği için
        private bool isRandom = false; // Rastgele özelliği için
        private Random random = new Random(); // Rastgele sayılar üretmek için
       

        public Form1()
        {

            InitializeComponent();
            player.uiMode = "none";
        }
        

        string[] paths, files;
        private void ReadVideoTags(string videoPath)
        {
            try
            {
                var file = TagLib.File.Create(videoPath);

                string title = file.Tag.Title ?? "Unknown";
                string artist = file.Tag.Performers.Length > 0 ? string.Join(", ", file.Tag.Performers) : "Unknown";
                string album = file.Tag.Album ?? "Unknown";
                string year = file.Tag.Year > 0 ? file.Tag.Year.ToString() : "Unknown";
                string genre = file.Tag.Genres.Length > 0 ? string.Join(", ", file.Tag.Genres) : "Unknown";

                lbl_video_tags.Text = $"🎬 Title: {title}\n🎤 Artist: {artist}\n📀 Album: {album}\n📆 Year: {year}\n🎼 Genre: {genre}";
            }
            catch (Exception ex)
            {
                lbl_video_tags.Text = "Metadata could not be retrieved: " + ex.Message;
            }
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = track_list.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < paths.Length)
            {
                player.URL = paths[selectedIndex];
                player.Ctlcontrols.play();
                lbl_msg.Text = "Playing...";
                timer1.Start();
                trackBar1.Value = 15;
                lbl_volume.Text = trackBar1.Value.ToString() + "%";

                // Video thumbnail ve bilgilerini al
                CaptureThumbnailFFmpeg(paths[selectedIndex]);
                CaptureVideoInfo(paths[selectedIndex]);  // ✅ Video bilgilerini al

                // ✅ Video etiket bilgilerini al ve göster
                ReadVideoTags(paths[selectedIndex]);
            }
            else
            {
                lbl_msg.Text = "Invalid track selected.";
            }

        }
        private void CaptureThumbnailFFmpeg(string videoPath)
        {
            try
            {
                if (string.IsNullOrEmpty(videoPath)) return;

                // Video adına özel bir thumbnail dosya ismi oluştur
                string fileName = System.IO.Path.GetFileNameWithoutExtension(videoPath);
                string outputImagePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), fileName + "_thumbnail.jpg");

                // FFmpeg ile ilk kareyi yakala
                var ffmpegArgs = $"-i \"{videoPath}\" -vf \"thumbnail,scale=300:-1\" -frames:v 1 \"{outputImagePath}\" -y";

                using (var process = new System.Diagnostics.Process())
                {
                    process.StartInfo.FileName = "ffmpeg";
                    process.StartInfo.Arguments = ffmpegArgs;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.WaitForExit();
                }

                // Eğer çıktı dosyası varsa, PictureBox'a yükle
                if (System.IO.File.Exists(outputImagePath))
                {
                    // Önceki resmi bellekte tutup hataya sebep olmaması için önceki resmi temizle
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = Image.FromFile(outputImagePath);
                }
            }
            catch (Exception ex)
            {
                lbl_msg.Text = "Thumbnail capture failed: " + ex.Message;
            }
        }

        private void CaptureThumbnail()
        {
            try
            {
                if (string.IsNullOrEmpty(videoPath)) return;

                string outputImagePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "thumbnail.jpg");

                // FFmpeg ile ilk kareyi yakala
                var ffmpegArgs = $"-i \"{videoPath}\" -vf \"thumbnail,scale=300:-1\" -frames:v 1 \"{outputImagePath}\" -y";

                using (var process = new System.Diagnostics.Process())
                {
                    process.StartInfo.FileName = "ffmpeg";
                    process.StartInfo.Arguments = ffmpegArgs;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.WaitForExit();
                }

                // Eğer çıktı dosyası varsa, PictureBox'a yükle
                if (System.IO.File.Exists(outputImagePath))
                {
                    pictureBox1.Image = Image.FromFile(outputImagePath);
                }
            }
            catch (Exception ex)
            {
                lbl_msg.Text = "Thumbnail capture failed: " + ex.Message;
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            lbl_msg.Text = "Playing...";
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            lbl_msg.Text = "Pause";
        }

        private void CaptureVideoInfo(string videoPath)
        {
            try
            {
                if (string.IsNullOrEmpty(videoPath)) return;

                // ffprobe kullanarak video bilgilerini al
                var ffprobeArgs = $"-v quiet -print_format json -show_streams -show_format \"{videoPath}\"";

                using (var process = new System.Diagnostics.Process())
                {
                    process.StartInfo.FileName = "ffprobe";
                    process.StartInfo.Arguments = ffprobeArgs;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // JSON çıktısını ayrıştır
                    var json = Newtonsoft.Json.Linq.JObject.Parse(output);

                    // Video süresi
                    string duration = json["format"]["duration"]?.ToString();
                    string codec = json["streams"]?[0]?["codec_name"]?.ToString();
                    string width = json["streams"]?[0]?["width"]?.ToString();
                    string height = json["streams"]?[0]?["height"]?.ToString();

                    // UI'da göster
                    lbl_video_info.Text = $"⏳ Duration: {duration} sn\n🎞 Codec: {codec}\n📏 Resolution: {width}x{height}";
                }
            }
            catch (Exception ex)
            {
                lbl_video_info.Text = "Video bilgisi alınamadı: " + ex.Message;
            }
        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            if (isRandom)
            {
                // Rastgele bir parça seç
                track_list.SelectedIndex = random.Next(0, track_list.Items.Count);
            }
            else
            {
                // Sıradaki parçaya geç
                if (track_list.SelectedIndex < track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex + 1;
                }
                else if (isLooping)
                {
                    // Eğer döngü modu aktifse başa dön
                    track_list.SelectedIndex = 0;
                }
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0) 
            {
            track_list.SelectedIndex=track_list.SelectedIndex - 1;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.currentMedia.duration; // Şarkı süresini ProgressBar'ın maksimumu olarak ayarla
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition; // Mevcut pozisyonu ayarla
            }

            lbl_track_start.Text = player.Ctlcontrols.currentPositionString; // Şarkının başlangıç süresi
            lbl_track_end.Text = player.currentMedia.durationString; // Şarkının toplam süresi

            // Parça bittiğinde loop veya sonraki şarkıya geçiş
            if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (isLooping)
                {
                    player.Ctlcontrols.play();
                }
                else
                {
                    btn_next_Click(null, null);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume=trackBar1.Value;
            lbl_volume.Text = trackBar1.Value.ToString();
        }

        private void btn_loop_Click(object sender, EventArgs e)
        {
            // Döngü modunu aç/kapat
            isLooping = !isLooping;

            // Kullanıcıya durum mesajı göster
            lbl_msg.Text = isLooping ? "Looping enabled!" : "Looping disabled!";
        }

       

        private void btn_random_Click(object sender, EventArgs e)
        {

            // Öncelikle paths ve files dizilerini karıştır
            if (paths != null && paths.Length > 0)
            {
                // Rastgele karıştırma işlemi için bir liste oluştur
                var combined = paths.Zip(files, (path, file) => new { path, file }).ToList();
                combined = combined.OrderBy(x => random.Next()).ToList();

                // Karıştırılmış listeleri tekrar paths ve files dizilerine aktar
                paths = combined.Select(x => x.path).ToArray();
                files = combined.Select(x => x.file).ToArray();

                // track_list içeriğini güncelle
                track_list.Items.Clear();
                foreach (var file in files)
                {
                    track_list.Items.Add(file);
                }

                lbl_msg.Text = "Playlist shuffled!";
            }
            else
            {
                lbl_msg.Text = "No items to shuffle!";
            }
        }


        private void btn_open_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++) 
                { track_list.Items.Add(files[x]); 
            }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0) // Eğer bir şarkı seçiliyse
            {
                int index = track_list.SelectedIndex;

                // Seçili şarkıyı listeden kaldır
                track_list.Items.RemoveAt(index);

                // Dizilerden de kaldır (Eğer paths ve files doluysa)
                if (paths != null && files != null && paths.Length > index)
                {
                    List<string> pathsList = paths.ToList();
                    List<string> filesList = files.ToList();
                    pathsList.RemoveAt(index);
                    filesList.RemoveAt(index);
                    paths = pathsList.ToArray();
                    files = filesList.ToArray();
                }

                // Eğer oynatılan şarkı silindiyse, oynatmayı durdur
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying && track_list.SelectedIndex == -1)
                {
                    player.Ctlcontrols.stop();
                    lbl_msg.Text = "No track selected.";
                }
            }
            else
            {
                lbl_msg.Text = "Please select a track to delete.";
            }
        }

        private void btn_moveUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = track_list.SelectedIndex;

            if (selectedIndex > 0) // Eğer en üstte değilse yukarı taşı
            {
                // Şarkıyı listede yukarı taşı
                string tempFile = files[selectedIndex];
                string tempPath = paths[selectedIndex];

                files[selectedIndex] = files[selectedIndex - 1];
                paths[selectedIndex] = paths[selectedIndex - 1];

                files[selectedIndex - 1] = tempFile;
                paths[selectedIndex - 1] = tempPath;

                // ListBox güncelle
                track_list.Items[selectedIndex] = track_list.Items[selectedIndex - 1];
                track_list.Items[selectedIndex - 1] = tempFile;

                // Seçimi yeni konuma ayarla
                track_list.SelectedIndex = selectedIndex - 1;
            }
        }

        private void btn_moveDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = track_list.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < track_list.Items.Count - 1) // En altta değilse aşağı taşı
            {
                // Şarkıyı listede aşağı taşı
                string tempFile = files[selectedIndex];
                string tempPath = paths[selectedIndex];

                files[selectedIndex] = files[selectedIndex + 1];
                paths[selectedIndex] = paths[selectedIndex + 1];

                files[selectedIndex + 1] = tempFile;
                paths[selectedIndex + 1] = tempPath;

                // ListBox güncelle
                track_list.Items[selectedIndex] = track_list.Items[selectedIndex + 1];
                track_list.Items[selectedIndex + 1] = tempFile;

                // Seçimi yeni konuma ayarla
                track_list.SelectedIndex = selectedIndex + 1;
            }
        }
        private void SavePlaylist(string filename)
        {
            try
            {
                if (paths != null && paths.Length > 0)
                {
                    System.IO.File.WriteAllLines(filename, paths);
                    lbl_msg.Text = "Playlist saved successfully!";
                }
                else
                {
                    lbl_msg.Text = "No tracks to save.";
                }
            }
            catch (Exception ex)
            {
                lbl_msg.Text = "Error saving playlist: " + ex.Message;
            }
        }

        private void LoadPlaylist(string filename)
        {
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    paths = System.IO.File.ReadAllLines(filename);
                    files = paths.Select(System.IO.Path.GetFileName).ToArray();

                    track_list.Items.Clear();
                    track_list.Items.AddRange(files);

                    lbl_msg.Text = "Playlist loaded successfully!";
                }
                else
                {
                    lbl_msg.Text = "Playlist file not found.";
                }
            }
            catch (Exception ex)
            {
                lbl_msg.Text = "Error loading playlist: " + ex.Message;
            }
        }

        private void btn_savePlaylist_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Playlist Files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SavePlaylist(sfd.FileName);
            }
        }

        private void btn_loadPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Playlist Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadPlaylist(ofd.FileName);
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (player.currentMedia != null)
            {
                // Mouse tıklanan pozisyona göre ProgressBar yüzdesini hesapla
                double ratio = (double)e.X / progressBar1.Width;
                double newPosition = ratio * player.currentMedia.duration;

                // Şarkının yeni konumuna ayarla
                player.Ctlcontrols.currentPosition = newPosition;
            }
        }
    }

  
}
