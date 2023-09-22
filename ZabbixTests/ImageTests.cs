using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class ImageTests : TestBase
    {
        [TestMethod]
        public void TestImageCycle()
        {
            Image i =new Image() {
               ImageType = 1,
               ImageBase64 = "iVBORw0KGgoAAAANSUhEUgAAABgAAAANCAYAAACzbK7QAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAACmAAAApgBNtNH3wAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAIcSURBVDjLrZLbSxRRHMdPKiEiRQ89CD0s+N5j9BIMEf4Hg/jWexD2ZEXQbC9tWUFZimtLhswuZiVujK1UJmYXW9PaCUdtb83enL3P7s6ss5f5dc7EUsmqkPuFH3M4/Ob7+V0OAgC0UyDENFEU03rh1uNOs/lFG75o2i2/rkd9Y3Tgyj3HiaezbukdH9A/rP4E9vWi0u+Y4fuGnMf3DRgYc3Z/84YrQSkD3mgKhFAC+KAEK74Y2Lj3MjPoOokQ3Xyx/1GHeXCifbfO6lRPH/wi+AvZQhGSsgKxdB5CCRkCGPbDgMXBMbukTc4vK5/WRHizsq7fZl2LFuvE4T0BZDTXHtgv4TNUqlUolsqQL2qQwbDEXzBBTIJ7I4y/cfAENmHZF4XrY9Mc+X9HAFmoyXS2ddy1IOg6/KNyBcM0DFP/wFZFCcOy4N9Mw0YkCTOfhdL5AfZQXQBFn2t/ODXHC8FYVcoWjNEQ03qqwTJ5FdI44jg/msoB2Zd5ZKq3q6evA1FUS60bYyyj3AJf3V72HiLZJQxTtRLk1C2IYEg4mTNg63hPd1mOJd7Ict911OMNlWEf0nFxpCt16zcshTuLpGSwDDuPIfv0xzNyQYVGicC0cgUUDLM6Xp02lvvW/V2EBssnxlSGmWsxljw0znV9XfPLjTCW84r+cn7Jc8c2eWrbM6Wbe6/aTJbhJ/TNkWc9/xXW592Xb9iPkKnUfH8BKdLgFy0lDyQAAAAASUVORK5CYII=",
               Name = "Testimage"+Id
            };
            TestCycle(i, "Images", new List<string>(){"ImageType"});
        }
        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}
