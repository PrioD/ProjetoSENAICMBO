using System;
using System.Collections.Generic;

namespace ProjetoSENAI.Model
{
    public partial class Post
    {
        public int Id { get; set; }
        public int? Publicante { get; set; }

        public virtual Usuario? PublicanteNavigation { get; set; }
    }
}
