
namespace GoProRename
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonFolder = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TextBoxFolder = new System.Windows.Forms.TextBox();
            this.ButtonRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFolder
            // 
            this.ButtonFolder.BackColor = System.Drawing.Color.White;
            this.ButtonFolder.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFolder.Image")));
            this.ButtonFolder.Location = new System.Drawing.Point(369, 12);
            this.ButtonFolder.Name = "ButtonFolder";
            this.ButtonFolder.Size = new System.Drawing.Size(37, 30);
            this.ButtonFolder.TabIndex = 0;
            this.ButtonFolder.UseVisualStyleBackColor = false;
            this.ButtonFolder.Click += new System.EventHandler(this.ButtonFolder_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.RestoreDirectory = true;
            // 
            // TextBoxFolder
            // 
            this.TextBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFolder.Location = new System.Drawing.Point(12, 12);
            this.TextBoxFolder.MinimumSize = new System.Drawing.Size(200, 30);
            this.TextBoxFolder.Name = "TextBoxFolder";
            this.TextBoxFolder.Size = new System.Drawing.Size(351, 30);
            this.TextBoxFolder.TabIndex = 1;
            this.TextBoxFolder.TextChanged += new System.EventHandler(this.TextBoxFolder_TextChanged);
            // 
            // ButtonRename
            // 
            this.ButtonRename.BackColor = System.Drawing.Color.White;
            this.ButtonRename.Enabled = false;
            this.ButtonRename.Image = global::GoProRename.Properties.Resources._2;
            this.ButtonRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRename.Location = new System.Drawing.Point(12, 55);
            this.ButtonRename.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRename.Name = "ButtonRename";
            this.ButtonRename.Padding = new System.Windows.Forms.Padding(130, 0, 130, 0);
            this.ButtonRename.Size = new System.Drawing.Size(394, 30);
            this.ButtonRename.TabIndex = 2;
            this.ButtonRename.Text = "Process Folder";
            this.ButtonRename.UseVisualStyleBackColor = false;
            this.ButtonRename.Click += new System.EventHandler(this.ButtonRename_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 97);
            this.Controls.Add(this.ButtonRename);
            this.Controls.Add(this.TextBoxFolder);
            this.Controls.Add(this.ButtonFolder);
            this.Name = "FormMain";
            this.Text = "RenameGoPro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFolder;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TextBox TextBoxFolder;
        private System.Windows.Forms.Button ButtonRename;
    }
}

