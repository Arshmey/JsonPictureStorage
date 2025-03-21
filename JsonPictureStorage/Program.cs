using System.Buffers.Text;
using System.Text.Json;

namespace JsonPictureStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream file = new FileStream(@"exampler.jpg", FileMode.Open))
            using (MemoryStream data = new MemoryStream())
            {
                file.CopyTo(data);
                File.WriteAllText(@"Done.txt", JsonSerializer.Serialize(data.ToArray()));
            }
        }
    }
}
