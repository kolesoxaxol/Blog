﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public UserModel User { get; set; }
        public ArticleModel Article { get; set; }
    }
}