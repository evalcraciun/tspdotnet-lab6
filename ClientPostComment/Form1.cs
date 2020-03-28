using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostComment;


namespace PostCommentWF
{
    public partial class Form1 : Form
    {
        List<Post> posts = new List<Post>();
        public Form1()
        {
            InitializeComponent();
        }

        // Handler pentru evenimentul Load al ferestrei principale
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postCommentDataSet.Posts' table. You can move, or remove it, as needed.
            this.postsTableAdapter.Fill(this.postCommentDataSet.Posts);
            // posts = LoadPosts().ToList<Post>();
            dgp.DataSource = posts;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgp.DataSource = posts[0].Comments;
        }

        //private static PostComment.Post[] LoadPosts()
        //{
        //    PostCommentClient pc = new PostCommentClient();
        //    PostComment.Post[] p = pc.GetPosts();
        //    return p;
        //}

        // Handler pentru evenimentul CellMouseClick din DatagridView numit dgp
        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            dgc.DataSource = null;
            dgc.DataSource = posts[e.RowIndex].Comments;
        }
    }
}
