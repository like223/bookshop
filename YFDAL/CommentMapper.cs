using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YF.MsSqlHelper;
using YFModel;

namespace YFDAL
{
    public class CommentMapper
    {
        public static int insert(Comment comment)
        {
            string sql= "insert into t_comment(userid,comment,bookid,username,bookname) " +
                "values("+comment.userid+",'"+comment.comment+"',"+comment.bookid+","+"'"+comment.username+"'"+","+"'"+comment.bookname+"')";
            int res=YFMsSqlHelper.ExecuteSql(sql);
            return res;
        }
    }
}
