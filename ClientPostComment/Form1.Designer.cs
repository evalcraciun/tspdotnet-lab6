namespace PostCommentWF
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
            this.components = new System.ComponentModel.Container();
            this.dgp = new System.Windows.Forms.DataGridView();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postCommentDataSet = new PostCommentWF.PostCommentDataSet();
            this.postCommentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new PostCommentWF.PostCommentDataSetTableAdapters.PostsTableAdapter();
            this.dgc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgp
            // 
            this.dgp.AutoGenerateColumns = false;
            this.dgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.domainDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgp.DataSource = this.postsBindingSource;
            this.dgp.Location = new System.Drawing.Point(24, 12);
            this.dgp.Name = "dgp";
            this.dgp.Size = new System.Drawing.Size(240, 150);
            this.dgp.TabIndex = 0;
            this.dgp.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgp_CellMouseClick);
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "PostId";
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            this.postIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // domainDataGridViewTextBoxColumn
            // 
            this.domainDataGridViewTextBoxColumn.DataPropertyName = "Domain";
            this.domainDataGridViewTextBoxColumn.HeaderText = "Domain";
            this.domainDataGridViewTextBoxColumn.Name = "domainDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.postCommentDataSet;
            // 
            // postCommentDataSet
            // 
            this.postCommentDataSet.DataSetName = "PostCommentDataSet";
            this.postCommentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postCommentDataSetBindingSource
            // 
            this.postCommentDataSetBindingSource.DataSource = this.postCommentDataSet;
            this.postCommentDataSetBindingSource.Position = 0;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // dgc
            // 
            this.dgc.AutoGenerateColumns = false;
            this.dgc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc.DataSource = this.postCommentDataSetBindingSource;
            this.dgc.Location = new System.Drawing.Point(320, 12);
            this.dgc.Name = "dgc";
            this.dgc.Size = new System.Drawing.Size(240, 150);
            this.dgc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgc);
            this.Controls.Add(this.dgp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgp;
        private PostCommentDataSet postCommentDataSet;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private PostCommentDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.BindingSource postCommentDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgc;
    }
}

