using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;


namespace Haytham.FXPAL
{


    [DataContract]
    //[Serializable()]
    public class HyperImage
    {
        [DataMember(Name = "name", IsRequired = false)]
        public string name { get; set; }

        [DataMember(Name = "image", IsRequired = false)]
        public string image
        {
            set
            {

                byte[] array = Convert.FromBase64String(value);

                System.IO.MemoryStream dataOutputStream = new System.IO.MemoryStream();
                dataOutputStream.Write(array, 0, array.Length);
                img = Image.FromStream(dataOutputStream);


                //byte[] array = Encoding.ASCII.GetBytes(value);

                //ImageConverter ic = new ImageConverter();
                //img = (Image)ic.ConvertFrom(array);



            }
        }
        [DataMember(Name = "locations", IsRequired = false)]
        public List<Point> locations { get; set; }
        [DataMember(Name = "texts", IsRequired = false)]
        public List<String> texts { get; set; }
        public Image img;
        public double CircleDiam = 60;

        public HyperImage()
        {

        }
        public HyperImage(Image mImage)
        {
            img = mImage;
            locations = new List<Point>();
            texts = new List<string>();
        }
    }



    public class HyperImage_without_image
    {

        public string name { get; set; }
        public List<Point> locations { get; set; }
        public List<String> texts { get; set; }


        public HyperImage_without_image(HyperImage hyper)
        {
            name = hyper.name;
            locations = hyper.locations;
            texts = hyper.texts;
        }

    }
}
