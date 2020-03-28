namespace ClientPostComment
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
            this.postCommentDataSet = new ClientPostComment.PostCommentDataSet();
            this.postsTableAdapter = new ClientPostComment.PostCommentDataSetTableAdapters.PostsTableAdapter();
            this.dgc = new System.Windows.Forms.DataGridView();
            this.commentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postPostIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postCommentDataSet1 = new ClientPostComment.PostCommentDataSet1();
            this.commentsTableAdapter = new ClientPostComment.PostCommentDataSet1TableAdapters.CommentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSet1)).BeginInit();
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
            this.dgp.Location = new System.Drawing.Point(85, 56);
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
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // dgc
            // 
            this.dgc.AutoGenerateColumns = false;
            this.dgc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.postPostIdDataGridViewTextBoxColumn});
            this.dgc.DataSource = this.commentsBindingSource;
            this.dgc.Location = new System.Drawing.Point(363, 56);
            this.dgc.Name = "dgc";
            this.dgc.Size = new System.Drawing.Size(240, 150);
            this.dgc.TabIndex = 1;
            // 
            // commentIdDataGridViewTextBoxColumn
            // 
            this.commentIdDataGridViewTextBoxColumn.DataPropertyName = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.HeaderText = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.Name = "commentIdDataGridViewTextBoxColumn";
            this.commentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // postPostIdDataGridViewTextBoxColumn
            // 
            this.postPostIdDataGridViewTextBoxColumn.DataPropertyName = "PostPostId";
            this.postPostIdDataGridViewTextBoxColumn.HeaderText = "PostPostId";
            this.postPostIdDataGridViewTextBoxColumn.Name = "postPostIdDataGridViewTextBoxColumn";
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postCommentDataSet1;
            // 
            // postCommentDataSet1
            // 
            this.postCommentDataSet1.DataSetName = "PostCommentDataSet1";
            this.postCommentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCommentDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgp;
        private PostCommentDataSet postCommentDataSet;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private PostCommentDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgc;
        private PostCommentDataSet1 postCommentDataSet1;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private PostCommentDataSet1TableAdapters.CommentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postPostIdDataGridViewTextBoxColumn;
    }
}

