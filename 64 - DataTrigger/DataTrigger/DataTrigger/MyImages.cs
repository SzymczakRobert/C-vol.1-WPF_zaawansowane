using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTrigger
{
    class MyImages
    {
        public string pathToImage { get; set; }
        public string nameOfImage { get; set; }
        public string isFound { get; set; }

        public MyImages()
        {
            this.pathToImage = "zabka.jpg";
            this.nameOfImage = "Logo";

        }
    }
}
