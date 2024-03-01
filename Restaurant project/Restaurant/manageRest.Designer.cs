namespace Restaurant
{
    partial class manageRest
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.tb_calories = new System.Windows.Forms.TextBox();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_additm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_deleteitm = new System.Windows.Forms.Button();
            this.tb_ord_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 165;
            this.label1.Text = "Manage Restaurant";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(597, 432);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 41);
            this.btn_delete.TabIndex = 164;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.Location = new System.Drawing.Point(442, 204);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 39);
            this.btn_search.TabIndex = 163;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(219, 204);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(190, 39);
            this.tb_search.TabIndex = 162;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(62, 219);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(102, 24);
            this.lbl_id.TabIndex = 161;
            this.lbl_id.Text = "Item Name";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(731, 434);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 39);
            this.btn_add.TabIndex = 159;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(219, 393);
            this.tb_cost.Multiline = true;
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(190, 37);
            this.tb_cost.TabIndex = 158;
            // 
            // tb_calories
            // 
            this.tb_calories.Location = new System.Drawing.Point(661, 379);
            this.tb_calories.Multiline = true;
            this.tb_calories.Name = "tb_calories";
            this.tb_calories.Size = new System.Drawing.Size(212, 31);
            this.tb_calories.TabIndex = 157;
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(661, 322);
            this.tb_size.Multiline = true;
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(212, 33);
            this.tb_size.TabIndex = 156;
            this.tb_size.TextChanged += new System.EventHandler(this.tb_size_TextChanged);
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(221, 338);
            this.tb_type.Multiline = true;
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(190, 37);
            this.tb_type.TabIndex = 155;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(221, 284);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(190, 37);
            this.tb_name.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(91, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 153;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(521, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 152;
            this.label4.Text = "Calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(521, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 151;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(87, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 150;
            this.label2.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(91, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 149;
            this.label6.Text = "Name";
            // 
            // btn_additm
            // 
            this.btn_additm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_additm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_additm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_additm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_additm.Location = new System.Drawing.Point(124, 89);
            this.btn_additm.Name = "btn_additm";
            this.btn_additm.Size = new System.Drawing.Size(171, 63);
            this.btn_additm.TabIndex = 148;
            this.btn_additm.Text = "Add new Item";
            this.btn_additm.UseVisualStyleBackColor = false;
            this.btn_additm.Click += new System.EventHandler(this.Btn_additm_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Ivory;
            this.btn_back.Location = new System.Drawing.Point(66, 479);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(111, 51);
            this.btn_back.TabIndex = 147;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_deleteitm
            // 
            this.btn_deleteitm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleteitm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteitm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteitm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteitm.Location = new System.Drawing.Point(388, 89);
            this.btn_deleteitm.Name = "btn_deleteitm";
            this.btn_deleteitm.Size = new System.Drawing.Size(171, 63);
            this.btn_deleteitm.TabIndex = 146;
            this.btn_deleteitm.Text = "Delete Item";
            this.btn_deleteitm.UseVisualStyleBackColor = false;
            this.btn_deleteitm.Click += new System.EventHandler(this.Btn_deleteitm_Click);
            // 
            // tb_ord_num
            // 
            this.tb_ord_num.Location = new System.Drawing.Point(661, 272);
            this.tb_ord_num.Multiline = true;
            this.tb_ord_num.Name = "tb_ord_num";
            this.tb_ord_num.Size = new System.Drawing.Size(212, 37);
            this.tb_ord_num.TabIndex = 167;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(485, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 166;
            this.label7.Text = "Ordrer_number";
            // 
            // manageRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 557);
            this.Controls.Add(this.tb_ord_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.tb_calories);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_additm);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_deleteitm);
            this.Name = "manageRest";
            this.Text = "manageRest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.manageRest_FormClosed);
            this.Load += new System.EventHandler(this.manageRest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.TextBox tb_calories;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_additm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_deleteitm;
        private System.Windows.Forms.TextBox tb_ord_num;
        private System.Windows.Forms.Label label7;
    }
}