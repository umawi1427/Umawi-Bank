namespace Umawi_Bank
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMessages;

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
            this.tableLayoutPanelMessages = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMessages
            // 
            this.tableLayoutPanelMessages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMessages.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMessages.Name = "tableLayoutPanelMessages";
            this.tableLayoutPanelMessages.Size = new System.Drawing.Size(2688, 703);
            this.tableLayoutPanelMessages.TabIndex = 0;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2688, 703);
            this.Controls.Add(this.tableLayoutPanelMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }
    }
}