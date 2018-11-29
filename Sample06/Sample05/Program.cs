using Dapper;
using Sample05.Model;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Sample05
{
    class Program
    {
        static void Main(string[] args)
        {
            //var content = new Content
            //{
            //    Title = "标题1",
            //    Contents = "内容1",

            //};
            using (var conn = new SqlConnection("Data Source=.\\sqlserver;User ID=sa;Password=123456;Initial Catalog=Sample05;Pooling=true;Max Pool Size=100;"))
            {
                //                string sql_insert = @"INSERT INTO [Content]
                //                (Title, [Contents], Status, Add_time, Modify_time)
                //VALUES   (@title,@contents,@status,@add_time,@modify_time)";
                //                var result = conn.Execute(sql_insert, content);
                //                Console.WriteLine($"test_insert：插入了{result}条数据！");
                //                 sql_insert = @"select * from [dbo].[content] where id in @ids";
                //                 var result1 = conn.Query<Content>(sql_insert, new { ids = new int[] { 1, 2 } } );
                //                Console.WriteLine($"test_select_one：查到的数据为："+result1);

                string sql_insert = @"select * from comment where content_id=@id;select * from content where id=@id;
";
                using (var result = conn.QueryMultiple(sql_insert, new { id = 5 }))
                {
                    var contents = result.ReadFirstOrDefault<ContentWithComment>();
                    contents.Comments = result.Read<Comment>();
                    Console.WriteLine($"test_select_content_with_comment:内容5的评论数量{contents.Comments.Count()}");
                }

                Console.ReadKey();
            }
        }
    }
}
