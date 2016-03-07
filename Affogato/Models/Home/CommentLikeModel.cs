using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Affogato.Models.Home
{
    public class CommentLikeModel
    {
        [HiddenInput(DisplayValue = false)]
        public string PostId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Index { get; set; }
    }
}
