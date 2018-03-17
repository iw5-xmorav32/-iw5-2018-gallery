using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xmorav32.Models.Base;

namespace xmorav32.Models
{
    public class Photos : IBaseModel
    {
        public DateTime Date { get; set; }
        public string Format { get; set; }
        public string Resolution { get; set; }
        public string Note { get; set; }
        public Guid IdOfAlbum { get; set; }
    }
}
