using System;

namespace LearnDelegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Saving photo...");
        }

    }

    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filter = new PhotoFilters();
            filter.ApplyBrightness(photo);
            filter.ApplyContrast(photo);
            filter.Resize(photo);

            photo.Save();
        }
    }

    internal class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            processor.Process("");
        }
    }
}
