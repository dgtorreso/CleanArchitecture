using System;
using System.Collections.Generic;

namespace CleanArchitecture.Core.DTOs
{
    public class ChartBarDTO
    {
        public List<string> labels { get; set; }
        public List<Dataset> datasets { get; set; }


        public static string getRandomColor()
        {
            var colors = new[] {"#065535","#133337","#000000","#ffc0cb","#ffffff","#ffe4e1","#008080","#ff0000",
                            "#ffd700","#00ffff","#666666","#40e0d0","#ff7373","#e6e6fa","#d3ffce","#ffa500","#0000ff","#f0f8ff",
                            "#b0e0e6","#c6e2ff","#7fffd4","#faebd7","#fa8072","#eeeeee","#800080","#ffb6c1","#800000",
                            "#cccccc","#003366","#ffff00","#00ff00","#c0c0c0","#333333","#ffc3a0","#20b2aa","#f08080","#fff68f",
                            "#66cdaa","#f6546a","#c39797","#ff6666","#468499","#ffdab9","#00ced1","#ff00ff","#ff7f50","#bada55",
                            "#101010","#660066","#008000","#088da5","#8b0000","#c0d6e4","#0e2f44","#f5f5f5","#afeeee","#990000",
                            "#808080","#ffff66","#dddddd","#b4eeb4","#daa520","#cbbeb5","#b6fcd5","#f5f5dc","#8a2be2","#00ff7f",
                            "#81d8d0","#000080","#ccff00","#a0db8e","#ff4040","#3399ff","#66cccc","#6897bb","#794044","#cc0000",
                            "#999999","#3b5998","#ff4444","#fef65b","#0099cc","#ff1493","#191970",
            };
            var rand = new Random();
            return colors[rand.Next(colors.Length)];
        }
    }
    public class DatasetPie
    {
        public List<float> data { get; set; }
        public List<string> backgroundColor { get; set; }
    }

    public class ChartPieDTO
    {
        public List<DatasetPie> datasets { get; set; }
        public List<string> labels { get; set; }
    }

    public class Dataset
    {
        public string label { get; set; }
        public string backgroundColor { get => ChartBarDTO.getRandomColor(); }
        public List<float> data { get; set; }

    }
}
