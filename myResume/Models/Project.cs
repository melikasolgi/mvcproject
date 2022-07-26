﻿using System.Collections.Generic;

namespace myResume.Models
{
    public class Project : ProjectBase
    {
    }
    public class Article : ArticleBase
    {
    }
    public class IndexModel
    {
        public List<Project> Projects { get; set; }
        public List<Article> Articles { get; set; }
    }
}