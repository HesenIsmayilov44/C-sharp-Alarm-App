namespace Alarm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.cmbbx_sound = new System.Windows.Forms.ComboBox();
            this.lbl_now = new System.Windows.Forms.Label();
            this.lbl_nowText = new System.Windows.Forms.Label();
            this.lbl_alarmIsSet = new System.Windows.Forms.Label();
            this.secondInput = new System.Windows.Forms.NumericUpDown();
            this.minuteInput = new System.Windows.Forms.NumericUpDown();
            this.lbl_twoDots1 = new System.Windows.Forms.Label();
            this.lbl_twoDots2 = new System.Windows.Forms.Label();
            this.lbl_setAlarmText = new System.Windows.Forms.Label();
            this.cmbbx_partOfDay = new System.Windows.Forms.ComboBox();
            this.hourInput = new System.Windows.Forms.NumericUpDown();
            this.lbl_selectSoundText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secondInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourInput)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_now
            // 
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // timer_check
            // 
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(159, 377);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(103, 33);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_stop.Location = new System.Drawing.Point(301, 377);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(103, 33);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // cmbbx_sound
            // 
            this.cmbbx_sound.AllowDrop = true;
            this.cmbbx_sound.BackColor = System.Drawing.Color.Black;
            this.cmbbx_sound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_sound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbbx_sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_sound.ForeColor = System.Drawing.Color.White;
            this.cmbbx_sound.FormattingEnabled = true;
            this.cmbbx_sound.Items.AddRange(new object[] {
            "DesiJourney",
            "Medley",
            "MoodyLoop",
            "ShakeYourBody",
            "UpbeatFunk"});
            this.cmbbx_sound.Location = new System.Drawing.Point(194, 228);
            this.cmbbx_sound.Name = "cmbbx_sound";
            this.cmbbx_sound.Size = new System.Drawing.Size(137, 28);
            this.cmbbx_sound.TabIndex = 6;
            // 
            // lbl_now
            // 
            this.lbl_now.AutoSize = true;
            this.lbl_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_now.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_now.Location = new System.Drawing.Point(93, 37);
            this.lbl_now.Name = "lbl_now";
            this.lbl_now.Size = new System.Drawing.Size(453, 82);
            this.lbl_now.TabIndex = 8;
            this.lbl_now.Text = "00:00:00 AM";
            this.lbl_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nowText
            // 
            this.lbl_nowText.AutoSize = true;
            this.lbl_nowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nowText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_nowText.Location = new System.Drawing.Point(55, 73);
            this.lbl_nowText.Name = "lbl_nowText";
            this.lbl_nowText.Size = new System.Drawing.Size(35, 16);
            this.lbl_nowText.TabIndex = 9;
            this.lbl_nowText.Text = "Now";
            // 
            // lbl_alarmIsSet
            // 
            this.lbl_alarmIsSet.AutoSize = true;
            this.lbl_alarmIsSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.lbl_alarmIsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alarmIsSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_alarmIsSet.Location = new System.Drawing.Point(207, 294);
            this.lbl_alarmIsSet.Name = "lbl_alarmIsSet";
            this.lbl_alarmIsSet.Size = new System.Drawing.Size(42, 16);
            this.lbl_alarmIsSet.TabIndex = 10;
            this.lbl_alarmIsSet.Text = "alarm";
            // 
            // secondInput
            // 
            this.secondInput.BackColor = System.Drawing.Color.Black;
            this.secondInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.secondInput.Location = new System.Drawing.Point(318, 156);
            this.secondInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(54, 38);
            this.secondInput.TabIndex = 12;
            // 
            // minuteInput
            // 
            this.minuteInput.BackColor = System.Drawing.Color.Black;
            this.minuteInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.minuteInput.Location = new System.Drawing.Point(229, 156);
            this.minuteInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteInput.Name = "minuteInput";
            this.minuteInput.Size = new System.Drawing.Size(54, 38);
            this.minuteInput.TabIndex = 13;
            // 
            // lbl_twoDots1
            // 
            this.lbl_twoDots1.AutoSize = true;
            this.lbl_twoDots1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_twoDots1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_twoDots1.Location = new System.Drawing.Point(200, 156);
            this.lbl_twoDots1.Name = "lbl_twoDots1";
            this.lbl_twoDots1.Size = new System.Drawing.Size(23, 31);
            this.lbl_twoDots1.TabIndex = 14;
            this.lbl_twoDots1.Text = ":";
            // 
            // lbl_twoDots2
            // 
            this.lbl_twoDots2.AutoSize = true;
            this.lbl_twoDots2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_twoDots2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_twoDots2.Location = new System.Drawing.Point(289, 156);
            this.lbl_twoDots2.Name = "lbl_twoDots2";
            this.lbl_twoDots2.Size = new System.Drawing.Size(23, 31);
            this.lbl_twoDots2.TabIndex = 15;
            this.lbl_twoDots2.Text = ":";
            // 
            // lbl_setAlarmText
            // 
            this.lbl_setAlarmText.AutoSize = true;
            this.lbl_setAlarmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setAlarmText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_setAlarmText.Location = new System.Drawing.Point(55, 169);
            this.lbl_setAlarmText.Name = "lbl_setAlarmText";
            this.lbl_setAlarmText.Size = new System.Drawing.Size(66, 16);
            this.lbl_setAlarmText.TabIndex = 16;
            this.lbl_setAlarmText.Text = "Set Alarm";
            // 
            // cmbbx_partOfDay
            // 
            this.cmbbx_partOfDay.BackColor = System.Drawing.Color.Black;
            this.cmbbx_partOfDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_partOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_partOfDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbbx_partOfDay.FormattingEnabled = true;
            this.cmbbx_partOfDay.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbbx_partOfDay.Location = new System.Drawing.Point(406, 156);
            this.cmbbx_partOfDay.Name = "cmbbx_partOfDay";
            this.cmbbx_partOfDay.Size = new System.Drawing.Size(71, 39);
            this.cmbbx_partOfDay.TabIndex = 17;
            // 
            // hourInput
            // 
            this.hourInput.BackColor = System.Drawing.Color.Black;
            this.hourInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hourInput.Location = new System.Drawing.Point(140, 157);
            this.hourInput.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourInput.Name = "hourInput";
            this.hourInput.Size = new System.Drawing.Size(54, 38);
            this.hourInput.TabIndex = 18;
            // 
            // lbl_selectSoundText
            // 
            this.lbl_selectSoundText.AutoSize = true;
            this.lbl_selectSoundText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectSoundText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_selectSoundText.Location = new System.Drawing.Point(66, 234);
            this.lbl_selectSoundText.Name = "lbl_selectSoundText";
            this.lbl_selectSoundText.Size = new System.Drawing.Size(88, 16);
            this.lbl_selectSoundText.TabIndex = 19;
            this.lbl_selectSoundText.Text = "Select Sound";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(581, 436);
            this.Controls.Add(this.lbl_selectSoundText);
            this.Controls.Add(this.hourInput);
            this.Controls.Add(this.cmbbx_partOfDay);
            this.Controls.Add(this.lbl_setAlarmText);
            this.Controls.Add(this.lbl_twoDots2);
            this.Controls.Add(this.lbl_twoDots1);
            this.Controls.Add(this.minuteInput);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.lbl_alarmIsSet);
            this.Controls.Add(this.lbl_nowText);
            this.Controls.Add(this.lbl_now);
            this.Controls.Add(this.cmbbx_sound);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_now;
        private System.Windows.Forms.Timer timer_check;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ComboBox cmbbx_sound;
        private System.Windows.Forms.Label lbl_now;
        private System.Windows.Forms.Label lbl_nowText;
        private System.Windows.Forms.Label lbl_alarmIsSet;
        private System.Windows.Forms.NumericUpDown secondInput;
        private System.Windows.Forms.NumericUpDown minuteInput;
        private System.Windows.Forms.Label lbl_twoDots1;
        private System.Windows.Forms.Label lbl_twoDots2;
        private System.Windows.Forms.Label lbl_setAlarmText;
        private System.Windows.Forms.ComboBox cmbbx_partOfDay;
        private System.Windows.Forms.NumericUpDown hourInput;
        private System.Windows.Forms.Label lbl_selectSoundText;
    }
}

