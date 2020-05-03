using System;
using System.Collections.Generic;

namespace NotebookApi.Models
{
    public partial class TblNotes
    {
        public int NoteId { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }
    }
}
