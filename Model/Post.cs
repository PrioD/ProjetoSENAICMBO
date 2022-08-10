using System;
using System.Collections.Generic;

namespace ProjetoSENAI.Model
{
    public partial class Post
    {
        public int Id { get; set; }
        public int? Publicador { get; set; }
        public string Conteudo { get; set; } = null!;
        public DateTime Momento { get; set; }

        public virtual Usuario? PublicadorNavigation { get; set; }
    }
}
