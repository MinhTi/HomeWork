using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace _02_TreeView_And_ValueConverters
{
    
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {  
            var path = "D:\\";
        
            if (path == null)
                return null;
   
            var name = MainWindow.GetFileFolderName(path);

            var image = "image/img01.jpg";

            if (string.IsNullOrEmpty(name))
                image = "image/img02.jpg";
            else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
                image = "image/img03.jpg";

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
