namespace VideoPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_moveDown = new System.Windows.Forms.Button();
            this.btn_moveUp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_loop = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_video_info = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_video_tags = new System.Windows.Forms.Label();
            this.btn_savePlaylist = new System.Windows.Forms.Button();
            this.btn_loadPlaylist = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prev
            // 
            this.btn_prev.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_prev.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.ForeColor = System.Drawing.Color.White;
            this.btn_prev.Location = new System.Drawing.Point(119, 19);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(78, 30);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_play.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(287, 19);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(78, 30);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btn_loadPlaylist);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_savePlaylist);
            this.groupBox1.Controls.Add(this.lbl_volume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_moveDown);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.track_list);
            this.groupBox1.Controls.Add(this.btn_moveUp);
            this.groupBox1.Controls.Add(this.btn_loop);
            this.groupBox1.Controls.Add(this.btn_random);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_play);
            this.groupBox1.Controls.Add(this.btn_prev);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 178);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btn_moveDown
            // 
            this.btn_moveDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_moveDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_moveDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_moveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moveDown.ForeColor = System.Drawing.Color.White;
            this.btn_moveDown.Location = new System.Drawing.Point(791, 55);
            this.btn_moveDown.Name = "btn_moveDown";
            this.btn_moveDown.Size = new System.Drawing.Size(85, 30);
            this.btn_moveDown.TabIndex = 17;
            this.btn_moveDown.Text = "Move Down";
            this.btn_moveDown.UseVisualStyleBackColor = true;
            this.btn_moveDown.Click += new System.EventHandler(this.btn_moveDown_Click);
            // 
            // btn_moveUp
            // 
            this.btn_moveUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_moveUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_moveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_moveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moveUp.ForeColor = System.Drawing.Color.White;
            this.btn_moveUp.Location = new System.Drawing.Point(791, 19);
            this.btn_moveUp.Name = "btn_moveUp";
            this.btn_moveUp.Size = new System.Drawing.Size(85, 30);
            this.btn_moveUp.TabIndex = 16;
            this.btn_moveUp.Text = "Move Up";
            this.btn_moveUp.UseVisualStyleBackColor = true;
            this.btn_moveUp.Click += new System.EventHandler(this.btn_moveUp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 102);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(707, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 30);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(911, 72);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(23, 13);
            this.lbl_volume.TabIndex = 13;
            this.lbl_volume.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(882, 19);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 129);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(119, 55);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(666, 95);
            this.track_list.TabIndex = 11;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // btn_loop
            // 
            this.btn_loop.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_loop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_loop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_loop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_loop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loop.ForeColor = System.Drawing.Color.White;
            this.btn_loop.Location = new System.Drawing.Point(455, 19);
            this.btn_loop.Name = "btn_loop";
            this.btn_loop.Size = new System.Drawing.Size(78, 30);
            this.btn_loop.TabIndex = 6;
            this.btn_loop.Text = "Loop";
            this.btn_loop.UseVisualStyleBackColor = true;
            this.btn_loop.Click += new System.EventHandler(this.btn_loop_Click);
            // 
            // btn_random
            // 
            this.btn_random.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_random.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_random.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_random.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_random.ForeColor = System.Drawing.Color.White;
            this.btn_random.Location = new System.Drawing.Point(539, 19);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(78, 30);
            this.btn_random.TabIndex = 5;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_open.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.Location = new System.Drawing.Point(623, 19);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(78, 30);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_pause.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.White;
            this.btn_pause.Location = new System.Drawing.Point(203, 19);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(78, 30);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_next.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(371, 19);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(78, 30);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 281);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(857, 12);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_track_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_track_start.Location = new System.Drawing.Point(15, 280);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(34, 13);
            this.lbl_track_start.TabIndex = 14;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_track_end.ForeColor = System.Drawing.Color.Blue;
            this.lbl_track_end.Location = new System.Drawing.Point(918, 280);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(34, 13);
            this.lbl_track_end.TabIndex = 15;
            this.lbl_track_end.Text = "00:00";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Black;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_msg.Location = new System.Drawing.Point(-1, 1);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(97, 20);
            this.lbl_msg.TabIndex = 16;
            this.lbl_msg.Text = "Video Player";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(544, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_video_info
            // 
            this.lbl_video_info.AutoSize = true;
            this.lbl_video_info.BackColor = System.Drawing.Color.Black;
            this.lbl_video_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_video_info.Location = new System.Drawing.Point(796, 58);
            this.lbl_video_info.Name = "lbl_video_info";
            this.lbl_video_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_video_info.TabIndex = 20;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(18, 24);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(611, 236);
            this.player.TabIndex = 17;
            // 
            // lbl_video_tags
            // 
            this.lbl_video_tags.AutoSize = true;
            this.lbl_video_tags.BackColor = System.Drawing.Color.Black;
            this.lbl_video_tags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_video_tags.Location = new System.Drawing.Point(796, 121);
            this.lbl_video_tags.Name = "lbl_video_tags";
            this.lbl_video_tags.Size = new System.Drawing.Size(0, 13);
            this.lbl_video_tags.TabIndex = 21;
            // 
            // btn_savePlaylist
            // 
            this.btn_savePlaylist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_savePlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_savePlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_savePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savePlaylist.ForeColor = System.Drawing.Color.White;
            this.btn_savePlaylist.Location = new System.Drawing.Point(791, 91);
            this.btn_savePlaylist.Name = "btn_savePlaylist";
            this.btn_savePlaylist.Size = new System.Drawing.Size(85, 30);
            this.btn_savePlaylist.TabIndex = 18;
            this.btn_savePlaylist.Text = "Save";
            this.btn_savePlaylist.UseVisualStyleBackColor = true;
            this.btn_savePlaylist.Click += new System.EventHandler(this.btn_savePlaylist_Click);
            // 
            // btn_loadPlaylist
            // 
            this.btn_loadPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_loadPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_loadPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_loadPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadPlaylist.ForeColor = System.Drawing.Color.White;
            this.btn_loadPlaylist.Location = new System.Drawing.Point(791, 127);
            this.btn_loadPlaylist.Name = "btn_loadPlaylist";
            this.btn_loadPlaylist.Size = new System.Drawing.Size(85, 30);
            this.btn_loadPlaylist.TabIndex = 19;
            this.btn_loadPlaylist.Text = "Upload";
            this.btn_loadPlaylist.UseVisualStyleBackColor = true;
            this.btn_loadPlaylist.Click += new System.EventHandler(this.btn_loadPlaylist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(962, 485);
            this.Controls.Add(this.lbl_video_tags);
            this.Controls.Add(this.lbl_video_info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Player";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button btn_loop;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Label lbl_msg;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_video_info;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_video_tags;
        private System.Windows.Forms.Button btn_moveUp;
        private System.Windows.Forms.Button btn_moveDown;
        private System.Windows.Forms.Button btn_savePlaylist;
        private System.Windows.Forms.Button btn_loadPlaylist;
    }
}

