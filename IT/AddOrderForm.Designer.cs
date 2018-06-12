namespace IT
{
    partial class AddOrderForm
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
            this.textBox_tech = new System.Windows.Forms.TextBox();
            this.textBox_client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_tech
            // 
            this.textBox_tech.Location = new System.Drawing.Point(158, 31);
            this.textBox_tech.Name = "textBox_tech";
            this.textBox_tech.Size = new System.Drawing.Size(100, 22);
            this.textBox_tech.TabIndex = 0;
            // 
            // textBox_client
            // 
            this.textBox_client.Location = new System.Drawing.Point(158, 76);
            this.textBox_client.Name = "textBox_client";
            this.textBox_client.Size = new System.Drawing.Size(100, 22);
            this.textBox_client.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Техника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Клиент";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(158, 139);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 39);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 209);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_client);
            this.Controls.Add(this.textBox_tech);
            this.Name = "AddOrder";
            this.Text = "Добавить заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tech;
        private System.Windows.Forms.TextBox textBox_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
    }
}