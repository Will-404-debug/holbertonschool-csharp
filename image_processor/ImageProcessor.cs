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
        string rootDirectory = Directory.GetCurrentDirectory(); // Ensures images are saved in the root directory

        Parallel.ForEach(filenames, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, filename =>
        {
            try
            {
                using (Image<Rgba32> image = Image.Load<Rgba32>(filename))
                {
                    image.Mutate(ctx => ctx.Invert()); // Apply color inversion

                    string newFilename = Path.Combine(
                        rootDirectory, // Save in the correct directory
                        Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename)
                    );

                    image.Save(newFilename); // Save the new image
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
