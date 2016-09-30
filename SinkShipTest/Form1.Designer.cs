namespace SinkShipTest
{
    partial class Play
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
            this.PlayerOneGrid = new System.Windows.Forms.DataGridView();
            this.PlayerTwoGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerOneGrid
            // 
            this.PlayerOneGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.PlayerOneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerOneGrid.Location = new System.Drawing.Point(0, 0);
            this.PlayerOneGrid.Name = "PlayerOneGrid";
            this.PlayerOneGrid.Size = new System.Drawing.Size(305, 289);
            this.PlayerOneGrid.TabIndex = 0;
            this.PlayerOneGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerOneGrid_CellContentClick);
            // 
            // PlayerTwoGrid
            // 
            this.PlayerTwoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.PlayerTwoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerTwoGrid.Location = new System.Drawing.Point(477, 0);
            this.PlayerTwoGrid.Name = "PlayerTwoGrid";
            this.PlayerTwoGrid.Size = new System.Drawing.Size(305, 289);
            this.PlayerTwoGrid.TabIndex = 1;
            this.PlayerTwoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerTwoGrid_CellContentClick);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.PlayerTwoGrid);
            this.Controls.Add(this.PlayerOneGrid);
            this.Name = "Play";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerOneGrid;
        private System.Windows.Forms.DataGridView PlayerTwoGrid;
    }
}

