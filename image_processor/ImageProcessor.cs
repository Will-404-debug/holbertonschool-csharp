using System;
using System.IO;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            try
            {
                using (Image<Rgba32> image = Image.Load<Rgba32>(filename))
                {
                    image.Mutate(ctx => ctx.Invert()); // Apply color inversion

                    string newFilename = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename)
                    );

                    image.Save(newFilename); // Save with the same format
                    Console.WriteLine($"Saved inverted image: {newFilename}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {filename}: {ex.Message}");
            }
        });
    }
}
