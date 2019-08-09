namespace Fishing
{
    partial class Inventory
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
            this.BaitBox = new System.Windows.Forms.PictureBox();
            this.FLineBox = new System.Windows.Forms.PictureBox();
            this.ReelBox = new System.Windows.Forms.PictureBox();
            this.RoadBox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.FetchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.assembliesBox = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.LuresList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ReelsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FLineList = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RoadsList = new System.Windows.Forms.ListBox();
            this.ItemsTab = new System.Windows.Forms.TabControl();
            this.nameLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLineBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ItemsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaitBox
            // 
            this.BaitBox.Location = new System.Drawing.Point(160, 306);
            this.BaitBox.Name = "BaitBox";
            this.BaitBox.Size = new System.Drawing.Size(90, 97);
            this.BaitBox.TabIndex = 3;
            this.BaitBox.TabStop = false;
            // 
            // FLineBox
            // 
            this.FLineBox.BackgroundImage = global::Fishing.Resource1.NOT_SCAF;
            this.FLineBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FLineBox.Location = new System.Drawing.Point(160, 202);
            this.FLineBox.Name = "FLineBox";
            this.FLineBox.Size = new System.Drawing.Size(90, 98);
            this.FLineBox.TabIndex = 2;
            this.FLineBox.TabStop = false;
            // 
            // ReelBox
            // 
            this.ReelBox.BackgroundImage = global::Fishing.Resource1.NOT_REEL;
            this.ReelBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReelBox.InitialImage = global::Fishing.Resource1.NOT_REEL;
            this.ReelBox.Location = new System.Drawing.Point(160, 101);
            this.ReelBox.Name = "ReelBox";
            this.ReelBox.Size = new System.Drawing.Size(90, 95);
            this.ReelBox.TabIndex = 1;
            this.ReelBox.TabStop = false;
            // 
            // RoadBox
            // 
            this.RoadBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RoadBox.Location = new System.Drawing.Point(160, 6);
            this.RoadBox.Name = "RoadBox";
            this.RoadBox.Size = new System.Drawing.Size(90, 89);
            this.RoadBox.TabIndex = 0;
            this.RoadBox.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(282, 92);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(155, 171);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(282, 269);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(155, 20);
            this.nameBox.TabIndex = 13;
            // 
            // powerBox
            // 
            this.powerBox.Location = new System.Drawing.Point(282, 295);
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(155, 20);
            this.powerBox.TabIndex = 14;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(282, 321);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(155, 20);
            this.typeBox.TabIndex = 16;
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(182, 409);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(68, 20);
            this.countBox.TabIndex = 18;
            // 
            // FetchButton
            // 
            this.FetchButton.Location = new System.Drawing.Point(346, 347);
            this.FetchButton.Name = "FetchButton";
            this.FetchButton.Size = new System.Drawing.Size(91, 23);
            this.FetchButton.TabIndex = 19;
            this.FetchButton.Text = "Добавить сборку";
            this.FetchButton.UseVisualStyleBackColor = true;
            this.FetchButton.Click += new System.EventHandler(this.FetchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(507, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.assembliesBox);
            this.tabPage6.Controls.Add(this.RoadBox);
            this.tabPage6.Controls.Add(this.ReelBox);
            this.tabPage6.Controls.Add(this.FLineBox);
            this.tabPage6.Controls.Add(this.BaitBox);
            this.tabPage6.Controls.Add(this.countBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(256, 470);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Сборки";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // assembliesBox
            // 
            this.assembliesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.assembliesBox.FormattingEnabled = true;
            this.assembliesBox.Location = new System.Drawing.Point(-4, 0);
            this.assembliesBox.Name = "assembliesBox";
            this.assembliesBox.Size = new System.Drawing.Size(158, 472);
            this.assembliesBox.TabIndex = 21;
            this.assembliesBox.SelectedIndexChanged += new System.EventHandler(this.AssembliesBox_SelectedIndexChanged);
            this.assembliesBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AssembliesBox_MouseDoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.LuresList);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(256, 470);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Приманки";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // LuresList
            // 
            this.LuresList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LuresList.FormattingEnabled = true;
            this.LuresList.Location = new System.Drawing.Point(0, 1);
            this.LuresList.Name = "LuresList";
            this.LuresList.Size = new System.Drawing.Size(261, 472);
            this.LuresList.TabIndex = 20;
            this.LuresList.SelectedIndexChanged += new System.EventHandler(this.LuresList_SelectedIndexChanged);
            this.LuresList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LuresList_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReelsList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(256, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Катушки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReelsList
            // 
            this.ReelsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReelsList.FormattingEnabled = true;
            this.ReelsList.Location = new System.Drawing.Point(3, 0);
            this.ReelsList.Name = "ReelsList";
            this.ReelsList.Size = new System.Drawing.Size(258, 472);
            this.ReelsList.TabIndex = 5;
            this.ReelsList.SelectedIndexChanged += new System.EventHandler(this.ReelsList_SelectedIndexChanged);
            this.ReelsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ReelsList_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FLineList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Леска";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FLineList
            // 
            this.FLineList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FLineList.Location = new System.Drawing.Point(0, 0);
            this.FLineList.Name = "FLineList";
            this.FLineList.Size = new System.Drawing.Size(261, 472);
            this.FLineList.TabIndex = 6;
            this.FLineList.SelectedIndexChanged += new System.EventHandler(this.FLineList_SelectedIndexChanged);
            this.FLineList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FLineList_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RoadsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Удочки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RoadsList
            // 
            this.RoadsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RoadsList.FormattingEnabled = true;
            this.RoadsList.Location = new System.Drawing.Point(-4, 1);
            this.RoadsList.Name = "RoadsList";
            this.RoadsList.Size = new System.Drawing.Size(269, 472);
            this.RoadsList.TabIndex = 4;
            this.RoadsList.SelectedIndexChanged += new System.EventHandler(this.RoadsList_SelectedIndexChanged);
            this.RoadsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RoadsList_MouseDoubleClick);
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.tabPage1);
            this.ItemsTab.Controls.Add(this.tabPage2);
            this.ItemsTab.Controls.Add(this.tabPage3);
            this.ItemsTab.Controls.Add(this.tabPage5);
            this.ItemsTab.Controls.Add(this.tabPage6);
            this.ItemsTab.Location = new System.Drawing.Point(12, 70);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.SelectedIndex = 0;
            this.ItemsTab.Size = new System.Drawing.Size(264, 496);
            this.ItemsTab.TabIndex = 23;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Aqua;
            this.nameLabel.Location = new System.Drawing.Point(443, 269);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 20);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Название";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.BackColor = System.Drawing.Color.Transparent;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerLabel.ForeColor = System.Drawing.Color.Aqua;
            this.powerLabel.Location = new System.Drawing.Point(443, 295);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(96, 20);
            this.powerLabel.TabIndex = 26;
            this.powerLabel.Text = "Мощность";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.ForeColor = System.Drawing.Color.Aqua;
            this.typeLabel.Location = new System.Drawing.Point(443, 321);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(39, 20);
            this.typeLabel.TabIndex = 27;
            this.typeLabel.Text = "Тип";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fishing.Resource1.LAYER1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 650);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ItemsTab);
            this.Controls.Add(this.FetchButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLineBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ItemsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RoadBox;
        private System.Windows.Forms.PictureBox ReelBox;
        private System.Windows.Forms.PictureBox FLineBox;
        private System.Windows.Forms.PictureBox BaitBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Button FetchButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox assembliesBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox LuresList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox ReelsList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox FLineList;
        private System.Windows.Forms.TabPage tabPage1;
        protected internal System.Windows.Forms.ListBox RoadsList;
        private System.Windows.Forms.TabControl ItemsTab;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label typeLabel;
    }
}