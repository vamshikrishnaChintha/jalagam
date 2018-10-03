using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    #region[Directive]
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    #endregion[Directive]

    /// <summary>
    /// This class is used to compress the image to
    /// provided size
    /// </summary>
    public class ImageCompress
    {
        #region[PrivateData]
        private static volatile ImageCompress imageCompress;
        private Bitmap bitmap;
        private int width;
        private int height;
        private Image img;
        #endregion[Privatedata]

        #region[Constructor]
        /// <summary>
        /// It is used to restrict to create the instance of the      ImageCompress
        /// </summary>
        private ImageCompress()
        {
        }
        #endregion[Constructor]

        #region[Poperties]
        /// <summary>
        /// Gets ImageCompress object
        /// </summary>
        public static ImageCompress GetImageCompressObject
        {
            get
            {
                if (imageCompress == null)
                {
                    imageCompress = new ImageCompress();
                }
                return imageCompress;
            }
        }
        public class CommonConstant
        {
            public const string JPEG = ".jpeg";
            public const string PNG = ".png";
            public const string JPG = ".jpg";
            public const string BTM = ".btm";
        }
        /// <summary>
        /// Gets or sets Width
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// Gets or sets Width
        /// </summary>
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>
        /// Gets or sets Image
        /// </summary>
        public Bitmap GetImage
        {
            get { return bitmap; }
            set { bitmap = value; }
        }
        #endregion[Poperties]

        #region[PublicFunction]
        /// <summary>
        /// This function is used to save the image
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="path"></param>
        public void Save(string fileName, string path)
        {
            if (ISValidFileType(fileName))
            {
                string pathaname = path + @"\" + fileName;
                save(pathaname, 60);
            }
        }
        #endregion[PublicFunction]

        #region[PrivateData]
        /// <summary>
        /// This function is use to compress the image to
        /// predefine size
        /// </summary>
        /// <returns>return bitmap in compress size</returns>
        private Image CompressImage()
        {
            if (GetImage != null)
            {
                Width = (Width == 0) ? GetImage.Width : Width;
                Height = (Height == 0) ? GetImage.Height : Height;
                Bitmap newBitmap = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
                newBitmap = bitmap;
                newBitmap.SetResolution(80, 80);
                return newBitmap.GetThumbnailImage(Width, Height, null, IntPtr.Zero);
            }
            else
            {
                throw new Exception("Please provide bitmap");
            }
        }

        /// <summary>
        /// This function is used to check the file Type
        /// </summary>
        /// <param name="fileName">String data type:contain the file name</param>
        /// <returns>true or false on the file extention</returns>
        private bool ISValidFileType(string fileName)
        {
            bool isValidExt = false;
            string fileExt = Path.GetExtension(fileName);
            switch (fileExt.ToLower())
            {
                case CommonConstant.JPEG:
                case CommonConstant.BTM:
                case CommonConstant.JPG:
                case CommonConstant.PNG:
                    isValidExt = true;
                    break;
            }
            return isValidExt;
        }

        /// <summary>
        /// This function is used to get the imageCode info
        /// on the basis of mimeType
        /// </summary>
        /// <param name="mimeType">string data type</param>
        /// <returns>ImageCodecInfo data type</returns>
        private ImageCodecInfo GetImageCoeInfo(string mimeType)
        {
            ImageCodecInfo[] codes = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].MimeType == mimeType)
                {
                    return codes[i];
                }
            }
            return null;
        }

        /// <summary>
        /// this function is used to save the image into a
        /// given path
        /// </summary>
        /// <param name="path">string data type</param>
        /// <param name="quality">int data type</param>
        private void save(string path, int quality)
        {
            img = CompressImage();
            ////Setting the quality of the picture
            EncoderParameter qualityParam =
                new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            ////Seting the format to save
            ImageCodecInfo imageCodec = GetImageCoeInfo("image/jpeg");
            ////Used to contain the poarameters of the quality
            EncoderParameters parameters = new EncoderParameters(1);
            parameters.Param[0] = qualityParam;
            ////Used to save the image to a  given path
            img.Save(path, imageCodec, parameters);
        }

        public static void CompressImage(Image imgToResize, string imageName)
        {
            // Get a bitmap.
            Bitmap bmp1 = new Bitmap(imgToResize,new Size(600,600));
            

            ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder,
                75L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            var fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/Compressed/"), imageName + ".jpeg");
            bmp1.Save(fileSavePath, jgpEncoder,
                myEncoderParameters);

            //myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            //myEncoderParameters.Param[0] = myEncoderParameter;
            //fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/Download/"), "TestPhotoQuality100.jpeg");
            //bmp1.Save(fileSavePath, jgpEncoder,
            //    myEncoderParameters);

            // Save the bitmap as a JPG file with 75 quality level compression.
            //myEncoderParameter = new EncoderParameter(myEncoder, 75L);
            //myEncoderParameters.Param[0] = myEncoderParameter;
            //fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/Download/"), "TestPhotoQuality75.jpeg");
            //bmp1.Save(fileSavePath, jgpEncoder,
            //    myEncoderParameters);

        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        #endregion[PrivateData]
    }
