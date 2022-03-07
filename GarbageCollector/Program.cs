// See https://aka.ms/new-console-template for more information
using System.Text;

void example()
{

    using (FileStream fs = new FileStream("MyFile.txt", FileMode.Open))
    {
        var str = "Hello world";
        var bytes = Encoding.UTF8.GetBytes(str);
        var bytesCount = Encoding.ASCII.GetBytes(str);

        fs.Write(bytes, 0, bytesCount);

    }

}