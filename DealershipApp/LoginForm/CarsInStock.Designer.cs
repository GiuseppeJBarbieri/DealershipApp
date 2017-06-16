namespace LoginForm.Views
{
    partial class CarsInStock
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carInventory = new LoginForm.CarInventory();
            this.carInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_dbTableAdapter = new LoginForm.CarInventoryTableAdapters.car_dbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.carInventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(224, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // carInventory
            // 
            this.carInventory.DataSetName = "CarInventory";
            this.carInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carInventoryBindingSource
            // 
            this.carInventoryBindingSource.DataSource = this.carInventory;
            this.carInventoryBindingSource.Position = 0;
            // 
            // cardbBindingSource
            // 
            this.cardbBindingSource.DataMember = "car_db";
            this.cardbBindingSource.DataSource = this.carInventory;
            // 
            // car_dbTableAdapter
            // 
            this.car_dbTableAdapter.ClearBeforeFill = true;
            // 
            // CarsInStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 362);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CarsInStock";
            this.Text = "CarsInStock";
            this.Load += new System.EventHandler(this.CarsInStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carInventoryBindingSource;
     
        private System.Windows.Forms.BindingSource cardbBindingSource;
        
    }
}