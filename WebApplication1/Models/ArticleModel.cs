﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public UserModel User { get; set; }
        public CategoryModel Category { get; set; }

        public IEnumerable<CommentModel> Comments { get; set; }

    }
}