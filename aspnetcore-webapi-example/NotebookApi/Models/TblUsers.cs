using System;
using System.Collections.Generic;

namespace NotebookApi.Models
{
    public partial class TblUsers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
