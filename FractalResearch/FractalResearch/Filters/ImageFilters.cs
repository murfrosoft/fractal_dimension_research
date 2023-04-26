using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalResearch.Filters
{
    public static class ImageFilters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bmp">Imgae to apply filter</param>
        /// <param name="threshold">A value from 0-255 </param>
        /// <param name="black">A bool indicating whether pixel should flip black or white if under threshold. Default is black.</param>
        /// <returns></returns>
        public static Bitmap ThresholdFilter(Bitmap bmp, byte threshold, bool black = true)
        {
            Bitmap bmpFiltered = new Bitmap(bmp.Width, bmp.Height);

            for(int i  = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++ )
                {
                    Color pixel = bmp.GetPixel(i, j);
                    if(AverageIntensity(pixel) > threshold)
                    {
                        Color replace = black ? Color.White : Color.Black;
                        bmpFiltered.SetPixel(i, j, replace);                      
                    }
                    else
                    {
                        Color replace = black ? Color.Black : Color.White;
                        bmpFiltered.SetPixel(i, j, replace);
                    }           
                }
            }
            return bmpFiltered;
        }

        public static Bitmap EdgeFilter(Bitmap bmp, byte threshold, bool black = true)
        {
            Bitmap bmpFiltered = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    var thisIntensity = AverageIntensity(bmp.GetPixel(i, j));
                    if( i == bmp.Width - 1 && j == bmp.Height - 1 )
                    {
                        // Last Pixel edge case
                        bmpFiltered.SetPixel(i, j, bmpFiltered.GetPixel(i - 1, j));                        
                    }
                    else if( i == bmp.Width - 1 )
                    {
                        // Last column edge case : compare with bottom-neighbor-intensity
                        var bni = AverageIntensity(bmp.GetPixel(i, j + 1));
                        if( thisIntensity > bni + threshold || thisIntensity < bni - threshold )
                        {
                            Color replace = black ? Color.Black : Color.White;
                            bmpFiltered.SetPixel(i, j, replace);
                        }
                        else
                        {
                            Color replace = black ? Color.White : Color.Black;
                            bmpFiltered.SetPixel(i, j, replace);
                        }
                    }
                    else if( j == bmp.Height - 1 )
                    {
                        // Last row edge case : compare with right-neighbor-intensity
                        var rni = AverageIntensity(bmp.GetPixel(i+1, j));
                        if (thisIntensity > rni + threshold || thisIntensity < rni - threshold)
                        {
                            Color replace = black ? Color.Black : Color.White;
                            bmpFiltered.SetPixel(i, j, replace);
                        }
                        else
                        {
                            Color replace = black ? Color.White : Color.Black;
                            bmpFiltered.SetPixel(i, j, replace);
                        }
                    }
                    else
                    {
                        // Everyone else: compare with bottom and right-neighbor-intensities
                        var bni = AverageIntensity(bmp.GetPixel(i, j + 1));
                        var rni = AverageIntensity(bmp.GetPixel(i + 1, j));
                        if (thisIntensity > rni + threshold || thisIntensity < rni - threshold || 
                            thisIntensity > bni + threshold || thisIntensity < bni - threshold)
                        {
                            Color replace = black ? Color.Black : Color.White;
                            bmpFiltered.SetPixel(i, j, replace);
                        }
                        else
                        {
                            Color replace = black ? Color.White : Color.Black;
                            bmpFiltered.SetPixel(i, j, replace);
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
