namespace SQLiteWinforms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtBoxName = new TextBox();
            txtBoxAge = new TextBox();
            txtBoxCity = new TextBox();
            btnCreate = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.Dock = DockStyle.Bottom;
            txtBoxName.Location = new Point(0, 427);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "Имя";
            txtBoxName.Size = new Size(595, 23);
            txtBoxName.TabIndex = 0;
            // 
            // txtBoxAge
            // 
            txtBoxAge.Dock = DockStyle.Bottom;
            txtBoxAge.Location = new Point(0, 404);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.PlaceholderText = "Возраст";
            txtBoxAge.Size = new Size(595, 23);
            txtBoxAge.TabIndex = 1;
            // 
            // txtBoxCity
            // 
            txtBoxCity.Dock = DockStyle.Bottom;
            txtBoxCity.Location = new Point(0, 381);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.PlaceholderText = "Город проживания";
            txtBoxCity.Size = new Size(595, 23);
            txtBoxCity.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Dock = DockStyle.Bottom;
            btnCreate.Location = new Point(0, 358);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(595, 23);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Bottom;
            btnRemove.Location = new Point(0, 335);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(595, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Bottom;
            btnUpdate.Location = new Point(0, 312);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(595, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(595, 222);
            dataGridView1.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnCreate);
            Controls.Add(txtBoxCity);
            Controls.Add(txtBoxAge);
            Controls.Add(txtBoxName);
            Name = "MainForm";
            Text = "SQLite Editor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtBoxName;
        private TextBox txtBoxAge;
        private TextBox txtBoxCity;
        private Button btnCreate;
        private Button btnRemove;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}
