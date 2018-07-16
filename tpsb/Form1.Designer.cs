namespace tpsb
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_insert = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.btn_find = new System.Windows.Forms.ToolStripButton();
            this.btn_update = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "文本识别",
            "身份证识别",
            "银行卡识别"});
            this.comboBox1.Location = new System.Drawing.Point(12, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 29);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(187, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "API_KEY:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(265, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(508, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(395, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "SECRET_KEY:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_insert,
            this.btn_delete,
            this.btn_find,
            this.btn_update});
            this.toolStrip1.Location = new System.Drawing.Point(0, 447);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_insert
            // 
            this.btn_insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
            this.btn_insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(41, 24);
            this.btn_insert.Text = "增加";
            // 
            // btn_delete
            // 
            this.btn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(41, 24);
            this.btn_delete.Text = "删除";
            // 
            // btn_find
            // 
            this.btn_find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_find.Image = ((System.Drawing.Image)(resources.GetObject("btn_find.Image")));
            this.btn_find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(41, 24);
            this.btn_find.Text = "查询";
            // 
            // btn_update
            // 
            this.btn_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(41, 24);
            this.btn_update.Text = "修改";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(709, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "选择或者拖动文件夹、文件";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xuhao,
            this.text});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(622, 409);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.file_name});
            this.dataGridView2.Location = new System.Drawing.Point(671, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(307, 409);
            this.dataGridView2.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // file_name
            // 
            this.file_name.HeaderText = "文件列表";
            this.file_name.Name = "file_name";
            this.file_name.Width = 200;
            // 
            // xuhao
            // 
            this.xuhao.HeaderText = "序号";
            this.xuhao.Name = "xuhao";
            this.xuhao.Width = 60;
            // 
            // text
            // 
            this.text.HeaderText = "内容";
            this.text.Name = "text";
            this.text.Width = 515;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "图片识别";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_insert;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.ToolStripButton btn_find;
        private System.Windows.Forms.ToolStripButton btn_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_name;
    }
}

