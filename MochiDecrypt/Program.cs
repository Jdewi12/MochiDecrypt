using MochiCryptUnpacker;

internal class Program
{
    private static void Main(string[] args)
    {
        if(args.Length != 1)
            throw new ArgumentException("Supply only one argument (binary payload file)");
        var output = MochiDecrypt.Decrypt(File.ReadAllBytes(args[0]));
        if(output != null)
            File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "/output.swf", output);
    }
}