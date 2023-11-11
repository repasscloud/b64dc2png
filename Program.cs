namespace b64dc2png;
class Program
{
    static void Main(string[] args)
    { 
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: b64dc2png <base64_string>");
            return;
        }

        // Assuming the base64 string is passed as a command-line argument
        string base64ImageString = args[0];

        try
        {
            // Convert base64 string to byte array
            byte[] decodedData = Convert.FromBase64String(base64ImageString);

            // Save it as a PNG file
            File.WriteAllBytes("output.png", decodedData);

            Console.WriteLine("Image saved as output.png");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

