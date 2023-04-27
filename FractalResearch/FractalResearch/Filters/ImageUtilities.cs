using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalResearch.Filters
{
    public class ImageUtilities
    {
        // return stats on an image as string

        // count number of black pixels
        public static int CountBlackPixels(Bitmap bitmap)
        {
            int count = 0;
            for(var i = 0; i < bitmap.Width; i++)
            {
                for(var j = 0; j < bitmap.Height; j++)
                {
                    var pixel = bitmap.GetPixel(i, j);
                    if(pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
