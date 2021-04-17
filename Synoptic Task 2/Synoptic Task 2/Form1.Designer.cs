namespace Synoptic_Task_2
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
            this.Calcuatebutton = new System.Windows.Forms.Button();
            this.lengthbox = new System.Windows.Forms.TextBox();
            this.widthbox = new System.Windows.Forms.TextBox();
            this.Areatext = new System.Windows.Forms.TextBox();
            this.tileableAreatxt = new System.Windows.Forms.TextBox();
            this.label_length = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label_area = new System.Windows.Forms.Label();
            this.label_tiles = new System.Windows.Forms.Label();
            this.cutout1Length = new System.Windows.Forms.TextBox();
            this.cutout1total = new System.Windows.Forms.TextBox();
            this.cutout2width = new System.Windows.Forms.TextBox();
            this.cutout1Width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cutout2length = new System.Windows.Forms.TextBox();
            this.cutout2total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radio60 = new System.Windows.Forms.RadioButton();
            this.radio75 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalTileBox = new System.Windows.Forms.TextBox();
            this.offcutbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.edgingstripbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcuatebutton
            // 
            this.Calcuatebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Calcuatebutton.Location = new System.Drawing.Point(37, 267);
            this.Calcuatebutton.Name = "Calcuatebutton";
            this.Calcuatebutton.Size = new System.Drawing.Size(520, 37);
            this.Calcuatebutton.TabIndex = 0;
            this.Calcuatebutton.Text = "Calucate";
            this.Calcuatebutton.UseVisualStyleBackColor = false;
            this.Calcuatebutton.Click += new System.EventHandler(this.Calcuatebutton_Click);
            // 
            // lengthbox
            // 
            this.lengthbox.Location = new System.Drawing.Point(58, 44);
            this.lengthbox.Name = "lengthbox";
            this.lengthbox.Size = new System.Drawing.Size(114, 20);
            this.lengthbox.TabIndex = 1;
            this.lengthbox.Text = "0";
            // 
            // widthbox
            // 
            this.widthbox.Location = new System.Drawing.Point(58, 84);
            this.widthbox.Name = "widthbox";
            this.widthbox.Size = new System.Drawing.Size(114, 20);
            this.widthbox.TabIndex = 2;
            this.widthbox.Text = "0";
            // 
            // Areatext
            // 
            this.Areatext.Location = new System.Drawing.Point(144, 189);
            this.Areatext.Name = "Areatext";
            this.Areatext.ReadOnly = true;
            this.Areatext.Size = new System.Drawing.Size(100, 20);
            this.Areatext.TabIndex = 3;
            // 
            // tileableAreatxt
            // 
            this.tileableAreatxt.Location = new System.Drawing.Point(331, 321);
            this.tileableAreatxt.Name = "tileableAreatxt";
            this.tileableAreatxt.ReadOnly = true;
            this.tileableAreatxt.Size = new System.Drawing.Size(100, 20);
            this.tileableAreatxt.TabIndex = 4;
            this.tileableAreatxt.Text = " ";
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(12, 47);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(40, 13);
            this.label_length.TabIndex = 5;
            this.label_length.Text = "Length";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(12, 87);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(35, 13);
            this.label_width.TabIndex = 6;
            this.label_width.Text = "Width";
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(10, 192);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(60, 13);
            this.label_area.TabIndex = 7;
            this.label_area.Text = "Room Area";
            // 
            // label_tiles
            // 
            this.label_tiles.AutoSize = true;
            this.label_tiles.Location = new System.Drawing.Point(197, 324);
            this.label_tiles.Name = "label_tiles";
            this.label_tiles.Size = new System.Drawing.Size(68, 13);
            this.label_tiles.TabIndex = 8;
            this.label_tiles.Text = "Tileable area";
            // 
            // cutout1Length
            // 
            this.cutout1Length.Location = new System.Drawing.Point(288, 84);
            this.cutout1Length.Name = "cutout1Length";
            this.cutout1Length.Size = new System.Drawing.Size(100, 20);
            this.cutout1Length.TabIndex = 9;
            this.cutout1Length.Text = "0";
            // 
            // cutout1total
            // 
            this.cutout1total.Location = new System.Drawing.Point(144, 215);
            this.cutout1total.Name = "cutout1total";
            this.cutout1total.ReadOnly = true;
            this.cutout1total.Size = new System.Drawing.Size(100, 20);
            this.cutout1total.TabIndex = 10;
            // 
            // cutout2width
            // 
            this.cutout2width.Location = new System.Drawing.Point(487, 44);
            this.cutout2width.Name = "cutout2width";
            this.cutout2width.Size = new System.Drawing.Size(100, 20);
            this.cutout2width.TabIndex = 11;
            this.cutout2width.Text = "0";
            // 
            // cutout1Width
            // 
            this.cutout1Width.Location = new System.Drawing.Point(288, 44);
            this.cutout1Width.Name = "cutout1Width";
            this.cutout1Width.Size = new System.Drawing.Size(100, 20);
            this.cutout1Width.TabIndex = 12;
            this.cutout1Width.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "cutout1Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "cutout1Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cut Out Area 1 Total area";
            // 
            // cutout2length
            // 
            this.cutout2length.Location = new System.Drawing.Point(487, 84);
            this.cutout2length.Name = "cutout2length";
            this.cutout2length.Size = new System.Drawing.Size(100, 20);
            this.cutout2length.TabIndex = 16;
            this.cutout2length.Text = "0";
            // 
            // cutout2total
            // 
            this.cutout2total.Location = new System.Drawing.Point(144, 241);
            this.cutout2total.Name = "cutout2total";
            this.cutout2total.ReadOnly = true;
            this.cutout2total.Size = new System.Drawing.Size(100, 20);
            this.cutout2total.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "cutout2Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "cutout2length";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cut Out Area 2 Total area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(46, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Room values (cm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(368, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cut out values (cm)";
            // 
            // radio60
            // 
            this.radio60.AutoSize = true;
            this.radio60.Location = new System.Drawing.Point(15, 140);
            this.radio60.Name = "radio60";
            this.radio60.Size = new System.Drawing.Size(90, 17);
            this.radio60.TabIndex = 23;
            this.radio60.TabStop = true;
            this.radio60.Text = "60cm X 60cm";
            this.radio60.UseVisualStyleBackColor = true;
            // 
            // radio75
            // 
            this.radio75.AutoSize = true;
            this.radio75.Location = new System.Drawing.Point(15, 163);
            this.radio75.Name = "radio75";
            this.radio75.Size = new System.Drawing.Size(90, 17);
            this.radio75.TabIndex = 24;
            this.radio75.TabStop = true;
            this.radio75.Text = "75cm X 75cm";
            this.radio75.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tile Size";
            // 
            // TotalTileBox
            // 
            this.TotalTileBox.Location = new System.Drawing.Point(331, 351);
            this.TotalTileBox.Name = "TotalTileBox";
            this.TotalTileBox.ReadOnly = true;
            this.TotalTileBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTileBox.TabIndex = 26;
            // 
            // offcutbox
            // 
            this.offcutbox.Location = new System.Drawing.Point(331, 377);
            this.offcutbox.Name = "offcutbox";
            this.offcutbox.ReadOnly = true;
            this.offcutbox.Size = new System.Drawing.Size(100, 20);
            this.offcutbox.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(197, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total Tiles Needed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Off cuts";
            // 
            // edgingstripbox
            // 
            this.edgingstripbox.Location = new System.Drawing.Point(331, 403);
            this.edgingstripbox.Name = "edgingstripbox";
            this.edgingstripbox.ReadOnly = true;
            this.edgingstripbox.Size = new System.Drawing.Size(100, 20);
            this.edgingstripbox.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Edging Strip";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(359, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Input 0 if cutout is not used";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 440);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.edgingstripbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.offcutbox);
            this.Controls.Add(this.TotalTileBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radio75);
            this.Controls.Add(this.radio60);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cutout2total);
            this.Controls.Add(this.cutout2length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cutout1Width);
            this.Controls.Add(this.cutout2width);
            this.Controls.Add(this.cutout1total);
            this.Controls.Add(this.cutout1Length);
            this.Controls.Add(this.label_tiles);
            this.Controls.Add(this.label_area);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.tileableAreatxt);
            this.Controls.Add(this.Areatext);
            this.Controls.Add(this.widthbox);
            this.Controls.Add(this.lengthbox);
            this.Controls.Add(this.Calcuatebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcuatebutton;
        private System.Windows.Forms.TextBox lengthbox;
        private System.Windows.Forms.TextBox widthbox;
        private System.Windows.Forms.TextBox Areatext;
        private System.Windows.Forms.TextBox tileableAreatxt;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.Label label_tiles;
        private System.Windows.Forms.TextBox cutout1Length;
        private System.Windows.Forms.TextBox cutout1total;
        private System.Windows.Forms.TextBox cutout2width;
        private System.Windows.Forms.TextBox cutout1Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cutout2length;
        private System.Windows.Forms.TextBox cutout2total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radio60;
        private System.Windows.Forms.RadioButton radio75;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TotalTileBox;
        private System.Windows.Forms.TextBox offcutbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edgingstripbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

