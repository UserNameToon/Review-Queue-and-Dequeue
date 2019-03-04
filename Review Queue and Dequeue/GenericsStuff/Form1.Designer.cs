namespace GenericsStuff
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
            this.UI_BT_GEN = new System.Windows.Forms.Button();
            this.UI_BT_SHU = new System.Windows.Forms.Button();
            this.UI_BT_EDQ = new System.Windows.Forms.Button();
            this.UI_LV_WG = new System.Windows.Forms.ListView();
            this.LV_WG_Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_WG_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // UI_BT_GEN
            // 
            this.UI_BT_GEN.Location = new System.Drawing.Point(13, 13);
            this.UI_BT_GEN.Name = "UI_BT_GEN";
            this.UI_BT_GEN.Size = new System.Drawing.Size(109, 23);
            this.UI_BT_GEN.TabIndex = 0;
            this.UI_BT_GEN.Text = "Generate List";
            this.UI_BT_GEN.UseVisualStyleBackColor = true;
            this.UI_BT_GEN.Click += new System.EventHandler(this.UI_BT_GEN_Click);
            // 
            // UI_BT_SHU
            // 
            this.UI_BT_SHU.Location = new System.Drawing.Point(128, 12);
            this.UI_BT_SHU.Name = "UI_BT_SHU";
            this.UI_BT_SHU.Size = new System.Drawing.Size(138, 23);
            this.UI_BT_SHU.TabIndex = 1;
            this.UI_BT_SHU.Text = "Shuffle List";
            this.UI_BT_SHU.UseVisualStyleBackColor = true;
            this.UI_BT_SHU.Click += new System.EventHandler(this.UI_BT_SHU_Click);
            // 
            // UI_BT_EDQ
            // 
            this.UI_BT_EDQ.Location = new System.Drawing.Point(272, 12);
            this.UI_BT_EDQ.Name = "UI_BT_EDQ";
            this.UI_BT_EDQ.Size = new System.Drawing.Size(165, 23);
            this.UI_BT_EDQ.TabIndex = 2;
            this.UI_BT_EDQ.Text = "Enq/Deq Priority";
            this.UI_BT_EDQ.UseVisualStyleBackColor = true;
            this.UI_BT_EDQ.Click += new System.EventHandler(this.UI_BT_EDQ_Click);
            // 
            // UI_LV_WG
            // 
            this.UI_LV_WG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LV_WG_Priority,
            this.LV_WG_Name});
            this.UI_LV_WG.Location = new System.Drawing.Point(13, 43);
            this.UI_LV_WG.Name = "UI_LV_WG";
            this.UI_LV_WG.Size = new System.Drawing.Size(424, 525);
            this.UI_LV_WG.TabIndex = 3;
            this.UI_LV_WG.UseCompatibleStateImageBehavior = false;
            this.UI_LV_WG.View = System.Windows.Forms.View.Details;
            // 
            // LV_WG_Priority
            // 
            this.LV_WG_Priority.Text = "Priority";
            this.LV_WG_Priority.Width = 84;
            // 
            // LV_WG_Name
            // 
            this.LV_WG_Name.Text = "Name";
            this.LV_WG_Name.Width = 312;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 580);
            this.Controls.Add(this.UI_LV_WG);
            this.Controls.Add(this.UI_BT_EDQ);
            this.Controls.Add(this.UI_BT_SHU);
            this.Controls.Add(this.UI_BT_GEN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_BT_GEN;
        private System.Windows.Forms.Button UI_BT_SHU;
        private System.Windows.Forms.Button UI_BT_EDQ;
        private System.Windows.Forms.ListView UI_LV_WG;
        private System.Windows.Forms.ColumnHeader LV_WG_Priority;
        private System.Windows.Forms.ColumnHeader LV_WG_Name;
    }
}

