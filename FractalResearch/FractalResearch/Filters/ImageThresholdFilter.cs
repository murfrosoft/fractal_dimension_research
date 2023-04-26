using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalResearch.Filters
{
    public static class ImageThresholdFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bmp">Imgae to apply filter</param>
        /// <param name="threshold">A value from 0-255 </param>
        /// <param name="black">A bool indicating whether pixel should flip black or white if over threshold. Default is black.</param>
        /// <returns></returns>
        public static Bitmap Filter(Bitmap bmp, byte threshold, bool black = true)
        {
            Bitmap bmpFiltered = new Bitmap(bmp.Width, bmp.Height);

            for(int i  = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++ )
                {
                    Color pixel = bmp.GetPixel(i, j);
                    if(AverageIntensity(pixel) < threshold)
                    {
                        if (black)
                        {
                            bmpFiltered.SetPixel(i, j, Color.White);
                        }
                        else
                        {
                            bmpFiltered.SetPixel(i, j, Color.Black);
                        }                        
                    }
                    else
                    {
                        if (black)
                        {
                            bmpFiltered.SetPixel(i, j, Color.Black);
                        }
                        else
                        {
                            bmpFiltered.SetPixel(i, j, Color.White);
                        }
                    }           
                }
            }
            return bmpFiltered;
        }

        private static byte AverageIntensity(Color color)
        {
            return (byte)((color.R + color.G + color.B) / 3);
        }
    }
}
