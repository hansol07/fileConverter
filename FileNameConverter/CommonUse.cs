using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameConverter
{
    public static class CommonUse
    {
        public static List<ConvertStr> strList = new List<ConvertStr>();
        public static string jsonPath = Path.Combine(Application.StartupPath, "변환모음.abc");
    }
}
