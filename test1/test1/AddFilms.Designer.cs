namespace test1
{
    partial class AddFilms
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
            this.b_AddFilm = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.dt_finish = new System.Windows.Forms.DateTimePicker();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.tb_dur = new System.Windows.Forms.TextBox();
            this.cb_genre = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_AddFilm
            // 
            this.b_AddFilm.Location = new System.Drawing.Point(48, 7);
            this.b_AddFilm.Name = "b_AddFilm";
            this.b_AddFilm.Size = new System.Drawing.Size(75, 23);
            this.b_AddFilm.TabIndex = 12;
            this.b_AddFilm.Text = "Добавить";
            this.b_AddFilm.UseVisualStyleBackColor = true;
            this.b_AddFilm.Click += new System.EventHandler(this.Add_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(191, 7);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 13;
            this.b_cancel.Text = "Отмена";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_cancel);
            this.panel1.Controls.Add(this.b_AddFilm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 37);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_cost);
            this.panel2.Controls.Add(this.dt_finish);
            this.panel2.Controls.Add(this.dt_start);
            this.panel2.Controls.Add(this.tb_dur);
            this.panel2.Controls.Add(this.cb_genre);
            this.panel2.Controls.Add(this.tb_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 268);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Стоймость фильма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Окончание премьеры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Начало премьеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Продолжительность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Жанр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название фильма";
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(145, 230);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(168, 20);
            this.tb_cost.TabIndex = 17;
            // 
            // dt_finish
            // 
            this.dt_finish.Location = new System.Drawing.Point(145, 187);
            this.dt_finish.Name = "dt_finish";
            this.dt_finish.Size = new System.Drawing.Size(167, 20);
            this.dt_finish.TabIndex = 16;
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(145, 144);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(167, 20);
            this.dt_start.TabIndex = 15;
            // 
            // tb_dur
            // 
            this.tb_dur.Location = new System.Drawing.Point(145, 101);
            this.tb_dur.Name = "tb_dur";
            this.tb_dur.Size = new System.Drawing.Size(168, 20);
            this.tb_dur.TabIndex = 14;
            // 
            // cb_genre
            // 
            this.cb_genre.FormattingEnabled = true;
            this.cb_genre.Location = new System.Drawing.Point(145, 57);
            this.cb_genre.Name = "cb_genre";
            this.cb_genre.Size = new System.Drawing.Size(168, 21);
            this.cb_genre.TabIndex = 13;
            // 
            // tb_name
            // 
            this.tb_name.HideSelection = false;
            this.tb_name.Location = new System.Drawing.Point(145, 14);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(168, 20);
            this.tb_name.TabIndex = 12;
            // 
            // AddFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(341, 343);
            this.Name = "AddFilms";
            this.Text = "Добавление фильма";
            this.Load += new System.EventHandler(this.AddFilms_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_AddFilm;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.DateTimePicker dt_finish;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.TextBox tb_dur;
        private System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.ComboBox cb_genre;
    }
}