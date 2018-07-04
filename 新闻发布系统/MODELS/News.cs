using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class News
    {
        public int newsId { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public string category { get; set; }//新闻类别

        public string type { get; set; }//国内新闻或国际新闻

        public string releaseDate { get; set; }//发布日期
    }
}
