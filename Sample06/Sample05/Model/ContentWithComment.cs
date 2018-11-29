﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample05.Model
{
    class ContentWithComment
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Contents { get; set; }

        // public string content { get; set; }
        /// <summary>
        /// 状态 1正常 0删除
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Add_time { get; set; } = DateTime.Now;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? Modify_time { get; set; }

        /// <summary>
        /// 文章评论
        /// </summary>
        public IEnumerable<Comment> Comments { get; set; }
    }
}
