using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserAuthorisation
    {
        public int UserAuthorisationId { get; set; }
        public int UserId { get; set; }
        public int AuthoriserUserId { get; set; }
        public string Email { get; set; }
        public bool Primary { get; set; }
    }
}
