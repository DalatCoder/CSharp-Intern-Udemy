using System;

namespace LearnDelegates
{
    public delegate void PhotoFilterHandler(Photo photo);

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
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo();
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();

            processor.Process("photo.jpg", photoFilters.ApplyBrightness);
            processor.Process("photo.jpg", photoFilters.ApplyContrast);
            processor.Process("photo.jpg", photoFilters.Resize);
        }
    }
}
