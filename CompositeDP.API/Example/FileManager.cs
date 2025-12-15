namespace CompositeDP.API.Example
{
    public class FileManager
    {
        public FileManager()
        {
            var root = new Folder("Root");
            var documents = new Folder("Documents");
            var images = new Folder("Images");
            var file1 = new File("Resume.pdf", 120000);
            var file2 = new File("Photo.jpg", 350000);
            documents.Add(file1);
            images.Add(file2);
            root.Add(documents);
            root.Add(images);
            root.Print();

            Console.WriteLine(new string('-', 40));

            var findedDocuments = root.Get("Documents");
            findedDocuments.Print();

            Console.WriteLine(new string('-', 40));

            var resumeFile = findedDocuments.Get("Resume.pdf");
            resumeFile.Print();
        }
    }
}
